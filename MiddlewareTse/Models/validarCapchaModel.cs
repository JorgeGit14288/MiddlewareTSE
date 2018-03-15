using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddlewareTse.Models
{
    public class validarCapchaModel
    {
        public string token { get; set; }
        public string nTransac { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
    }
}