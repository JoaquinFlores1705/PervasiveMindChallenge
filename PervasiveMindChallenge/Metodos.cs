using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Representa las funciones callback que se ejecutan despues de acceder a la memoria
    /// </summary>
    public static class Metodos
    {
        /// <summary>
        /// Representa un callback 1
        /// </summary>
        /// <param name="memoria">Lista de valores leidos de la memoria</param>
        public static void callBack1(List<Memory> memoria)
        {
            foreach (Memory item in memoria)
            {
                Console.WriteLine($"Callback 1: Indice: {item.Indice}, Valor: {item.Valor}");
            }
        }

        /// <summary>
        /// Representa un callback 2
        /// </summary>
        /// <param name="memoria">Lista de valores leidos de la memoria</param>
        public static void callBack2(List<Memory> memoria)
        {
            foreach (Memory item in memoria)
            {
                Console.WriteLine($"Callback 2: Indice: {item.Indice} - Valor: {item.Valor}");
            }
        }

        /// <summary>
        /// Representa un callback 3
        /// </summary>
        /// <param name="memoria">Lista de valores leidos de la memoria</param>
        public static void callBack3(List<Memory> memoria)
        {
            foreach (Memory item in memoria)
            {
                Console.WriteLine($"Callback 3: Indice: {item.Indice} --- Valor: {item.Valor}");
            }
        }
    }
}
