using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio9
    {
        public void Main()
        {
            int i, Numero, Num;
            Num = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Escriba un numero: ");
                Numero = int.Parse(Console.ReadLine());

                Num = Num + Numero;
            }
            Console.WriteLine("El promedio de los 5 numero digitados es: " + Num / 5);
            Console.ReadKey();
        }
    }
}
