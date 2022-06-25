using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Controllers;
using red_social_mascotas.Models;
using red_social_mascotas.Repository;
using red_social_mascotas.Service;

namespace Red_social_mascotas.Testing
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        [Obsolete]
        public void IndexGet()
        {
           
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.Index("") as ViewResult;

            Assert.IsNotNull(view);

        }

        [Test]
        [Obsolete]
        public void RegistarMascotaGet()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var env = new Mock<IHostingEnvironment>();
            var controller = new HomeController(_context.Object, _cookieAuthService.Object,null);
            var view = controller.RegistarMascota() as ViewResult;
            Assert.IsNotNull(view);
        }
       
        [Test]
        [Obsolete]
        public void RegistarMascota()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.RegistarMascota() as ViewResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void PonerEnPublicacion()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.PonerEnPublicacion(new Mascota()) as ViewResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void Privacy()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.Privacy() as ViewResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void ComentarioPost()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.Comentario(1,"descripcion") as RedirectToActionResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void MisMascotasGet()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            _context.Setup(o => o.ListaMascotas(mockContext.Object));
            _context.Setup(o => o.ListaRazas()).Returns(new List<Raza>());
            _context.Setup(o => o.ListaEspecies()).Returns(new List<Especie>());
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.MisMascotas() as ViewResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void PonerEnAdopccionGet()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            _context.Setup(o => o.ListamascotaPorId(1)).Returns(new Mascota());
            _context.Setup(o => o.PonerEnAdopcion(1)).Returns(new Mascota());
            _context.Setup(o => o.PonerEnAdopcion(new Mascota()));

            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.PonerEnAdopccion(1) as RedirectToActionResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void PonerEnPublicacionPost()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            _context.Setup(o => o.ListamascotaPorId(1)).Returns(new Mascota());
            _context.Setup(o => o.PonerEnAdopcion(new Mascota()));

            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);

            Publicacion nueva = new Publicacion();
            nueva.Descripcion = "descripcion";
            nueva.Nombre = "Nombre";
            nueva.FechaPublicacion = date1;
            nueva.IdEspecie = 1;
            nueva.IdRaza = 1;
            nueva.IdUsuario = 1;
            nueva.IdMascota = 1;

            _context.Setup(o => o.AddPubliccion(nueva));

            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.PonerEnPublicacion(1,"Descripcion") as RedirectToActionResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void SacarDeAdopcionGet()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            _context.Setup(o => o.ListamascotaPorId(1)).Returns(new Mascota());
            _context.Setup(o => o.LisatPublicacion(1)).Returns(new Publicacion());
            _context.Setup(o => o.ListaComentarios(new Publicacion(), mockContext.Object)).Returns(new List<Comentario>());
            _context.Setup(o => o.sacarDeAdopcion(new Publicacion(), new List<Comentario>()));
            _context.Setup(o => o.PonerEnAdopcion(new Mascota()));

            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.SacarDeAdopcion(1) as RedirectToActionResult;
            Assert.IsNotNull(view);
        }
        [Test]
        [Obsolete]
        public void TestGet()
        {

            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.Test(1) as ViewResult;

            Assert.IsNotNull(view);

        }
        [Test]
        [Obsolete]
        public void calificarGet()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var _context = new Mock<IUsuarioRepository>();
            _context.Setup(o => o.ListamascotaPorId(1)).Returns(new Mascota());
  
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new HomeController(_context.Object, _cookieAuthService.Object, null);
            var view = controller.calificar(1,2,3,4,5,6) as RedirectToActionResult;
            Assert.IsNotNull(view);
        }
    }
}
