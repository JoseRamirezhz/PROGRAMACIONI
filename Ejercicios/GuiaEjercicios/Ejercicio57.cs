using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio57
    {
        public void Main()
        {
            int i = 1, n, r, p, fac = 1;

            do
            {
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1-Calcular el factorial de un número.");
                Console.WriteLine("2-Calcular la potencia de un número.");
                Console.WriteLine("3-Salir.");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ingrese un número: ");
                        r = int.Parse(Console.ReadLine());
                        for (int a = 1; a <= r; a++)
                        {
                            fac = fac * a;
                        }

                        Console.WriteLine("El factorial de " + r + " es:" + fac);
                        fac = 1;
                        break;

                    case 2:
                        Console.WriteLine("Ingrese un número: ");
                        r = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la potencia");
                        p = int.Parse(Console.ReadLine());

                        Console.WriteLine("El resultadi es: " + Math.Pow(r, p));
                        break;
                    case 3:
                        i = 4;
                        Console.WriteLine("*GRACIAS*");
                        Console.ReadKey();
                        break;


                }
            }
            while (i <= 3);
        }
    }
}
