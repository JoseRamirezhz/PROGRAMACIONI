using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio21
    {
        public void Main()
        {
            int Num1, Num2;
            Console.WriteLine("Ingrese un primer valor: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero: ");
            Num2 = int.Parse(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.WriteLine("La resta de lo 2 numero es: " + (Num1 - Num2));
            }
            else
            {
                Console.WriteLine("La suma de los numeros es de: " + (Num1 + Num2));

            }
            Console.ReadKey();
        }
    }
}
