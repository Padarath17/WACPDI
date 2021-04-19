using System;
using System.Collections.Generic;

namespace WACPDI.Models
{
    public partial class Medicamentos
    {
        public int Idmedicamento { get; set; }
        public string Nombre { get; set; }
        public string Compuesto { get; set; }
        public float? Miligramos { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
