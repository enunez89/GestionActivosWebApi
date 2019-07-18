using System;
using System.Collections.Generic;
using System.Text;
using GestionActivos.Entidades;

namespace GestionActivos.LogicaNegocio
{
    public interface IActivoLogicaNegocio
    {
        /// <summary>
        /// Obtiene un activo por su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Respuesta<Activo> ObtenerPorCodigo(string codigo);
    }
}
