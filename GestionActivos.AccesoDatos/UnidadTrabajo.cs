using System;
using System.Collections.Generic;
using System.Text;
using GestionActivos.AccesoDatos.Interfaces;

namespace GestionActivos.AccesoDatos
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        public UnidadTrabajo(string connectionString)
        {
            Activo = new ActivoRepositorio(connectionString);
        }

        public IActivoRepositorio Activo { get; private set; }
    }
}
