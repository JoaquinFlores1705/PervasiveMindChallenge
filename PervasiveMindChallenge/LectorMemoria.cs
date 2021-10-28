using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    /// <summary>
    /// Clase que representa el desarrollo realizado para optimizar las lecturas de memoria al metodo IndustrialProtocol
    /// </summary>
    public static class LectorMemoria
    {
        /// <summary>
        /// Funcion implementada para optimizar la lectura a memoria
        /// </summary>
        /// <param name="ListaLectura">Lista de solicitudes a memoria</param>
        public static void LeerMemoria(List<EntidadLector> ListaLectura)
        {

            //Se Ordena la lista por el bloque de inicio en orden ascendente
            ListaLectura = ListaLectura.OrderBy(s => s.InicoBloque).ToList<EntidadLector>();

            //Variables utilizadas para crear la logica de optimizacion de lectura
            int InicioIndice = ListaLectura[0].InicoBloque;
            int CantidadElementos = ListaLectura[0].CantidadBloques + ListaLectura[0].InicoBloque;
            int LecturasRealizadas = 0;
            List<EntidadLector> LecturaAgregacion = new List<EntidadLector>();

            // Se crea la lista de agregacion que invoacara al metodo de lectura IndustrialProtocol.Read
            List<EntidadAgregacion> ListaAgregacion = new List<EntidadAgregacion>();

            // Se leen las solicitudes a memoria en orden de Bloque de Inicio
            foreach (EntidadLector Lectura in ListaLectura)
            {
                // Si el Bloque de inicio es superior al mayor bloque leido + 1 entonces se debe hacer otra peticion para evitar leer bloques no solicitados
                if (Lectura.InicoBloque > CantidadElementos)
                {
                    ListaAgregacion.Add(new EntidadAgregacion() { InicioBloque = InicioIndice, CantidadBloques = CantidadElementos - InicioIndice, ListaItems = LecturaAgregacion });
                    InicioIndice = Lectura.InicoBloque;
                    CantidadElementos = Lectura.CantidadBloques + Lectura.InicoBloque;
                    LecturaAgregacion = new List<EntidadLector>();
                }

                CantidadElementos = Lectura.InicoBloque + Lectura.CantidadBloques > CantidadElementos ? Lectura.InicoBloque + Lectura.CantidadBloques : CantidadElementos;
                // Se agrega esta peticion a la solicitud de agregacion actual
                LecturaAgregacion.Add(Lectura);

            }
            // Se agrega la ultima peticion de agregacion generada
            ListaAgregacion.Add(new EntidadAgregacion() { InicioBloque = InicioIndice, CantidadBloques = CantidadElementos - InicioIndice, ListaItems = LecturaAgregacion });


            // Se procede a enviar las solicitudes de agregacion generadas
            foreach (EntidadAgregacion Agregacion in ListaAgregacion)
            {
                LecturasRealizadas++;
                List<Memory> Memoria =  IndustrialProtocol.Read(Agregacion.InicioBloque, Agregacion.CantidadBloques);
                
                //Se envia el payload al callback de cada peticion
                foreach (EntidadLector lector in Agregacion.ListaItems)
                {
                    Console.WriteLine($"Inicio Lista {lector.InicoBloque} longitud {lector.CantidadBloques}");
                    List<Memory> payload = Memoria.GetRange(Memoria.FindIndex(m => m.Indice == lector.InicoBloque - 1), lector.CantidadBloques);
                    lector.MetodoCallback(payload);

                    Console.WriteLine($"Fin Lista {lector.InicoBloque} longitud {lector.CantidadBloques}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Lecturas de memoria realizadas: {LecturasRealizadas}");
            Console.WriteLine();

        }
    }
}
