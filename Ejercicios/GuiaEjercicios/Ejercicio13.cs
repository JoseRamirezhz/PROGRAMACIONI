using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio13
    {
        public void Main()
        {
            int Num1, Num2, Num3, Num4, Num5, Suma, Mult;
            Console.WriteLine("Digita un numero: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita un segundo numero: ");
            Num2 = int.Parse(Console.ReadLine());
            Suma = Num1 + Num2;
            Console.WriteLine("La suma de los 2 primeros numeros es:  " + Suma);
            Console.WriteLine("Digite un tercer numero:  ");
            Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un cuarto numero:  ");
            Num4 = int.Parse(Console.ReadLine());
            Mult = Num3 * Num4;
            Console.WriteLine("La multiplicacion de el tercer y el cuarto numero es de: " + Mult);
            Console.WriteLine("Digite un quinto numero: ");
            Num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("La multiplicion de los 2 primeros resultados es: " + Suma * Mult);
            Console.WriteLine("La division de el resultado anterior con el quinto numero escrito es: " + (Suma * Mult) / Num5);
            Console.ReadKey();
        }
    }
}
