using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio28
    {
        public void Main()
        {
            Ejercicio28 obj1;
            obj1 = new Ejercicio28();
            obj1.Ejer28();
        }
        public void Ejer28()
        {
            int numero;
            double comp;
            Console.WriteLine("CALCULANDO SI EL NUMERO INGRESADO ES PAR O IMPAR");
            Console.WriteLine("Ingrese un Numero Entero");
            numero = int.Parse(Console.ReadLine());
            comp = numero % 2;
            if (comp == 0)
            {
                Console.WriteLine("El Numero " + numero + " Es PAR");
            }
            else
            {
                Console.WriteLine("El Numero " + numero + " Es IMPAR");
            }
            Console.ReadKey();
        }
    }
}
