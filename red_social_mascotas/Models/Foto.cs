using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace red_social_mascotas.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public String Imagen { get; set; }
        public int IdMascota { get; set; }
        public Mascota Mascotas { get; set; }
    }
}
