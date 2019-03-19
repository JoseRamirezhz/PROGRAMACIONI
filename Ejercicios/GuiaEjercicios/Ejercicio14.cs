using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio14
    {
        public void Main()
        {
            int i, Numero, Suma;
            Suma = 0;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite el valor: " + i);
                Numero = int.Parse(Console.ReadLine());
                Suma = Suma + Numero;

            }
            Console.WriteLine("La suma de los valores es de: " + Suma);
            Console.WriteLine("El promedio de estos cuatro valores es de:  " + Suma / 4);
            Console.ReadKey();
        }
    }
}
