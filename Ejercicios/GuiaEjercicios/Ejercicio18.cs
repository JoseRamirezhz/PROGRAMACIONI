using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio18
    {
        public void Main()
        {
            int a, b;

            Console.WriteLine("Digite un numero para A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero B: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            }
            else
            {
                if (b > a)
                {
                    Console.WriteLine("B es mayor que A ");
                }
                else
                {

                    Console.WriteLine("A y B son iguales");

                }

            }
            Console.ReadKey();
        }
    }
}
