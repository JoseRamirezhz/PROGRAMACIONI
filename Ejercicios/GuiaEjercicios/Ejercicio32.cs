using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio32
    {
        public void Main()
        {
            Ejercicio32 obj1;
            obj1 = new Ejercicio32();
            obj1.Ejer32();
        }
        public void Ejer32()
        {
            String letra;
            Console.WriteLine("PROGRAMA QUE PERMITE IDENTIFICAR SI UNA LETRA ES VOCAL O CONSONANTE");
            Console.WriteLine("INGRESE LETRA");
            letra = Console.ReadLine();
            switch (letra)
            {
                case "a":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "e":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "i":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "o":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "u":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "A":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "E":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "I":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "O":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                case "U":
                    Console.WriteLine("INGRESO UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("INGRESO UNA CONSONANTE");
                    break;

            }
            Console.ReadKey();
        }
    }
}
