using System.Collections.Generic;
using GestionActivos.AccesoDatos.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper.Contrib.Extensions;

namespace GestionActivos.AccesoDatos
{
    public class Repositorio<T> : IRepositorio<T> where T: class
    {
        protected string _connectionString;

        public Repositorio(string connectionString)
        {            
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
            _connectionString = connectionString;
        }

        public bool Delete(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        public T GetById(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}
