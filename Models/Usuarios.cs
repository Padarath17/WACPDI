using System;
using System.Collections.Generic;

namespace WACPDI.Models
{
    public partial class Usuarios
    {
        public int Idusuarios { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}
