using Microsoft.AspNetCore.Http;
using Moq;
using NUnit.Framework;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Models;
using red_social_mascotas.Repository;
using red_social_mascotas.Service;
using Red_social_mascotas.Testing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Red_social_mascotas.Testing.TestRepos
{
    [TestFixture]
    class MascotaRepositoryTest
    {
        IQueryable<Mascota> data;
        [SetUp]
        public void setup()
        {
            data = new List<Mascota>
           {
               new() {Id = 1, Nombre = "mascota", EstadoAdoptivo  = true,  IdEspecie = 1,  IdUsuario = 5, IdRaza = 3},
               new() {Id = 2, Nombre = "mascota2", EstadoAdoptivo  = true,  IdEspecie = 1,  IdUsuario = 5, IdRaza = 3},
               new() {Id = 3, Nombre = "mascota3", EstadoAdoptivo  = true,  IdEspecie = 1,  IdUsuario = 5, IdRaza = 3}
                 }.AsQueryable();
        }
        [Test]
        public void ListaMascotasTrueTest()
        {
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object,null);
            var rpta = repo.ListaMascotasTrue();
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void ListamascotaPorIdTest()
        {
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.ListamascotaPorId(1);
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void PonerEnAdopcionTest()
        {
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.PonerEnAdopcion(1);
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void PonerEnPublicacionTest()
        {
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.PonerEnPublicacion(new Mascota() { Id = 3, Nombre = "mascota3", EstadoAdoptivo = true, IdEspecie = 1, IdUsuario = 5, IdRaza = 3 });
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void ListaMascotasTest()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim>
            {new Claim(ClaimTypes.Name, "Brayan")});
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);

            var mockDBICookieAuthService = new Mock<ICookieAuthService>();
            mockDBICookieAuthService.Setup(o => o.Login(mockClaimsPrincipal.Object));
            mockDBICookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario() { Id = 1, Username = "Meyler", Nombres = "Meyler", Password = "aaaaaa", Dni = "18759643", ApellidoPaterno = "Tejada", ApellidoMaterno = "Portilla", FechaNacimiento = date1, Telefono = "976485912", Imagen = "about-02.jpg" });


            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object, mockDBICookieAuthService.Object);
            
            var rpta = repo.ListaMascotas(mockContext.Object);
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void VoidRegistrarMascotaTest()
        {
            

            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);
            
            var repo = new UsuarioRepository(mockDB.Object, null);
            var mascota = new Mascota() { Id = 1, Nombre = "mascota", EstadoAdoptivo = true, IdEspecie = 1, IdUsuario = 5, IdRaza = 3 };
            repo.RegistrarMascota(mascota);
            mockDbSetMascota.Verify(o => o.Add(mascota), Times.Once());
        }
    }
}
