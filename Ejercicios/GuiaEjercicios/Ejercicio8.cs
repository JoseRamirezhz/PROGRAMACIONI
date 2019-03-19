using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio8
    {
        public void Main()
        {
            double n1, n2, n3, n4, n5, prom;

            Console.WriteLine("Ingrese Primer numero: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());
            n5 = double.Parse(Console.ReadLine());

            prom = (n1+ n2+ n3+ n4+ n5) /5;

            Console.WriteLine("El promedio de los numero es: "+ prom);
            Console.ReadKey();
        }
        

    }
}
