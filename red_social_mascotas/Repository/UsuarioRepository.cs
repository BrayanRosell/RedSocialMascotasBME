using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Controllers;
using red_social_mascotas.Models;
using red_social_mascotas.Service;
namespace red_social_mascotas.Repository
{
    public interface IUsuarioRepository
    {

        public Usuario ObtenerUsuarioLogin(Claim claim);
        public Usuario EncontrarUsuario(String user, String password);
        public void AgregarUsuario(string Username, string Password, string Nombres, string Dni, string Telefono, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento, IFormFile Imagen);

        public Dictionary<int, String> IndicesPorId();
        Mascota ListaMascotasTrue();
        List<Publicacion> LisatPublicaciones();
        List<Usuario> ListaUsuariosConComentarios();
        void AddComentary(int IdPublicacion, String descripcion, HttpContext httpContext);
        List<Mascota> ListaMascotas(HttpContext httpContext);
        List<Raza> ListaRazas();
        List<Especie> ListaEspecies();
        void RegistrarMascota(Mascota nueva);
        Mascota ListamascotaPorId(int IdMascota);
        Mascota PonerEnAdopcion(int IdMascota);
        void PonerEnAdopcion(Mascota mascota);
        Mascota PonerEnPublicacion(Mascota mascota);
        void AddPubliccion(Publicacion nueva);
        Publicacion LisatPublicacion(int IdMascota);
        List<Comentario> ListaComentarios(Publicacion sacarAdopcion, HttpContext httpContext);
        void sacarDeAdopcion(Publicacion sacarAdopcion, List<Comentario> comentary);
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private IRSMascotasContext _context;
        private readonly ICookieAuthService _cookieAuthService;

        public UsuarioRepository(RSMascotasContext context, ICookieAuthService cookieAuthService)
        {
            _context = context;
            _cookieAuthService = cookieAuthService;
           
        }

        public Usuario EncontrarUsuario(string user, string password)
        {
            var Usuario = _context._Usuarios.FirstOrDefault(o => o.Username == user && o.Password == password);
            return Usuario;
        }

        public void AgregarUsuario(string Username, string Password, string Nombres, string Dni, string Telefono, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento, IFormFile Imagen)
        {
            Usuario nuevo = new Usuario();
            nuevo.Username = Username;
            nuevo.Password = Password;
            nuevo.Nombres = Nombres;
            nuevo.Dni = Dni;
            nuevo.Telefono = Telefono;
            nuevo.ApellidoPaterno = ApellidoPaterno;
            nuevo.ApellidoMaterno = ApellidoMaterno;
            nuevo.FechaNacimiento = FechaNacimiento;
            nuevo.Imagen = "sinFoto.png";
            _context._Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public Dictionary<int, string> IndicesPorId()
        {
            Dictionary<int, string> indices = new Dictionary<int, string>();
            var usuarios = _context._Usuarios.ToList();

            foreach (var item in usuarios)
            {
                indices.Add(item.Id, item.Nombres);
            }

            return indices;
        }

        public Usuario ObtenerUsuarioLogin(Claim claim)
        {
            var user = _context._Usuarios.FirstOrDefault(o => o.Username == claim.Value);
            return user;
        }

        public Mascota ListaMascotasTrue()
        {
            return _context._mascotas.Where(o => o.EstadoAdoptivo == true).FirstOrDefault();
        }

        public List<Publicacion> LisatPublicaciones()
        {
            return _context._publicaciones.
                Include(o => o.Razas).
                Include(h => h.Usuarios).
                Include(z => z.Especies).
                Include(o => o.Mascotas).
                Include(s => s.Comentarios).
                ToList();
        }

        public List<Usuario> ListaUsuariosConComentarios()
        {
            return _context._Usuarios.Include(f => f.Comentarios).ToList();
        }

        public void AddComentary(int IdPublicacion, string descripcion, HttpContext httpContext)
        {
            _cookieAuthService.SetHttpContext(httpContext);
            Comentario nuevo = new Comentario();
            nuevo.Descripcion = descripcion;
            nuevo.IdUsuario = _cookieAuthService.LoggedUser().Id;
            nuevo.IdPublicacion = IdPublicacion;
            nuevo.FechaPublicacion = DateTime.Now;

            _context._comentario.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Mascota> ListaMascotas(HttpContext httpContext)
        {
            _cookieAuthService.SetHttpContext(httpContext);
            Usuario user = _cookieAuthService.LoggedUser();
            return _context._mascotas.Where(o => o.IdUsuario == user.Id).ToList();
        }

        public List<Raza> ListaRazas()
        {
            return _context._razas.ToList();
        }

        public List<Especie> ListaEspecies()
        {
            return _context._especie.ToList();
        }

        public void RegistrarMascota(Mascota nueva)
        {
            _context._mascotas.Add(nueva);
            _context.SaveChanges();


        }

        public Mascota ListamascotaPorId(int IdMascota)
        {
            //return _context._mascotas.FirstOrDefault(o => o.Id == IdMascota);
            return _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
        }

        public Mascota PonerEnAdopcion(int IdMascota)
        {
            return _context._mascotas.Where(o => o.Id == IdMascota).FirstOrDefault();
        }

        public void PonerEnAdopcion(Mascota mascota)
        {
            _context._mascotas.Update(mascota);
            _context.SaveChanges();
        }

        public Mascota PonerEnPublicacion(Mascota mascota)
        {
            return _context._mascotas.FirstOrDefault(o => o.Id == mascota.Id);
        }

        public void AddPubliccion(Publicacion nueva)
        {
            _context._publicaciones.Add(nueva);
            _context.SaveChanges();
        }

        public Publicacion LisatPublicacion(int IdMascota)
        {
            return _context._publicaciones.Where(s => s.IdMascota == IdMascota).FirstOrDefault();
        }

        public List<Comentario> ListaComentarios(Publicacion sacarAdopcion, HttpContext httpContext)
        {
            _cookieAuthService.SetHttpContext(httpContext);
            return _context._comentario.Where(s => s.IdPublicacion == sacarAdopcion.Id).ToList();
        }

        public void sacarDeAdopcion(Publicacion sacarAdopcion, List<Comentario> comentary)
        {
            _context._publicaciones.Remove(sacarAdopcion);
            _context._comentario.RemoveRange(comentary);
        }
    }
}