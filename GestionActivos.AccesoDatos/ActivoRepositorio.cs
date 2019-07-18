using System.Data;
using System.Collections.Generic;
using System.Text;
using Dapper;
using GestionActivos.AccesoDatos.Interfaces;
using GestionActivos.Entidades;
using MySql.Data.MySqlClient;
using System.Linq;

namespace GestionActivos.AccesoDatos
{
    public class ActivoRepositorio : Repositorio<Activo>, IActivoRepositorio
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionString"></param>
        public ActivoRepositorio(string connectionString): base(connectionString)
        {

        }

        /// <summary>
        /// Obtiene la información del activo por su código.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Activo ObtenerPorCodigo(string codigo)
        {
            IEnumerable<Activo> lista;
            //creamos los parametros del procedimiento almacenado
            var parametros = new DynamicParameters();
            parametros.Add("code", codigo);

            //ejecutamos el procedimiento almacenado
            using(var conexion = new MySqlConnection(_connectionString))
            {
                lista = conexion.Query<Activo>(ProcedimientosAlmacenados.Activo.ObtenerActivoPorCodigo, parametros, commandType: CommandType.StoredProcedure);
            }

            //retornamos el activo consultado
            return lista?.FirstOrDefault();
        }
    }
}
