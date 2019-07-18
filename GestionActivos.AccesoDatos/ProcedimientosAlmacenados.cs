using System;
using System.Collections.Generic;
using System.Text;

namespace GestionActivos.AccesoDatos
{
    /// <summary>
    /// Contiene los nombres de los procedimientos almacenados utilizados en el sistema
    /// </summary>
    public static class ProcedimientosAlmacenados
    {
        /// <summary>
        /// Nombres de procedimientos almacenados para el módulo de activos
        /// </summary>
        public struct Activo
        {
            public const string ObtenerActivoPorCodigo = "pr_GetAssetByCode";
        }
    }
}
