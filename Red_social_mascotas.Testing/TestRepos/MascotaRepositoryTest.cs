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
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            
            //var rpta = repo.ListaMascotas(null);
            //Assert.IsNull(rpta);
        }
        [Test]
        public void VoidRegistrarMascotaTest()
        {
            var mockDbSetMascota = new MockDBSet<Mascota>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._mascotas).Returns(mockDbSetMascota.Object);
  
            var repo = new UsuarioRepository(mockDB.Object, null);
            repo.RegistrarMascota(new Mascota() { Id = 1, Nombre = "mascota", EstadoAdoptivo = true, IdEspecie = 1, IdUsuario = 5, IdRaza = 3 });

            //var datoMockAddUser = data.First(o => o.Id == 1);
            //mockDbSetMascota.Verify(o => o.Add(datoMockAddUser), Times.Once());
        }
    }
}
