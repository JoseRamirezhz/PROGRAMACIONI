using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio35
    {
        public void Main()
        {
            Ejercicio35 obj1;
            obj1 = new Ejercicio35();
            obj1.Ejer35();
        }
        public void Ejer35()
        {
            int OPC;
            Console.WriteLine("PROGRAMA PARA DATOS DE ALUMNO");
            Console.WriteLine("\nSELECCIONE LO QUE DESEA HACER");
            Console.WriteLine("1.- VERIFICAR SI PASA O NO LA MATERIA");
            Console.WriteLine("2.- ES MAYOR O MENOR DE EDAD");
            OPC = int.Parse(Console.ReadLine());
            switch (OPC)
            {
                case 1:
                    double dato1, dato2, dato3;
                    double resul1;
                    Console.WriteLine("Ingrese tres Notas");
                    Console.WriteLine("Ingrese Nota 1");
                    dato1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nota 2");
                    dato2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Nota 3");
                    dato3 = double.Parse(Console.ReadLine());
                    resul1 = ((dato1 + dato2 + dato3) / 3);
                    if (resul1 >= 3.0)
                    {
                        Console.WriteLine("\n********EL ALUMNO PASA***********");
                    }
                    else
                    {
                        Console.WriteLine("\n********EL ALUMNO REPRUEBA*********");
                    }
                    break;
                case 2:
                    int edad, añon, añoa;
                    Console.WriteLine("CALCULANDO SI MAYOR O MENOR DE EDAD");
                    Console.WriteLine("INGRESE AÑO DE NACIMIENTO");
                    añon = int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE AÑO ACTUAL");
                    añoa = int.Parse(Console.ReadLine());
                    edad = añoa - añon;
                    if (edad >= 18)
                    {
                        Console.WriteLine("El Alumno tiene " + edad + " años y es MAYOR de Edad");
                    }
                    else
                    {
                        Console.WriteLine("El Alumno tiene " + edad + " años y es MENOR de Edad");
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
