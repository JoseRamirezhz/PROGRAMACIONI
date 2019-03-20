using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio1
    {
        
        public void Main()
        {
            int A, B, resul;


            Console.WriteLine("---------SUMA---------");
            Console.WriteLine("Ingrese un valor para A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para B: ");
            B = int.Parse(Console.ReadLine());

            resul = A + B;

            Console.WriteLine("La suma de los dos numeros es: " + resul);
            Console.WriteLine("USTED A SELECCIONADO EL EJERCICIO NUMERO 1 ");

            Console.ReadKey();
        }
    }
}
