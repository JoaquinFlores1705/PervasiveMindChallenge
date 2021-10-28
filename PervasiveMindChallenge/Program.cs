using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervasiveMindChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<EntidadLector> Prueba1 = new List<EntidadLector>();
            Prueba1.Add(new EntidadLector() { InicoBloque = 3, CantidadBloques = 5, MetodoCallback = Metodos.callBack1 });
            Prueba1.Add(new EntidadLector() { InicoBloque = 5, CantidadBloques = 7, MetodoCallback = Metodos.callBack2 });

            
            List<EntidadLector> Prueba2 = new List<EntidadLector>();
            Prueba2.Add(new EntidadLector() { InicoBloque = 2, CantidadBloques = 9, MetodoCallback = Metodos.callBack1 });
            Prueba2.Add(new EntidadLector() { InicoBloque = 4, CantidadBloques = 2, MetodoCallback = Metodos.callBack2 });
            Prueba2.Add(new EntidadLector() { InicoBloque = 1, CantidadBloques = 4, MetodoCallback = Metodos.callBack3 });
            Prueba2.Add(new EntidadLector() { InicoBloque = 5, CantidadBloques = 1, MetodoCallback = Metodos.callBack3 });

            
            List<EntidadLector> Prueba3 = new List<EntidadLector>();
            Prueba3.Add(new EntidadLector() { InicoBloque = 1, CantidadBloques = 7, MetodoCallback = Metodos.callBack3 });
            Prueba3.Add(new EntidadLector() { InicoBloque = 7, CantidadBloques = 3, MetodoCallback = Metodos.callBack3 });
            Prueba3.Add(new EntidadLector() { InicoBloque = 4, CantidadBloques = 11, MetodoCallback = Metodos.callBack3 });
            Prueba3.Add(new EntidadLector() { InicoBloque = 15, CantidadBloques = 5, MetodoCallback = Metodos.callBack3 });

            List<EntidadLector> Prueba4 = new List<EntidadLector>();
            Prueba4.Add(new EntidadLector() { InicoBloque = 17, CantidadBloques = 6, MetodoCallback = Metodos.callBack3 });
            Prueba4.Add(new EntidadLector() { InicoBloque = 23, CantidadBloques = 2, MetodoCallback = Metodos.callBack3 });
            Prueba4.Add(new EntidadLector() { InicoBloque = 26, CantidadBloques = 9, MetodoCallback = Metodos.callBack3 });
            Prueba4.Add(new EntidadLector() { InicoBloque = 35, CantidadBloques = 7, MetodoCallback = Metodos.callBack3 });
            Prueba4.Add(new EntidadLector() { InicoBloque = 43, CantidadBloques = 1, MetodoCallback = Metodos.callBack3 });
            Prueba4.Add(new EntidadLector() { InicoBloque = 156, CantidadBloques = 1, MetodoCallback = Metodos.callBack3 });


            List<EntidadLector> Prueba5 = new List<EntidadLector>();
            Prueba5.Add(new EntidadLector() { InicoBloque = 300, CantidadBloques = 3, MetodoCallback = Metodos.callBack3 });
            Prueba5.Add(new EntidadLector() { InicoBloque = 256, CantidadBloques = 16, MetodoCallback = Metodos.callBack3 });
            Prueba5.Add(new EntidadLector() { InicoBloque = 463, CantidadBloques = 4, MetodoCallback = Metodos.callBack3 });
            Prueba5.Add(new EntidadLector() { InicoBloque = 272, CantidadBloques = 64, MetodoCallback = Metodos.callBack3 });
            Prueba5.Add(new EntidadLector() { InicoBloque = 460, CantidadBloques = 2, MetodoCallback = Metodos.callBack3 });
            Prueba5.Add(new EntidadLector() { InicoBloque = 336, CantidadBloques = 128, MetodoCallback = Metodos.callBack3 });
            


            try
            {
                Console.WriteLine($"--------Prueba 1--------------");
                LectorMemoria.LeerMemoria(Prueba1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

            try
            {
                Console.WriteLine($"--------Prueba 2--------------");
                LectorMemoria.LeerMemoria(Prueba2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

            try
            {
                Console.WriteLine($"--------Prueba 3--------------");
                LectorMemoria.LeerMemoria(Prueba3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

            try
            {
                Console.WriteLine($"--------Prueba 4--------------");
                LectorMemoria.LeerMemoria(Prueba4);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

            try
            {
                Console.WriteLine($"--------Prueba 5--------------");
                LectorMemoria.LeerMemoria(Prueba5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }


            Console.ReadKey();

        }
    }
}
