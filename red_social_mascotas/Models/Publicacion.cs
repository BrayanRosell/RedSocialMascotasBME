using System;

namespace red_social_mascotas.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public bool Estado { get; set; }
        public int IdRaza { get; set; }
        public int IdEspecie{ get; set; }
        
        public int IdUsuario{ get; set; }
        public int IdMascota{ get; set; }
        
    }
}