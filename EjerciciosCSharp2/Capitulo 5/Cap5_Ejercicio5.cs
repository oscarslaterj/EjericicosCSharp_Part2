using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_5
{
   public class Cap5_Ejercicio5
    {
        public static void NumPalabras()
        {
            int caso = 1;

            Console.WriteLine("\t Numeros .");
            Console.WriteLine("Ingrese Numero para verlo en palabra.");
            caso = Int32.Parse(Console.ReadLine());

            switch (caso)
            {
                case 1:


                    Console.WriteLine("Uno");


                    break;

                case 2:


                    Console.Write("Dos");


                    break;
                case 3:


                    Console.Write("Tres");


                    break;
                case 4:


                    Console.Write("Cuatro");


                    break;
                case 5:


                    Console.Write("Cinco");


                    break;

                case 6:


                    Console.Write("Seis");


                    break;
                case 7:


                    Console.Write("Siete");


                    break;
                case 8:


                    Console.Write("Ocho");


                    break;
                case 9:


                    Console.Write("Nueve");


                    break;

                default:
                    Console.WriteLine("Numero Fuera de rango intente de nuevo");
                    break;
            }


            Console.ReadKey();
        }
    }
}
