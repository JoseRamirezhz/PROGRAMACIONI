using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio37
    {
        public void Main()
        {
            Ejercicio37 obj1;
            obj1 = new Ejercicio37();
            obj1.Ejer37();
        }
        public void Ejer37()
        {
            int i, pard;
            Console.WriteLine("Algoritmo que me imprime los numeros Pares");
            Console.WriteLine("Comprendidos entre 0 y 200");
            for (i = 0; i <= 200; i++)
            {
                pard = i % 2;
                if (pard == 0)
                {
                    Console.WriteLine("Numero " + i);
                }
            }
            Console.WriteLine("Algoritmo que me imprimio los numeros Pares");
            Console.WriteLine("Comprendidos entre 0 y 200");
            Console.ReadKey();
        }
    }
}
