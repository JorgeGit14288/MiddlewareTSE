using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddlewareTse.Models
{
    public class SolicitudCapchaModel
    {
        public string token { get; set; }
        public string codSys { get; set; }   //ef1b058bc386
        public string cui { get; set; } 
        public string fechaNacimiento { get; set; }
    }

}