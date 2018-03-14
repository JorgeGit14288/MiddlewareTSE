using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddlewareTse.Models
{
    public class LugarDeVotacionModel
    {
        public string boleta { get; set; }
        public string dpi { get; set; }
        public string nombre { get; set; }
        public string fechaNacimiento { get; set; }
        public string numeroMesa { get; set; }
        public string pagina { get; set; }
        public string linea { get; set; }
        public string centro { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
    }
}