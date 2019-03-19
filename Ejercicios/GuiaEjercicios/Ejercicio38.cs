using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio38
    {
        public void Main()
        {
            Ejercicio38 obj1;
            obj1 = new Ejercicio38();
            obj1.Ejer38();
        }
        public void Ejer38()
        {
            int i, impar;
            Console.WriteLine("Algoritmo que me imprime los numeros Impares");
            Console.WriteLine("Comprendidos entre 201 y 499");
            for (i = 0; i <= 500; i++)
            {
                impar = i % 2;
                if (impar == 1)
                {
                    if (i >= 201 && i <= 499)
                    {
                        Console.WriteLine("Numero " + i);
                    }
                }
            }
            Console.WriteLine("Algoritmo que me imprime los numeros Impares");
            Console.WriteLine("Comprendidos entre 201 y 499");
            Console.ReadKey();
        }
    }
}
