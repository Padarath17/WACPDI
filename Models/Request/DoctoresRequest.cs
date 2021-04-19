using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACPDI.Models.Request
{
    public class DoctoresRequest
    {
        public int Iddoctor { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public sbyte? Status { get; set; }
    }
}
