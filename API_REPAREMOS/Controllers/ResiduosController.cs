using API_REPAREMOS.Common.Interface;
using API_REPAREMOS.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REPAREMOS.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ResiduosController : ControllerBase
    {
        private readonly ManejoResiduosServicesInt _serviceAPI;


        public ResiduosController(ManejoResiduosServicesInt servicioAPI)
        {
            _serviceAPI = servicioAPI;
        }

        //[EnableCors("MyPolicy")]
        //[Route("~/ObtenerValorTotalProductoInventario")]
        [HttpGet("ObtenerResiduos")]
        public async Task<IActionResult> ObtenerResiduos()
        {
            try
            {
                //var servicioApi = new ServiceAPI();
                //var result = await servicioApi.ObtenerResiduos();

                var result = await _serviceAPI.ObtenerResiduos();

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(
                        new DataErrorDto
                        {
                            Error = "Error mensaje",
                            Valor = "3",
                            FechaHora = DateTime.Now
                        }
                        );
                }
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
                //return (ex.ToString());

            }
        }


        [HttpGet("jsonsalida")]
        public async Task<IActionResult> Jsonsalida()
        {
            try
            {
                //var servicioApi = new ServiceAPI();
                //var result = await servicioApi.ObtenerResiduos();

                var result = await _serviceAPI.jsonsalida();

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(
                        new DataErrorDto
                        {
                            Error = "Error mensaje",
                            Valor = "3",
                            FechaHora = DateTime.Now
                        }
                        );
                }
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
                //return (ex.ToString());

            }
        }



        [HttpGet("ObtenerResiduosXCiudad/{ciudad}")]
        public async Task<IActionResult> ObtenerResiduosXCiudad(string ciudad)
        {
            try
            {

                var result = await _serviceAPI.ObtenerResiduosXCiudad(ciudad);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(
                        new DataErrorDto
                        {
                            Error = "Error mensaje",
                            Valor = "3",
                            FechaHora = DateTime.Now
                        }
                        );
                }
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
                //return (ex.ToString());

            }
        }


    }
}
