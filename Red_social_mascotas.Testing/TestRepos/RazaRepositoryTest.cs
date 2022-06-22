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
    class RazaRepositoryTest
    {
        IQueryable<Raza> data;
        [SetUp]
        public void setup()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            data = new List<Raza>
           {
               new() {Id = 1, Nombre = "Nombre"},
               new() {Id = 2, Nombre = "Nombre"},
               new() {Id = 2, Nombre = "Nombre"}
              }.AsQueryable();
        }
        [Test]
        public void ListaRazasTest()
        {
            var mockDbSetRaza = new MockDBSet<Raza>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._razas).Returns(mockDbSetRaza.Object);
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.ListaRazas();
            Assert.IsNotNull(rpta);
        }

    }
}
