using System;
using System.Collections.Generic;
using System.Text;

namespace GestionActivos.AccesoDatos.Interfaces
{
    public interface IUnidadTrabajo
    {
        IActivoRepositorio Activo { get; }
    }
}
