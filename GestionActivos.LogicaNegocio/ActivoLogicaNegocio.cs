using System;
using System.Collections.Generic;
using System.Text;
using GestionActivos.Entidades;
using GestionActivos.AccesoDatos.Interfaces;

namespace GestionActivos.LogicaNegocio
{
    public class ActivoLogicaNegocio : IActivoLogicaNegocio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unidadTrabajo"></param>
        public ActivoLogicaNegocio(IUnidadTrabajo unidadTrabajo) => _unidadTrabajo = unidadTrabajo;

        /// <summary>
        /// Obtiene un activo por su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Respuesta<Activo> ObtenerPorCodigo(string codigo)
        {
            Activo respDatos;
            Respuesta<Activo> respuesta = new Respuesta<Activo>();
            try
            {
                //realizamos la consulta
                respDatos = _unidadTrabajo.Activo.ObtenerPorCodigo(codigo);
                //respuesta correcta
                respuesta.ObjetoRespuesta = respDatos;
            }
            catch (Exception ex)
            {
                //ocurrió un error
                respuesta.Codigo = 99;
                respuesta.Mensaje = $"{ex.Message} Inner Msj: {ex.InnerException?.Message}";
            }
            return respuesta;
        }
    }
}
