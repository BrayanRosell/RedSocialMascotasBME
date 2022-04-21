using System;
using System.Collections.Generic;

namespace red_social_mascotas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Nombres { get; set; }
        public String Dni { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}