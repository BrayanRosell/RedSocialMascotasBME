using System;

namespace red_social_mascotas.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}