using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_5
{
    public class Cap5_Ejercicio4
    {
        public static void CalFactorial()
        {
            int num;
            Console.WriteLine("\t \t \t Factorial de un número \n");
        do
            {
                Console.Write("Ingrese un número ");
                num = int.Parse(Console.ReadLine( ));

        } while (num< 0);

                factorial(num);
        Console.ReadKey();
            }


    static void factorial(int n)
    {
        if (n < 0)
        {
            Console.Write("\n Ingrese un numero positivo \n");
        }

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
        Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}
