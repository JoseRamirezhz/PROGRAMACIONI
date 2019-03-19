using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio7
    {
        public void Main()
        {
            double num, Porc30, Porc60, Porc90;
            Console.WriteLine("Ingres un numero para calcular el porcentaje: ");
            num = double.Parse(Console.ReadLine());

            Porc30 = num * 0.30;
            Porc60 = num * 0.60;
            Porc90 = num * 0.90;

            Console.WriteLine("El 30% del numero "+num+" es: "+ Porc30);
            Console.WriteLine("El 60% del numero " + num + " es: " + Porc60);
            Console.WriteLine("El 90% del numero " + num + " es: " + Porc90);
            Console.ReadKey();
        }
    }
}
