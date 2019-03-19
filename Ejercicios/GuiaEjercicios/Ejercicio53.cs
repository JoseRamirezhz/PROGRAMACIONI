using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio53
    {
        public void Main()
        {
            int numero, factorial = 1;
            Console.WriteLine("ingrese numero a calcular el factorial");
            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                factorial = factorial * numero;
                numero = numero - 1;

            }
            Console.WriteLine("el factorial del numero leido es: " + factorial);
            Console.ReadKey();
        }
    }
}
