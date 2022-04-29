using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Models;
using red_social_mascotas.Repository;
using red_social_mascotas.Service;

namespace red_social_mascotas.Controllers
{
    public class HomeController : Controller
    {
        private RSMascotasContext _context;
        private readonly ICookieAuthService _cookieAuthService;
        private readonly IUsuarioRepository _usuario;
        [Obsolete]
        private IHostingEnvironment env;

        [Obsolete]
        public HomeController(RSMascotasContext _context,
            ICookieAuthService _cookieAuthService
            , IUsuarioRepository _usuario, IHostingEnvironment env)
        {

            this._context = _context;
            this._cookieAuthService = _cookieAuthService;
            this._usuario = _usuario;
            this.env = env;

        }
        public IActionResult Index(/*Comentario nuevo,*/ String busqueda = "")
        {
            ViewBag.usurioLoged = LoggedUser().Username;
            ViewBag.Imagen = LoggedUser().Imagen;
            ViewBag.duenio = _context._mascotas.Where(o => o.EstadoAdoptivo == true).FirstOrDefault();
            ViewBag.Publicacion = _context._publicaciones.
                Include(o => o.Razas).
                Include(h => h.Usuarios).
                Include(z => z.Especies).
                Include(o => o.Mascotas).
                Include(s => s.Comentarios).    
                ToList();
   
            ViewBag.PaseParaQuenosecaiga = _context._Usuarios.Include(f=>f.Comentarios).ToList();//no eliminar
            return View();
        }
        [HttpPost]
        public IActionResult Comentario(int IdPublicacion, String descripcion)
        { 
            Comentario nuevo = new Comentario();
            nuevo.Descripcion = descripcion;
            nuevo.IdUsuario = LoggedUser().Id;
            nuevo.IdPublicacion = IdPublicacion;
            nuevo.FechaPublicacion = DateTime.Now;

            _context._comentario.Add(nuevo);
            _context.SaveChanges();
            return RedirectToAction("Index"/*,nuevo*/);
        }
        public IActionResult MisMascotas()
        {
            
            Usuario user = LoggedUser();
            ViewBag.usurioLoged = user.Username;
            ViewBag.mismascotas = _context._mascotas.Where(o => o.IdUsuario == user.Id).ToList();
            ViewBag.Imagen = LoggedUser().Imagen;

            var raza = _context._razas.ToList();
            var especie = _context._especie.ToList();
            Dictionary<int, Raza> razamascota = new Dictionary<int, Raza>();
            foreach (var item in raza)
            {
                razamascota.Add(item.Id, item);
            }

            Dictionary<int, Especie> especiemascota = new Dictionary<int, Especie>();
            foreach (var item in especie)
            {
                especiemascota.Add(item.Id, item);
            }

            ViewBag.raza = razamascota;
            ViewBag.especie = especiemascota;

            return View();
        }

        public IActionResult RegistarMascota()
        {
            ViewBag.Imagen = LoggedUser().Imagen;
            ViewBag.Especie = _context._especie.ToList();
            ViewBag.Raza = _context._razas.ToList();
            return View();
        }
       
        public IActionResult RegistrarMascota(string NombreMascota, int EspecieId, int RazaId, IFormFile Imagen, IFormFile Imagen2, IFormFile Imagen3)
        {
            
           
            Mascota nueva = new Mascota();
            nueva.Nombre = NombreMascota;
            nueva.EstadoAdoptivo = false;
            nueva.IdEspecie = EspecieId;
            nueva.IdRaza = RazaId;
            nueva.IdUsuario = LoggedUser().Id;
            nueva.Imagen = "vacio";
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(env.WebRootPath, "images", Imagen.FileName);
                var filePath2 = Path.Combine(env.WebRootPath, "images", Imagen2.FileName);
                var filePath3 = Path.Combine(env.WebRootPath, "images", Imagen3.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    Imagen.CopyTo(stream);
                }
                using (var stream = new FileStream(filePath2, FileMode.Create))
                {
                    Imagen2.CopyTo(stream);
                }
                using (var stream = new FileStream(filePath3, FileMode.Create))
                {
                    Imagen3.CopyTo(stream);
                }

                nueva.Imagen = Imagen.FileName;
                nueva.Imagen2 = Imagen2.FileName;
                nueva.Imagen3 = Imagen3.FileName;
            }

            _context._mascotas.Add(nueva);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult PonerEnAdopccion(int IdMascota)
        {
            
            ViewBag.mimascota = _context._mascotas.FirstOrDefault(o => o.Id == IdMascota);
            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
            mascota.EstadoAdoptivo = true;
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            return RedirectToAction("PonerEnPublicacion", mascota);
        }
        [HttpGet]
        public IActionResult PonerEnPublicacion(Mascota mascota)
        {
            ViewBag.Imagen = LoggedUser().Imagen;
            ViewBag.mimascota = _context._mascotas.FirstOrDefault(o => o.Id == mascota.Id);
            return View();
        }
       [HttpPost]
        public IActionResult PonerEnPublicacion(int IdMascota, string descripcion)
        {
            Usuario user = LoggedUser();
            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();

            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            Publicacion nueva = new Publicacion();
            nueva.Descripcion = descripcion;
            nueva.Nombre = mascota.Nombre;
            nueva.FechaPublicacion = DateTime.Now;
            nueva.IdEspecie = mascota.IdEspecie;
            nueva.IdRaza = mascota.IdRaza;
            nueva.IdUsuario = user.Id;
            nueva.IdMascota = IdMascota;
            _context._publicaciones.Add(nueva);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SacarDeAdopcion(int IdMascota)
        {
           
            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
            var sacarAdopcion = _context._publicaciones.Where(s => s.IdMascota == IdMascota).FirstOrDefault();

            var comentary = _context._comentario.Where(s => s.IdPublicacion == sacarAdopcion.Id).ToList();
            if (sacarAdopcion.IdMascota == IdMascota)
            {
                _context._publicaciones.Remove(sacarAdopcion);
                _context._comentario.RemoveRange(comentary);
            }
            mascota.EstadoAdoptivo = false;
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            return RedirectToAction("MisMascotas"); 
        }

       

        public IActionResult Test(int IdMascota)
        {
            
            ViewBag.IdMascota = IdMascota;
            return View();
        }

        public IActionResult calificar(int IdMascota, int select1, int select2, int select3, int select4, int select5)
        {
            Usuario user = LoggedUser();
            if (select1 + select2 + select3 + select4 + select5 > 12)
            {
                var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
                mascota.IdUsuario = user.Id;
                mascota.EstadoAdoptivo = true;
                _context._mascotas.Update(mascota);
                _context.SaveChanges();
                mascota.EstadoAdoptivo = false;
                _context._mascotas.Update(mascota);
                _context.SaveChanges();
                return RedirectToAction("MisMascotas");
            }

            return RedirectToAction("Index");
        }

      
        
        public IActionResult Privacy()
        {
            ViewBag.Imagen = LoggedUser().Imagen;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        private Usuario LoggedUser()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var claim = _cookieAuthService.ObtenerClaim();
            var user = _usuario.ObtenerUsuarioLogin(claim);
            return user;
        }
    }
}