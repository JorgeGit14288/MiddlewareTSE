using MiddlewareTse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MiddlewareTse.Controllers
{

    [EnableCors("*", "*", "*")]
    public class ConsultarVotacionController : ApiController
    {
        private string token = "9NM+D34KVLzIwjc2eOCcJ5R/Ooteu3/PjqjFDlfyIfayEH52PHGm8U7JHxk69vVI";
        // POST: api/ConsultarVotacion
        [HttpPost]
        [ActionName("test")]
        [Route("api/test")]
        public IHttpActionResult Test()
        {
         
            //creamos el cliente ws
            var resp = new
            {
                resp = true
            };

            return Ok(resp);
            //return Ok(model)
            //IHttpActionResul
        }


        // POST: api/ConsultarVotacion
        [HttpPost]
        [ActionName("getCapcha")]
        [Route("api/getCapcha")]
        public RespuestaCapchaModel getCapcha(SolicitudCapchaModel solicitud)
        {
            RespuestaCapchaModel res = new RespuestaCapchaModel();
            try
            {
                if (!ModelState.IsValid)
                {
                    res.STATUS = "0";
                    res.USRMENSAJE = "Los datos para la consulta no son validos";
                    return res;
                    
                }
                if (solicitud.token != token)
                {
                    res.STATUS = "0";
                    res.USRMENSAJE = "Lo sentimos, no esta autorizado para utilizar este servicio";
                    return res;
                }
                wsConsulta.CaptchaService wsClient = new wsConsulta.CaptchaService ();

                var respuesta = wsClient.Transacciones1(solicitud.codSys, solicitud.cui, solicitud.fechaNacimiento);
                //PARSEAMOS LA RESPUESTA
                res.USRMENSAJE = respuesta.USRMENSAJE;
                res.STATUS = respuesta.STATUS;
                res.IMA = respuesta.IMA;
                res.NTRANS = respuesta.NTRANS;
                
                return res;
            }
            catch (Exception ex)
            {
                res.STATUS = "0";
                res.USRMENSAJE = ex.Message;
                
                return res;
            }
            
        }

        // POST: api/ConsultarVotacion
        [HttpPost]
        [ActionName("obtenerLugar")]
        [Route("api/obtenerLugar")]
        public LugarDeVotacionModel obtenerLugar(validarCapchaModel vModel)
        {
            LugarDeVotacionModel res = new LugarDeVotacionModel();
            try
            {
                if (!ModelState.IsValid)
                {
                    res.STATUS = "0";
                    res.USRMENSAJE = "Los datos enviados no son correctos";
                    return res;
                }
                if (vModel.token != token)
                {
                    res.STATUS = "0";
                    res.USRMENSAJE = "Lo sentimos, no esta autorizado para utilizar este servicio";
                    return res;
                }


                wsConsulta.CaptchaService wsClient = new wsConsulta.CaptchaService();

                var respuesta = wsClient.ObtenerLugar1(vModel.nTransac, vModel.Guid, vModel.Id);
                res.STATUS = respuesta.STATUS;
                res.USRMENSAJE = respuesta.USRMENSAJE;
                res.BOLETA = respuesta.BOLETA;
                res.CENTRO = respuesta.CENTRO;
                res.DEPARTAMENTO = respuesta.DEPARTAMENTO;
                res.DIRECCION = respuesta.DIRECCION;
                res.DPI = respuesta.DPI;
                res.FECHA_DE_NACIMIENTO = respuesta.FECHA_DE_NACIMIENTO;
                res.LINEA = respuesta.LINEA;
                res.MESA_DE_NUMERO = respuesta.MESA_DE_NUMERO;
                res.MUNICIPIO = respuesta.MUNICIPIO;
                res.NOMBRES_APELLIDOS = respuesta.NOMBRES_APELLIDOS;
                res.PAGINA = respuesta.PAGINA;
                return res;
            }
            catch (Exception ex)
            {
                res.STATUS = "0";
                res.USRMENSAJE = ex.Message;
                return res;
            }
        }

    }
}
