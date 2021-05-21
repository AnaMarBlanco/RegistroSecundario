﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroSecundario.Entidades
{
    public class Paises
    {
        [Key]
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public string Idioma { get; set; }
    }
}
