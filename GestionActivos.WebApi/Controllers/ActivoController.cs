using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionActivos.LogicaNegocio;
using GestionActivos.Entidades;

namespace GestionActivos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivoController : ControllerBase
    {
        private readonly IActivoLogicaNegocio activoLN;

        public ActivoController(IActivoLogicaNegocio activoLogicaNegocio)
        {
            activoLN = activoLogicaNegocio;
        }

        /// <summary>
        /// Obtiene un activo por su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet(Name = "ObtenerPorCodigo")]
        public IActionResult ObtenerPorCodigo(string codigo)
        {
            var respuesta = activoLN.ObtenerPorCodigo(codigo);
            return Ok(respuesta);
        }
    }
}
