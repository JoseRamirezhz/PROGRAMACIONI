using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio58
    {
        public void Menu()
        {
            int i = 1, n, d = 1, resp;

            do
            {
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1-Números pares hasta el 100");
                Console.WriteLine("2-Múltiplos de 4.");
                Console.WriteLine("3-Tablas de Múltiplicar de un número hasta 10.");
                Console.WriteLine("4-Salir");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("***Los némeros pares son: ");
                        for (int a = 1; a <= 100; a++)
                        {

                            if (a % 2 == 0)
                            {
                                Console.WriteLine(a);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("***Los números múltiplos de 4 son: ");
                        while (d <= 100)
                        {

                            if (d % 4 == 0)
                            {
                                Console.WriteLine(d);
                            }

                            d = d + 1;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite un número: ");
                        resp = int.Parse(Console.ReadLine());

                        for (int t = 1; t <= 10; t++)
                        {
                            d = resp * t;
                            Console.WriteLine(d);
                        }

                        break;

                    case 4:
                        i = 5;
                        Console.WriteLine("**GRACIAS**");
                        Console.ReadKey();
                        break;

                }
            }
            while (i <= 4);
        }
    }
}
