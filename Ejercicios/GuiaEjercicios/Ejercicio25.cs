using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio25
    {
        public void Main()
        {
            Ejercicio25 obj1;
            obj1 = new Ejercicio25();
            obj1.Ejer25();
        }
        public void Ejer25()
        {
            double dato1, dato2, dato3;
            double resul1;
            Console.WriteLine("Ingrese tres Notas");
            Console.WriteLine("Ingrese Nota 1");
            dato1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 2");
            dato2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 3");
            dato3 = double.Parse(Console.ReadLine());
            resul1 = dato1 + dato2 + dato3;
            if (resul1 >= 7.0)
            {
                Console.WriteLine("\n********Promocionado***********");
            }
            else
            {
                Console.WriteLine("\n********Reprobado*********");
            }
            Console.ReadKey();
        }
    }
}
