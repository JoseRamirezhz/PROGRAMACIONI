using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio17
    {
        public void Main()
        {
            int Numero;
            Console.WriteLine("Ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            if (Numero > 0)
            {
                Console.WriteLine("Numero positivo");

            }
            else
            {
                if (Numero == 0)
                {
                    Console.WriteLine("Numero neutral '0'");
                }
                else
                {
                    Console.WriteLine("Numero negativo");
                }
            }
            Console.ReadKey();
        }
    }
}
