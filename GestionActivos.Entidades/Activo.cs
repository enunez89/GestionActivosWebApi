using System;
using System.Collections.Generic;
using System.Text;

namespace GestionActivos.Entidades
{
    public class Activo
    {
        public long IdActivo { get; set; }

        public string Codigo { get; set; }

        public int CodCategoria { get; set; }

        public string Marca { get; set; }

        public decimal PrecioAdquisicion { get; set; }

        public int IdProveedor { get; set; }

        public int CodEstado { get; set; }

        public string NumeroSerie { get; set; }

        public string NumeroPlaca { get; set; }

        public string DesActivo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaAdqusicion { get; set; }

        public long IdArchivoAdjunto { get; set; }
    }
}
