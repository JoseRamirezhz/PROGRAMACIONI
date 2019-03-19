using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio20
    {
        public void Main()
        {
            int Numero;
            double Div;
            Console.WriteLine("digite un numero: ");
            Numero = int.Parse(Console.ReadLine());
            Div = Numero / 2;
            if (Div > 100)
            {
                Console.WriteLine("La mitad de el numero ingresado es mayor a 100");
            }
            else
            {
                if (Div == 100)
                {
                    Console.WriteLine("La mitad de el numero ingresado es igual a 100");
                }
                else
                {
                    Console.WriteLine(" La mitad de el numero ingresado es menor a 100");
                }
            }
            Console.ReadKey();
        }
    }
}
