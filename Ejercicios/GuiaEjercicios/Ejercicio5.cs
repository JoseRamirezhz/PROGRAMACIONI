using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio5
    {
        public void Main()
        {
            int edad, FechaN, AnioAct;

            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            FechaN = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio actual: ");
            AnioAct = int.Parse(Console.ReadLine());

            edad = AnioAct - FechaN;

            Console.WriteLine("Usted tiene: "+edad+ " anios");
            Console.ReadKey();
        }
    }
}
