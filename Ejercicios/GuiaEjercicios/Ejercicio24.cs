using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio24
    {
        public void Main()
        {
            Ejercicio24 obj1;
            obj1 = new Ejercicio24();
            obj1.Ejer24();

        }
        public void Ejer24()
        {
            double dato1, dato2;
            double resul1, resul2;
            Console.WriteLine("Ingrese Dos Numeros");
            Console.WriteLine("Ingrese Numero 1");
            dato1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero 2");
            dato2 = double.Parse(Console.ReadLine());
            if (dato1 > dato2)
            {
                Console.WriteLine("Dato 1 es Mayor que Dato 2");
                resul1 = dato1 + dato2;
                resul2 = dato1 - dato2;
                Console.WriteLine("Resultado Suma: " + resul1);
                Console.WriteLine("Resultado Resta: " + resul2);
            }
            else
            {
                Console.WriteLine("Dato 2 es Mayor que Dato 1");
                resul1 = dato2 / dato1;
                resul2 = dato1 * dato2;
                Console.WriteLine("Resultado Division: " + resul1);
                Console.WriteLine("Resultado Multiplicacion: " + resul2);
            }
            Console.ReadKey();
        }
     }
}
