using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddlewareTse.Models
{
    public class validarCapchaModel
    {
        public string transaccion { get; set; }
        public string codigoCapcha { get; set; }
        public string codigoSistema { get; set; }
    }
}