using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio12
    {
        public void Main()
        {
            double Lado;
            Console.WriteLine("Digite un lado de el cuadrado: ");
            Lado = double.Parse(Console.ReadLine());
            Console.WriteLine("El perimetro de el cuadrado se calcula de forma que se multiplica un lado por 4");
            Console.WriteLine("El perimetro como tal es: " + Lado * 4);
            Console.ReadKey();
        }
    }
}
