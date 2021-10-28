using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Representa un modelo para solicitar informacion de memoria
    /// </summary>
    public class EntidadLector
    {
        /// <summary>
        /// Delegado para invocar funcion
        /// </summary>
        /// <param name="memoria">Lista de bloques enviados a la funcion</param>
        public delegate void CallBack(List<Memory> memoria);

        /// <summary>
        /// Bloque de inicio a buscar en memoria
        /// </summary>
        public int InicoBloque { get; set; }
        /// <summary>
        /// Cantidad de bloques a leer
        /// </summary>
        public int CantidadBloques { get; set; }

        /// <summary>
        /// Metodo que sera ejecutado
        /// </summary>
        public CallBack MetodoCallback { get; set; }
    }
}
