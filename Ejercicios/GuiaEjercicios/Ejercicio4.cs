using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio4
    {
        public void Main()
        {
            double V, T, X;

            Console.WriteLine("Ingrese la velocidad del objeto: ");
            V = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo con el que viaja el objeto: ");
            T = double.Parse(Console.ReadLine());

            X = V * T;
            
            Console.WriteLine("La distancia recorrida por el objeto es: "+ X +" m/s");
            Console.ReadKey();
        }
    }
}
