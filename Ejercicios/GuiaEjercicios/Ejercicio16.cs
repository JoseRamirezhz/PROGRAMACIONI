using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio16
    {
        public void Main()
        {
            int Edad, Nac;
            Console.WriteLine("Digite su edad: ");
            Edad = int.Parse(Console.ReadLine());

            if (Edad > 18)
            {
                int Positivo;
                Positivo = 0;
                Console.WriteLine("Digite el ano de nacimiento: ");
                Nac = int.Parse(Console.ReadLine());
                Positivo = 2019 - Nac;
                if (Positivo >= 18)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");

                }

            }
            Console.ReadKey();
        }
    }
}
