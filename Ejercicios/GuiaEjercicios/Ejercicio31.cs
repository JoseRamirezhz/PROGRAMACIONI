using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio31
    {
        public void Main()
        {
            Ejercicio31 obj1;
            obj1 = new Ejercicio31();
            obj1.Ejer31();
        }
        public void Ejer31()
        {
            int edad, estatura;
            double peso;
            Console.WriteLine("PROGRAMA QUE PERMITE ACEPTAR UN JUGADOR DE BALONCESTO");
            Console.WriteLine("INGRESE EDAD");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE ESTATURA EN CENTIMETROS");
            estatura = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE PESO en KILOGRAMOS");
            peso = double.Parse(Console.ReadLine());
            if (edad >= 18 && estatura >= 180 && peso >= 80)
            {
                Console.WriteLine("\nFELICIDADES A SIDO ACEPTADO EN EL EQUIPO");
            }
            else
            {
                Console.WriteLine("\nLO SENTIMOS NO CUMPLE LOS REQUISITOS");
            }
            Console.ReadKey();
        }
    }
}
