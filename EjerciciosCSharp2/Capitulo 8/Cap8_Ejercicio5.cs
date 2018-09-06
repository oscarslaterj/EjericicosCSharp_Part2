using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_8
{
    public class Cap8_Ejercicio5
    {
        public static void OrdenAlfabetico()
        {

            {
                string[] cadenas = { "casa", "motorizado", "programador", "Aplicada" };

                Console.WriteLine("\t \t Palabras desordenadas:");
                foreach (string s in cadenas)
                    Console.WriteLine(s);

                Console.WriteLine("\n  \t \t Palabras ordenadas:");
                foreach (string s in cadenas)
                    Console.WriteLine(s);

                Console.ReadKey();
            }
        }
    }
}