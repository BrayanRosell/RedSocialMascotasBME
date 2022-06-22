using Moq;
using NUnit.Framework;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Models;
using red_social_mascotas.Repository;
using Red_social_mascotas.Testing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Red_social_mascotas.Testing.TestRepos
{
    [TestFixture]
    class PublicacionRepositoryTest
    {
        IQueryable<Publicacion> data;
        [SetUp]
        public void setup()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            data = new List<Publicacion>
           {
               new() {Id = 1, Nombre = "Publicacion", Descripcion  = "Descripcion",  FechaPublicacion = date1,  IdRaza = 5, IdEspecie = 3,IdUsuario = 3,IdMascota = 3},
               new() {Id = 2, Nombre = "Publicacion2", Descripcion  = "Descripcion2",  FechaPublicacion = date1,  IdRaza = 8, IdEspecie = 3,IdUsuario = 3,IdMascota = 3},
               new() {Id = 3, Nombre = "Publicacion3", Descripcion  = "Descripcion3",  FechaPublicacion = date1,  IdRaza = 9, IdEspecie = 3,IdUsuario = 3,IdMascota = 3},
               new() {Id = 4, Nombre = "Publicacion4", Descripcion  = "Descripcion4",  FechaPublicacion = date1,  IdRaza = 3, IdEspecie = 3,IdUsuario = 3,IdMascota = 3}        
                 }.AsQueryable();
        }
        [Test]
        public void LisatPublicacionesTest()
        {
            var mockDbSetPublicacion = new MockDBSet<Publicacion>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._publicaciones).Returns(mockDbSetPublicacion.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.LisatPublicaciones();
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void LisatPublicacionPorIdTest()
        {
            var mockDbSetPublicacion = new MockDBSet<Publicacion>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._publicaciones).Returns(mockDbSetPublicacion.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.LisatPublicacion(3);
            Assert.IsNotNull(rpta);
        }

    }
}
