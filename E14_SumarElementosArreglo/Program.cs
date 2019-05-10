using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E14_SumarElementosArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int[] arreglo = null;
            string opcion;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                arreglo = obtenerVectorConNumerosAleatorios(1, 50, 10);
                if (arreglo != null)
                {
                    Console.WriteLine("Los elementos son:");
                    foreach (var v in arreglo)
                        Console.Write("[{0}] ", v);
                    Console.WriteLine("\nLa suma es: {0}\n\ningrese \"n\" para nuevo arreglo", sumarElementos(arreglo));
                }
                else
                    Console.WriteLine("Error, arreglo nulo");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);                
            } while (!salir);
        }

        public static int sumarElementos(int[] arreglo)
        {
            if (arreglo.Length > 0)
            {
                int suma = 0;
                foreach (var v in arreglo)               
                    suma += v;                
                return suma;
            }            
            return 0;
        }

        public static int[] obtenerVectorConNumerosAleatorios(int min, int max, int size)
        {
            Random random = new Random();
            int[] resultado = null;
            if (size > 0 && min < max)
            {
                resultado = new int[size];
                for (int i = 0; i < resultado.Length; i++)
                    resultado[i] = random.Next(min, max);
            }

            return resultado;
        }
    }
}
