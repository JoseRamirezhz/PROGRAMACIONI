using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio56
    {
        public void Main()
        {
            int opcion = 0;
            int suma, resta, multi, divi, num1 = 0, num2 = 0;
            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("\n" + "\n 1.-ingresar 2 numeros" + "\n2.-realizar la suma" + "\n3.-realizar la resta" + "\n4.-realizar la multiplicacion" + "\n5.-realizar la division" + "\n6.-salir");
                Console.WriteLine("digite una seleccion :");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("ingrese 2 numeros");
                        Console.WriteLine("ingrese numeros 1");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese numeros 2");
                        num2 = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("hacer la suma:");
                        suma = num1 + num2;
                        Console.WriteLine("la suma es: " + suma);
                        break;
                    case 3:
                        Console.WriteLine("hacer la resta:");
                        resta = num1 - num2;
                        Console.WriteLine("la resta es: " + resta);
                        break;
                    case 4:
                        Console.WriteLine("hacer la resta:");
                        multi = num1 * num2;
                        Console.WriteLine("la multiplicacion es: " + multi);
                        break;
                    case 5:
                        Console.WriteLine("hacer la resta:");
                        divi = num1 / num2;
                        Console.WriteLine("la division es: " + divi);
                        break;
                    case 6:
                        Console.WriteLine("adios...");
                        break;


                }
            } while (opcion != 6);
            Console.ReadKey();
        }
    }
}

