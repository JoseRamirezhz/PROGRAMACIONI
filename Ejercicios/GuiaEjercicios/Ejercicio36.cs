using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio36
    {
        public void Main()
        {
            Ejercicio36 obj1;
            obj1 = new Ejercicio36();
            obj1.Ejer36();
        }
        public void Ejer36()
        {
            int i;
            Console.WriteLine("algoritmo que me imprime los numeros naturales");
            Console.WriteLine("Comprendidos entre 0 y 1000");
            for (i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Numero " + i);

            }
            Console.WriteLine("algoritmo que me imprimio los numeros naturales");
            Console.WriteLine("Comprendidos entre 0 y 1000");
            Console.ReadKey();
        }
    }
}
