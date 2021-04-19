using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACPDI.Models.Request
{
    public class MedicamentosRequest
    {
        public int Idmedicamento { get; set; }
        public string Nombre { get; set; }
        public string Compuesto { get; set; }
        public float? Miligramos { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
