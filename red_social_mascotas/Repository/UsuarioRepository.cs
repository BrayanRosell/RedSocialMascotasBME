using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using red_social_mascotas.BaseDatos;
using red_social_mascotas.Models;

namespace red_social_mascotas.Repository
{
    public interface IUsuarioRepository
    {
       
        public Usuario ObtenerUsuarioLogin(Claim claim);
        public Usuario EncontrarUsuario(String user, String password);
        public void AgregarUsuario(string Username, string Password, string Nombres, string Dni, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento);

        public Dictionary<int, String> IndicesPorId();
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private RSMascotasContext _context;

        public UsuarioRepository(RSMascotasContext context)
        {
            _context = context;
        }

        public Usuario EncontrarUsuario(string user, string password)
        {
            var Usuario = _context._Usuarios.FirstOrDefault(o => o.Username == user && o.Password == password);
            return Usuario;
        }

        public void AgregarUsuario(string Username, string Password, string Nombres, string Dni, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento)
        {
            Usuario nuevo = new Usuario();
            nuevo.Username = Username;
            nuevo.Password = Password;
            nuevo.Nombres = Nombres;
            nuevo.Dni = Dni;
            nuevo.ApellidoPaterno = ApellidoPaterno;
            nuevo.ApellidoMaterno = ApellidoMaterno;
            nuevo.FechaNacimiento = FechaNacimiento;
            _context._Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public Dictionary<int, string> IndicesPorId()
        {
            Dictionary<int, string> indices = new Dictionary<int, string>();
            var usuarios = _context._Usuarios.ToList();

            foreach (var item in usuarios)
            {
                indices.Add(item.Id,item.Nombres);
            }

            return indices;
        }

        public Usuario ObtenerUsuarioLogin(Claim claim)
        {
            var user = _context._Usuarios.FirstOrDefault(o => o.Username == claim.Value);
            return user;
        }

       
    }
}
