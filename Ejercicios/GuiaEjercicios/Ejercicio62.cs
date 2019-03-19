using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio62
    {
        public void Main()
        {
            int[] numero = new int[20];

            int neg = 0, pos = 0, cero = 0;

            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("Ingrese los numeros  : ");
                numero[i] = int.Parse(Console.ReadLine());

                if (numero[i] < 0)
                {
                    neg++;
                }

                if (numero[i] > 0)
                {
                    pos++;
                }
                if (numero[i] == 0)
                {
                    cero++;
                }
            }

            Console.WriteLine("Los numero negativos son: " + neg);
            Console.WriteLine("Los numero positivos son: " + pos);
            Console.WriteLine("Los numeros ceros son: " + cero);
            Console.ReadKey();
        }

    }

    
}
    

