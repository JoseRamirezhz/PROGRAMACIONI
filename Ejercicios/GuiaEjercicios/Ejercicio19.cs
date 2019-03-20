using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio19
    {
        public void Main()
        {
            int Grado;
            String Nombre;
            Console.WriteLine("Ingrese su nombre, estimado estudiante: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Se necesita saber si un estudiante del instituto Enrique Oyala Herrera necesita refrigerio para eso estimamos conocer el grado de dicho estudiante: ");
            Console.WriteLine("Ingrese el grado actual estudiado: ");
            Grado = int.Parse(Console.ReadLine());
            if (Grado <= 6)
            {
                Console.WriteLine("El Estudiante: " + Nombre + " Estudiante activo de: " + Grado + " Grado, por lo tanto.");
                Console.WriteLine("La secretaria de educacion a declarado que el estudiante necesita refrigerio");
            }
            else
            {
                Console.WriteLine("El estudiante esta estudiando: " + Grado + " Grado, por lo tanto no resibe refrigerio");


            }
            Console.ReadKey();
        }
    }
}
