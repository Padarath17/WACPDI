using System;
using System.Collections.Generic;

namespace WACPDI.Models
{
    public partial class DoctoresMedicamentos
    {
        public int IddoctoresMedicamentos { get; set; }
        public int? Iddoctor { get; set; }
        public int? Idmedicamento { get; set; }
    }
}
