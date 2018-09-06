﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp2.Capitulo_6
{
   public class Cap6_Ejercicio2
    {
        public void NotaMasBaja()
        {
            int cantEstudiantes = 0, cantSalones = 0, i = 0, j = 0;
            float minima = 100.0f;
            string entrada;

            Console.Write("\nDigite la cantidad de salones: ");
            entrada = Console.ReadLine();
            cantSalones = Convert.ToInt32(entrada);

            float[][] calif = new float[cantSalones][];

            for (i = 0; i < cantSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                entrada = Console.ReadLine();
                cantEstudiantes = Convert.ToInt32(entrada);

                calif[i] = new float[cantEstudiantes];
            }

            for (i = 0; i < cantSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    entrada = Console.ReadLine();
                    calif[i][j] = Convert.ToSingle(entrada);
                }

            }

            for (i = 0; i < cantSalones; i++)
            {
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    if (calif[i][j] < minima)
                    {
                        minima = calif[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas baja es: {0}\n", minima);
        }
    }
}
