using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_7
{
    public class Cap7_Ejercicio2
    {
        public static void Diccionario()
        {
            Hashtable GetHashtable()
            {

                Hashtable hashtable = new Hashtable();
                hashtable.Add("Nombre", "Palabra o conjunto de palabras con las que se  distinguen los seres vivos ");
                hashtable.Add("Lenguaje", "Capacidad propia del ser humano para expresar pensamientos.");
                hashtable.Add("Numero", "Concepto matemático que expresa una cantidad con relación a la unidad de cómputo");
                return hashtable;
            }


            {
                Hashtable hashtable = GetHashtable();


                Console.WriteLine("Ingrese Palabra a buscar ");
                string buscar = Console.ReadLine();


                Console.WriteLine(hashtable.ContainsKey(buscar));

                Console.ReadKey();
            }
        }
    }
}
