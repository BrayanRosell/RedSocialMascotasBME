using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

namespace Red_social_mascotas.Testing
{
    [TestFixture]
    public class UsuarioRepositoryTest
    {

        IQueryable<Usuario> data;
        [SetUp]
        public void setup()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            data = new List<Usuario>
           {
               new() {Id = 1, Username = "Meyler", Nombres  = "Meyler",  Password ="aaaaaa",  Dni="18759643",    ApellidoPaterno="Tejada",  ApellidoMaterno="Portilla" , FechaNacimiento =date1, Telefono = "976485912" ,Imagen ="about-02.jpg"},
               new() {Id = 2, Username = "Brayan", Nombres  = "Brayan",  Password ="aaaaaa",  Dni="18759643",    ApellidoPaterno="Tejada",  ApellidoMaterno="Portilla" , FechaNacimiento =date1, Telefono = "976485912" ,Imagen ="about-02.jpg"},
               new() {Id = 3, Username = "Rosell", Nombres  = "Rosell",  Password ="aaaaaa",  Dni="18759643",    ApellidoPaterno="Tejada",  ApellidoMaterno="Portilla" , FechaNacimiento =date1, Telefono = "976485912" ,Imagen ="about-02.jpg"}
           }.AsQueryable();
        }
        [Test]
        public void EncontrarUsuarioTest()
        {
            var mockDbSetUsuario = new MockDBSet<Usuario>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._Usuarios).Returns(mockDbSetUsuario.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.EncontrarUsuario("Meyler", "aaaaaa");
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void ObtenerUsuarioLoginTest()
        {
            var mockDbSetUsuario = new MockDBSet<Usuario>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._Usuarios).Returns(mockDbSetUsuario.Object);

            var repo = new UsuarioRepository(mockDB.Object, null);
            var rpta = repo.ListaUsuariosConComentarios();
            Assert.IsNotNull(rpta);
        }
        [Test]
        public void VoidAgregarUsuarioTest()
        {
            var mockDbSetUsuario = new MockDBSet<Usuario>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._Usuarios).Returns(mockDbSetUsuario.Object);
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            IFormFile foto = null;
            var repo = new UsuarioRepository(mockDB.Object, null);
            repo.AgregarUsuario("Meyler", "aaaaaa", "Meyler", "18759643", "976485912", "Portilla", "PortillaMaterno", date1, foto);

            //var datoMockAddUser = data.First(o => o.Id == 1);
            //mockDbSetUsuario.Verify(o => o.Add(datoMockAddUser), Times.Once());
        }

    }
}
