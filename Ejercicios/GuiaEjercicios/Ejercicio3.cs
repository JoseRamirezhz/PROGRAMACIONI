using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio3
    {
        public void Main()
        {
            double A, B, resul;

            Console.WriteLine("-----DIVISION------");

            Console.WriteLine("Ingrese un valor para A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para B: ");
            B = double.Parse(Console.ReadLine());

            resul = A / B;

            Console.WriteLine("La division de los dos numeros es: " + resul);
            Console.WriteLine("USTED A SELECCIONADO EL EJERCICIO NUMERO 3 ");

            Console.ReadKey();
        }
    }
}
