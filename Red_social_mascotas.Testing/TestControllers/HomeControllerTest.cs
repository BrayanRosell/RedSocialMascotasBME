using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Hosting;
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
            //RedirectToActionResult
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
            //RedirectToActionResult
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
            //RedirectToActionResult
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
            //RedirectToActionResult
            Assert.IsNotNull(view);
        }
    }
}
