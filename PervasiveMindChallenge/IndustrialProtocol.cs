using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Clase que representa la funcion ya implementada para acceder a la memoria del dispositivo
    /// </summary>
    public static class IndustrialProtocol
    {
        /// <summary>
        /// Metodo que representa a la lectura de memoria ya implementada
        /// </summary>
        /// <param name="start">Bloque de inicio en memoria</param>
        /// <param name="length">cantidad de bloques a leer</param>
        /// <returns>Lista de bloques leidos</returns>
        public static List<Memory> Read(int start, int length)
        {
            if (start + length > 4096 || start + length < 1)
                throw new Exception("Acceso a memoria no permitido");


            List<Memory> Memoria = new List<Memory>();

            for (int i = start - 1; i < length + start - 1; i++)
            {
                Memoria.Add(new Memory() { Indice = i, Valor = $"Espacio de Memoria {i}" });
            }
            return Memoria;
        }
    }
}
