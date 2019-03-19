using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio39
    {
        public void Main()
        {
            int counter1 = 0, counter2 = 0;
            int[] a = new int[21];

            Console.WriteLine("Escribir las edades de 20 alumnos");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Alumno No. " + i);
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] >= 18)
                {
                    counter1 = counter1 + 1;
                }
                else
                {
                    counter2 = counter2 + 1;
                }
            }
            Console.WriteLine("El total de alumnos mayores de edad es:" + counter1);
            Console.WriteLine("El total de alumnos menores es:" + counter2);
            Console.ReadKey();
        }

    }
}
