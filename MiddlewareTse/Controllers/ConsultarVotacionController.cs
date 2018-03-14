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
    /*
     * 
     * STATUS:0,1 //SI ES 1 ES EXITO, 0 ERROR, MOSTRAR USR/MESSAGE
     * USRMENSAJE: STRING
     * 
     * 
     * */
    [EnableCors("*", "*", "*")]
    public class ConsultarVotacionController : ApiController
    {
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
        public httpRespuesta getCapcha(SolicitudCapchaModel solicitud)
        {
            httpRespuesta res = new httpRespuesta();
            try
            {
                
                if (!ModelState.IsValid)
                {
                    return null;
                }
                //creamos el cliente ws
                //wsTSE.CaptchaServiceSoapClient wsClient = new wsTSE.CaptchaServiceSoapClient();
                
                wsConsulta.CaptchaService wsClient = new wsConsulta.CaptchaService ();

                var respuesta = wsClient.Transacciones1(solicitud.codSys, solicitud.cui, solicitud.fechaNacimiento);

                //var respuesta = wsClient.Transacciones1(solicitud.codSys, solicitud.cui, solicitud.fechaNacimiento);
                res.status = respuesta.STATUS;
                res.mensaje = respuesta.USRMENSAJE;
                RespuestaCapchaModel model = new RespuestaCapchaModel();
                model.imagen = respuesta.IMA;
                model.transaccion = respuesta.NTRANS;
                res.data = model;
                return res;
                //return Ok(model);
                //IHttpActionResul

            }
            catch (Exception ex)
            {
                res.status = "0";
                res.mensaje = ex.Message;
                res.data = null; 
                return res;
            }
            
        }

        // POST: api/ConsultarVotacion
        [HttpPost]
        [ActionName("validarCapcha")]
        [Route("api/validarCapcha")]
        public httpRespuesta validarCapcha(validarCapchaModel vModel)
        {
            httpRespuesta res = new httpRespuesta();
            try
            {
                if (!ModelState.IsValid)
                {
                    return null;
                }

                //creamos el cliente ws
                // wsTSE.CaptchaServiceSoapClient wsClient = new wsTSE.CaptchaServiceSoapClient();
                //WsTse.CaptchaServiceSoapClient wsClient = new WsTse.CaptchaServiceSoapClient();
                // var respuesta = wsClient.ObtenerLugar1(vModel.transaccion, vModel.codigoCapcha, vModel.codigoSistema);

                wsConsulta.CaptchaService wsClient = new wsConsulta.CaptchaService();

                var respuesta = wsClient.ObtenerLugar1(vModel.transaccion, vModel.codigoCapcha, vModel.codigoSistema);


                LugarDeVotacionModel model = new LugarDeVotacionModel();
                model.nombre = respuesta.NOMBRES_APELLIDOS;
                model.departamento = respuesta.DEPARTAMENTO;
                model.municipio = respuesta.MUNICIPIO;
                model.fechaNacimiento = respuesta.FECHA_DE_NACIMIENTO;
                model.dpi = respuesta.DPI;
                model.direccion = respuesta.DIRECCION;
                model.centro = respuesta.CENTRO;
                model.boleta = respuesta.BOLETA;
                model.linea = respuesta.LINEA;
                model.pagina = respuesta.PAGINA;
                model.numeroMesa = respuesta.MESA_DE_NUMERO;              
                
                res.mensaje = respuesta.USRMENSAJE;
                res.status = respuesta.STATUS;
                res.data = model;
               
                return res;
            }
            catch (Exception ex)
            {
                res.status = "0";
                res.mensaje = ex.Message;
                res.data = null;
                return res;
            }
        }

    }
}
