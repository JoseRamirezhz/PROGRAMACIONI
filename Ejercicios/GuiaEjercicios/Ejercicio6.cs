using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio6
    {
        public void Main()
        {
            double num, porc;

            Console.WriteLine("Ingrese un numero para calcular el 20%: ");
            num = double.Parse(Console.ReadLine());

            porc = num * 0.20;

            Console.WriteLine("El 20 % del numero "+ num +" es: "+ porc);
            Console.ReadKey();
        }
    }
}
