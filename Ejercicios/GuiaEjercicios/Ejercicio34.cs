using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio34
    {
        public void Main()
        {
            Ejercicio34 obj1;
            obj1 = new Ejercicio34();
            obj1.Ejer34();
        }
        public void Ejer34()
        {
            int numero, OPC, numeroR;
            Console.WriteLine("PROGRAMA PARA CARACTERISTICAS DE UN NUMERO");
            Console.WriteLine("INGRESE NUMERO");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSELECCIONE LO QUE DESEA HACER");
            Console.WriteLine("1.- DETERMINAR SI ES POSITIVO O NEGATIVO");
            Console.WriteLine("2.- DETERMINAR SI ES PAR O IMPAR");
            OPC = int.Parse(Console.ReadLine());
            switch (OPC)
            {
                case 1:
                    Console.WriteLine("CALCULANDO SI EL NUMERO INGRESADO ES POSITIVO O NEGATIVO");

                    if (numero >= 0)
                    {
                        Console.WriteLine("El Numero " + numero + " Es POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("El Numero " + numero + " Es NEGATIVO");
                    }
                    break;
                case 2:
                    Console.WriteLine("CALCULANDO SI EL NUMERO INGRESADO ES PAR O IMPAR");
                    numeroR = numero % 2;
                    if (numeroR == 0)
                    {
                        Console.WriteLine("El Numero " + numero + " Es PAR");
                    }
                    else
                    {
                        Console.WriteLine("El Numero " + numero + " Es IMPAR");
                    }
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA");
                    break;

            }
            Console.ReadKey();
        }
    }
}
