using System;
using System.Collections.Generic;

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
        public Usuario Usuarios { get; set; }
        public Raza Razas { get; set; }
        public Especie Especies { get; set; }
        public List<Publicacion> Publicaciones { get; set; }
        public List<Foto> Fotos { get; set; }
    }
}