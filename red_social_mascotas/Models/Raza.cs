﻿using System;
using System.Collections.Generic;

namespace red_social_mascotas.Models
{
    public class Raza
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public List<Mascota> Mascotas { get; set; }
    }
}