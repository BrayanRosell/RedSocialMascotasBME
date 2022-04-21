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
        private readonly ILogger<HomeController> _logger;
        private RSMascotasContext _context;
        private readonly ICookieAuthService _cookieAuthService;
        private readonly IUsuarioRepository _usuario;
        [Obsolete]
        private IHostingEnvironment env;

        [Obsolete]
        public HomeController(ILogger<HomeController> logger, RSMascotasContext _context,
            ICookieAuthService _cookieAuthService
            , IUsuarioRepository _usuario,IHostingEnvironment env)
        {
            _logger = logger;
            this._context = _context;
            this._cookieAuthService = _cookieAuthService;
            this._usuario = _usuario;
            this.env = env;

        }

        public IActionResult Index(String busqueda = "")
        {
            ViewBag.usurioLoged = LoggedUser().Username;
            ViewBag.enAdopcion = _context._mascotas.Where(o => o.EstadoAdoptivo == true && o.IdUsuario  != LoggedUser().Id).Include(o => o.Razas).ToList();
            return View();
        }

        public IActionResult MisMascotas()
        {
            
            Usuario user = LoggedUser();
            ViewBag.usurioLoged = user.Username;
            ViewBag.mismascotas = _context._mascotas.Where(o => o.IdUsuario == user.Id).ToList();
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
            ViewBag.Especie = _context._especie.ToList();
            ViewBag.Raza = _context._razas.ToList();
            return View();
        }

        public IActionResult GuardarMascota(string NombreMascota, int EspecieId, int RazaId, IFormFile Imagen)
        {
            
            Usuario user = LoggedUser();
            Mascota nueva = new Mascota();
            nueva.Nombre = NombreMascota;
            nueva.EstadoAdoptivo = false;
            nueva.IdEspecie = EspecieId;
            nueva.IdRaza = RazaId;
            nueva.IdUsuario = user.Id;
            nueva.Imagen = "xx";
            if (ModelState.IsValid)
            {
                var filePath = Path.Combine(env.WebRootPath, "images", Imagen.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    Imagen.CopyTo(stream);
                }

                nueva.Imagen = Imagen.FileName;
            }

            _context._mascotas.Add(nueva);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PonerEnAdopccion(int IdMascota)
        {
            ViewBag.mimascota = _context._mascotas.FirstOrDefault(o => o.Id == IdMascota);
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
            

            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
            mascota.EstadoAdoptivo = true;
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            return RedirectToAction("MisMascotas");
        }

        public IActionResult SacarDeAdopcion(int IdMascota)
        {
            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
            mascota.EstadoAdoptivo = false;
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            return RedirectToAction("MisMascotas");
        }

        public IActionResult guardarPublicacion(int IdMascota, string descripcion)
        {
            Usuario user = LoggedUser();
            var mascota = _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
           
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
            Publicacion nueva = new Publicacion();
            nueva.Descripcion = descripcion;
            nueva.Estado = true;
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

        public IActionResult Comentarios(int IdPublicacion)
        {
            var ComentariosPublicacion = _context._comentario.Where(o => o.IdPublicacion == IdPublicacion).ToList().OrderBy(o=>o.FechaPublicacion).ToList();
            var usuario = _context._Usuarios.ToList();
            ViewBag.Comentarios = ComentariosPublicacion;
            Dictionary<int, Usuario> nombreusuario = new Dictionary<int, Usuario>();
            foreach (var item in usuario)
            {
                nombreusuario.Add(item.Id, item);
            }
            ViewBag.IdPublicacion = IdPublicacion;
            ViewBag.usuarios = nombreusuario;
            
            return View();
        } 
        public IActionResult AgregarComentario(int IdPublicacion,string descripcion)
        {
            Usuario user = LoggedUser();
            Comentario nuevo = new Comentario();
            nuevo.Descripcion = descripcion;
            nuevo.IdPublicacion = IdPublicacion;
            nuevo.IdUsuario = user.Id;
            nuevo.FechaPublicacion = DateTime.Now;
            _context._comentario.Add(nuevo);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Privacy()
        {
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