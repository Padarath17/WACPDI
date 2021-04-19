using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACPDI.Models.Request
{
    public class DrMedRequest
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public sbyte? Status { get; set; }
        public string NombreMed { get; set; }
        public int IddoctoresMedicamentos { get; set; }
        public int? Iddoctor { get; set; }
        public int? Idmedicamento { get; set; }
    }
}
}
