using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio22
    {
        public void Main()
        {
            String Nombre, NomMat, Cod;
            int i;
            double Nota, Suma;
            Suma = 0;
            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su codido de estudiante: ");
            Cod = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la materia: ");
            NomMat = Console.ReadLine();
            double Prom = 0;
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese la nota numero: " + i);
                Nota = double.Parse(Console.ReadLine());

                Suma = Suma + Nota;
                Prom = Suma / 3;
            }
            if (Prom > 4.0)
            {
                Console.WriteLine("El estudiante con nombre:  " + Nombre + " Y codigo de estudiante:  " + Cod);
                Console.WriteLine(" Aprobo con un promedio final de: " + Prom);
            }
            else
            {

                Console.WriteLine("El estudiante con nombre:  " + Nombre + " Y codigo de estudiante:  " + Cod);
                Console.WriteLine(" Reprobo con un promedio final de: " + Prom);
            }
            Console.ReadKey();
        }
    }
}
