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
        private readonly IUsuarioRepository _context;
        private readonly ICookieAuthService _cookieAuthService;
        [Obsolete]
        private IHostingEnvironment _env;
        [Obsolete]
        public HomeController(IUsuarioRepository _context,ICookieAuthService _cookieAuthService, IHostingEnvironment _env)
        {

            this._context = _context;
            this._cookieAuthService = _cookieAuthService;
            this._env = _env;
            _cookieAuthService.SetHttpContext(HttpContext);
        }
        public IActionResult Index(String search)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.usurioLoged = _cookieAuthService.LoggedUser().Username;
            ViewBag.Imagen = _cookieAuthService.LoggedUser().Imagen;
            ViewBag.duenio = _context.ListaMascotasTrue();
            ViewBag.Publicacion = _context.LisatPublicaciones();
            var mascotas = _context.ListaMascotas(HttpContext);
            //
            if (!String.IsNullOrEmpty(search))
            {
                ViewBag.VerificaMascota = mascotas.Where(s => s.Nombre.Contains(search)).FirstOrDefault(); 
                mascotas = mascotas.Where(o => o.Nombre.Contains(search)).ToList();
                ViewBag.mascotaPase = mascotas;
                return View("Buscar");
            }

            //

            ViewBag.Model = _context.ListaUsuariosConComentarios();//no eliminar
            return View();
        }
       
        [HttpPost]
        public IActionResult Comentario(int IdPublicacion, String descripcion)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            _context.AddComentary(IdPublicacion,descripcion, HttpContext);
            return RedirectToAction("Index"/*,nuevo*/);
        }
        [HttpGet]
        public IActionResult MisMascotas()
        { 
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.usurioLoged = _cookieAuthService.LoggedUser().Username;
            ViewBag.mismascotas = _context.ListaMascotas(HttpContext);
            ViewBag.Imagen = _cookieAuthService.LoggedUser().Imagen;

            var raza = _context.ListaRazas();
            var especie = _context.ListaEspecies();
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

            return View("MisMascotas");
        }

        public IActionResult RegistarMascota()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.Imagen = _cookieAuthService.LoggedUser().Imagen;
            ViewBag.Especie = _context.ListaEspecies();
            ViewBag.Raza = _context.ListaRazas();
            return View();
        }

        [Obsolete]
        public IActionResult RegistrarMascota(string NombreMascota, int EspecieId, int RazaId, List<IFormFile> Imagen)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            List<Foto> picture = new List<Foto>();
            Mascota nueva = new Mascota();
            nueva.Nombre = NombreMascota;
            nueva.EstadoAdoptivo = false;
            nueva.IdEspecie = EspecieId;
            nueva.IdRaza = RazaId;
            nueva.IdUsuario = _cookieAuthService.LoggedUser().Id;
           

            if (ModelState.IsValid)
            {
                _context.RegistrarMascota(nueva);

                foreach (var item in Imagen)
                {
                    var image = new Foto();

                    image.IdMascota = nueva.Id;
                    var filePath = Path.Combine(_env.WebRootPath, "images", item.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        item.CopyTo(stream);
                    }

                    image.Imagen = item.FileName;
                    picture.Add(image);
                }
            }
            _context.RegistrarFotos(picture);
            return RedirectToAction("MisMascotas");
        }
        [HttpGet]
        public IActionResult PonerEnAdopccion(int IdMascota)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.mimascota = _context.ListamascotaPorId(IdMascota);
            var mascota = _context.PonerEnAdopcion(IdMascota);
            mascota.EstadoAdoptivo = true;
            _context.PonerEnAdopcion(mascota);
           
            return RedirectToAction("PonerEnPublicacion", mascota);
        }
        [HttpGet]
        public IActionResult PonerEnPublicacion(Mascota mascota)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.Imagen = _cookieAuthService.LoggedUser().Imagen;
            ViewBag.mimascota = _context.PonerEnPublicacion(mascota);
            return View();
        }
       [HttpPost]
        public IActionResult PonerEnPublicacion(int IdMascota, string descripcion)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            Usuario user = _cookieAuthService.LoggedUser();
            var mascota = _context.ListamascotaPorId(IdMascota);

            _context.PonerEnAdopcion(mascota);
            Publicacion nueva = new Publicacion();
            nueva.Descripcion = descripcion;
            nueva.Nombre = mascota.Nombre;
            nueva.FechaPublicacion = DateTime.Now;
            nueva.IdEspecie = mascota.IdEspecie;
            nueva.IdRaza = mascota.IdRaza;
            nueva.IdUsuario = user.Id;
            nueva.IdMascota = IdMascota;
            _context.AddPubliccion(nueva);
            return RedirectToAction("Index");
        }
        public IActionResult SacarDeAdopcion(int IdMascota)
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var mascota = _context.ListamascotaPorId(IdMascota);
            var sacarAdopcion = _context.LisatPublicacion(IdMascota);

            var comentary = _context.ListaComentarios(sacarAdopcion, HttpContext);
            if (sacarAdopcion.IdMascota == IdMascota)
            {
                _context.sacarDeAdopcion(sacarAdopcion, comentary);
            }
            mascota.EstadoAdoptivo = false;
            _context.PonerEnAdopcion(mascota);
            return RedirectToAction("MisMascotas"); 
        }

       

        public IActionResult Test(int IdMascota)
        {
            
            ViewBag.IdMascota = IdMascota;
            return View("Test");
        }

        public IActionResult calificar(int IdMascota, int select1, int select2, int select3, int select4, int select5)
        {
            Usuario user = _cookieAuthService.LoggedUser();
            if (select1 + select2 + select3 + select4 + select5 > 12)
            {
                var mascota = _context.ListamascotaPorId(IdMascota);
                mascota.IdUsuario = user.Id;
                mascota.EstadoAdoptivo = true;
                _context.PonerEnAdopcion(mascota);
                mascota.EstadoAdoptivo = false;
                _context.PonerEnAdopcion(mascota);
                return RedirectToAction("MisMascotas");
            }

            return RedirectToAction("Index");
        }

      
        
        public IActionResult Privacy()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.Imagen = _cookieAuthService.LoggedUser().Imagen;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}