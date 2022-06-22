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
    class ComentarioRepositoryTest
    {
        IQueryable<Comentario> data;
        [SetUp]
        public void setup()
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            data = new List<Comentario>
           {
               new() {Id = 1, Descripcion = "Comentario", IdUsuario = 1,  IdPublicacion = 5, FechaPublicacion = date1},
               new() {Id = 2, Descripcion = "Comentario", IdUsuario = 2,  IdPublicacion = 3, FechaPublicacion = date1},
               new() {Id = 3, Descripcion = "Comentario", IdUsuario = 3,  IdPublicacion = 2, FechaPublicacion = date1}
               }.AsQueryable();
        }
        [Test]
        public void ListaComentariosTest()
        {
            var mockDbSetComentario = new MockDBSet<Comentario>(data);
            var mockDB = new Mock<RSMascotasContext>();
            mockDB.Setup(o => o._comentario).Returns(mockDbSetComentario.Object);
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            var repo = new UsuarioRepository(mockDB.Object, null);
            //var rpta = repo.ListaComentarios(new Publicacion { Id = 1, Nombre = "Publicacion", Descripcion = "Descripcion",  FechaPublicacion = date1,  IdRaza = 5, IdEspecie = 3,IdUsuario = 3,IdMascota = 3},null);
            //Assert.IsNotNull(rpta);
        }
        
    }
}
