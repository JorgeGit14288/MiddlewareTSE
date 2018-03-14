using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddlewareTse.Models
{
    public class httpRespuesta
    {
        public string status { get; set; }
        public string mensaje { get; set; }
        public object data { get; set; }
    }
}