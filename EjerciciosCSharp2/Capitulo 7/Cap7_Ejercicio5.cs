using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_7
{
    public class Cap7_Ejercicio5
    {
        public static void AgendaTelef()
        {
            Queue agenda = new Queue();
            string tlf;
            string nombre;
            int lista = 1;
            while (lista == 1)
            {

                Console.WriteLine("Ingrese nombre de persona que desea agregar a contactos ");
                nombre = Console.ReadLine();
                agenda.Enqueue(nombre);
                Console.WriteLine("ingrese Telefono ");
                tlf = Console.ReadLine();
                agenda.Enqueue(tlf);

                Console.WriteLine("Coloque 0 si no ingresaran mas personas de lo contrario ingrese 1 ");
                lista = int.Parse(Console.ReadLine());


            }
            while (agenda.Count > 0)

                Console.WriteLine("Persona: {0} :: Numero {1}", agenda.Dequeue(), agenda.Dequeue());

            Console.ReadKey();
        }
    }
}
