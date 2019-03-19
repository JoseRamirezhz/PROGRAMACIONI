using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio67
    {
        public void Main()
        {

            int[] vector1 = new int[15];
            double[] vector2 = new double[15];
            double[] vector3 = new double[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Dijite un valor para el vetor en la posicion: "+ (i+1));
                vector1[i] = int.Parse(Console.ReadLine());
                vector2[i] = Math.Pow(vector1[i],2);

            }

            for (int i = 0; i<15; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i<15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 2 elevado a la 2( arreglo resultante)");
                }
                Console.WriteLine(vector2[i]);
            }
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 15; i++)
            {
                
                vector3[i] = Math.Pow(vector1[i], 3);

            }
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 3 elevado a la 3( arreglo resultante)");
                }
                Console.WriteLine(vector3[i]);
            }

            Console.ReadKey();

        }
    }
}
