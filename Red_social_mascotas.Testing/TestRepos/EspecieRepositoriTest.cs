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
    class EspecieRepositoriTest
    {
        IQueryable<Especie> data;
        [SetUp]
        public void setup()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            data = new List<Especie>
           {
               new() {Id = 1, Nombre = "Nombre"},
               new() {Id = 2, Nombre = "Nombre"},
               new() {Id = 2, Nombre = "Nombre"}
              }.AsQueryable();
        }
        [Test]
        public void ListaEspeciesTest()
        {
            var mockDbSetEspecie = new MockDBSet<Especie>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._especie).Returns(mockDbSetEspecie.Object);
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.ListaEspecies();
            Assert.IsNotNull(rpta);
        }

    }
}
