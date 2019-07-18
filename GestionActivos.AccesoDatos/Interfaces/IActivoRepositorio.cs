using System;
using System.Collections.Generic;
using System.Text;
using GestionActivos.Entidades;

namespace GestionActivos.AccesoDatos.Interfaces
{
    public interface IActivoRepositorio : IRepositorio<Activo>
    {
        /// <summary>
        /// Obtiene la información de un activo su código.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Activo ObtenerPorCodigo(string codigo);
    }
}
