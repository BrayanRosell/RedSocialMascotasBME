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
    public class Authtest
    {
        [Test]
       
        public void IndexGet()
        {
            var _usuario = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
      

            var controller = new AuthController(_usuario.Object, _cookieAuthService.Object);
            var view = controller.Login() as ViewResult;

            Assert.IsNotNull(view);

        }
    }
}