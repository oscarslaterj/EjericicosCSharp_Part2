using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_7
{
    public class Cap7_Ejercicio1
    {
        public static void CalPromedio()
        {

            int num;
            Console.WriteLine("Ingrese Numero de Calificaciones a calcular ");
            num = int.Parse(Console.ReadLine());
            int s = 0;
            int[] cali = new int[num];


            for (int i = 0; i < cali.Length; i++)
            {
                Console.WriteLine("Ingrese Calificacion de estudiante ");
                cali[i] = int.Parse(Console.ReadLine());

            }

            for (int id = 0; id < cali.Length; id++)
            {
                Console.WriteLine("/n Calificacion {0}: {1}", id, cali[id]);
                s += cali[id];
            }

            Console.WriteLine("Su suma es " + s);
            Console.WriteLine("Promedio de calificacion es " + s / cali.Length);

            Array.Sort(cali);
            Console.WriteLine("Calificacion minima es: " + cali[0]);
            Array.Reverse(cali);
            Console.WriteLine("Calificacion maxima es: " + cali[0]);

            Console.ReadKey();

        }
    }
}
