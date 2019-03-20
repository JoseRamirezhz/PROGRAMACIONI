using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio33
    {
        public void Main()
        {
            Ejercicio33 obj1;
            obj1 = new Ejercicio33();
            obj1.Ejer33();
        }
        public void Ejer33()
        {
            String OPC;
            double dato1, dato2, resp;
            Console.WriteLine("PROGRAMA PARA CALCULAR DISTANCIA, VELOCIDAD O TIEMPO");
            Console.WriteLine("INGRESE OPCION");
            Console.WriteLine("1.- CALCULAR DISTANCIA");
            Console.WriteLine("2.- CALCULAR VELOCIDAD");
            Console.WriteLine("3.- CALCULAR TIEMPO");
            OPC = Console.ReadLine();
            switch (OPC)
            {
                case "1":
                    Console.WriteLine("CALCULANDO DISTANCIA");
                    Console.WriteLine("INGRESE VELOCIDAD EN METROS SOBRE SEGUNDOS");
                    dato1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE TIEMPO EN SEGUNDOS");
                    dato2 = double.Parse(Console.ReadLine());
                    resp = dato1 * dato2;
                    Console.WriteLine("LA DISTANCIA ES: " + resp + " METROS");
                    break;
                case "2":
                    Console.WriteLine("CALCULANDO VELOCIDAD");
                    Console.WriteLine("INGRESE DISTANCIA EN METROS");
                    dato1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE TIEMPO EN SEGUNDOS");
                    dato2 = double.Parse(Console.ReadLine());
                    resp = dato1 / dato2;
                    Console.WriteLine("LA VELOCIDAD ES: " + resp + " METROS SOBRE SEGUNDOS");
                    break;
                case "3":
                    Console.WriteLine("CALCULANDO TIEMPO");
                    Console.WriteLine("INGRESE VELOCIDAD EN METROS SOBRE SEGUNDOS");
                    dato1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE DISTANCIA EN METROS");
                    dato2 = double.Parse(Console.ReadLine());
                    resp = dato2 / dato1;
                    Console.WriteLine("EL TIEMPO     ES: " + resp + " SEGUNDOS");
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA");
                    break;

            }
            Console.ReadKey();
        }
    }
}
