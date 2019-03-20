using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio26
    {
        public void Main()
        {
            Ejercicio26 obj1;
            obj1 = new Ejercicio26();
            obj1.Ejer26();
        }
        public void Ejer26()
        {
            int dato1;
            Console.WriteLine("Ingrese Un Numero de 1 o 2 cifras positivo");
            dato1 = int.Parse(Console.ReadLine());
            if (dato1 >= 1 && dato1 <= 9)
            {
                Console.WriteLine("El numero ingresado tiene 1 cifra");
            }
            else if (dato1 >= 10 && dato1 <= 99)
            {
                Console.WriteLine("El numero ingresado tiene 2 cifra");
            }
            else
            {
                Console.WriteLine("Error Ingrese un numero Positivo de 1 o 2 Cifras");
            }
            Console.ReadKey();
        }
    }
}
