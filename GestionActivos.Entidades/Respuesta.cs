using System;
using System.Collections.Generic;
using System.Text;

namespace GestionActivos.Entidades
{
    public class Respuesta<T> where T : class
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Respuesta()
        {
            //inicializamos las propiedades
            Codigo = 0;
            Mensaje = "";
        }

        /// <summary>
        /// Código de error, si es 0 la respuesta es correcta
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Mensaje de error
        /// </summary>
        public string Mensaje { get; set; }

        /// <summary>
        /// Se devuelve el objeto a responder
        /// </summary>
        public T ObjetoRespuesta { get; set; }
    }
}
