﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio46
    {
        public void Main()
        {
            double promedio;
            double counter1 = 0;
            double[] a = new double[26];

            Console.WriteLine("Calcular promedio de 15 notas del alumno");
            Console.WriteLine("Ingrese las 15 notas: ");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Nota No. " + i + " de 15");
                a[i] = double.Parse(Console.ReadLine());
                counter1 = counter1 + a[i];
            }

            promedio = counter1 / 15;

            if (promedio >= 4.0)
            {
                Console.WriteLine("habeis pasado la materia tio, prom: " + promedio);
            }
            if (promedio < 4)
            {
                Console.WriteLine("Dejaste la materia tio, prom: " + promedio);
            }
            Console.ReadKey();
        }
    }
}
