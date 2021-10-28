using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Representa un modelo para realizar las agregaciones y optimizar las lecturas a memoria
    /// </summary>
    public class EntidadAgregacion
    {
        /// <summary>
        /// Bloque de inicio a buscar en memoria
        /// </summary>
        public int InicioBloque { get; set; }

        /// <summary>
        /// Cantidad de bloques a leer
        /// </summary>
        public int CantidadBloques { get; set; }

        /// <summary>
        /// Lista o Tupla de solicitudes de acceso a memoria
        /// </summary>
        public List<EntidadLector> ListaItems { get; set; }
    }
}
