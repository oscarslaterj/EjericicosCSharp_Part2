using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_8
{
    public class Cap8_Ejercicio3
    {
        public static void FormatoHora()
        {
            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));


            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.ReadKey();
        }
    }
}

