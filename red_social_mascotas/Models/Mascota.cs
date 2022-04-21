using System;

namespace red_social_mascotas.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public bool EstadoAdoptivo { get; set; }
        public int IdEspecie { get; set; }
        public int IdRaza{ get; set; }
        public int IdUsuario { get; set; }
        
        public String Imagen { get; set; }
        public Usuario Usuarios { get; set; }
        public Raza Razas { get; set; }

    }
}