using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Representa la memoria interna del dispositivo
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Representa el número del bloque en memoria
        /// </summary>
        public int Indice { get; set; }
        /// <summary>
        /// Representa el valor del bloque de memoria
        /// </summary>
        public string Valor { get; set; }
    }
}
