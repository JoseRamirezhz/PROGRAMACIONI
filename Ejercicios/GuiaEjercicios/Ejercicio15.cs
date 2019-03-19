using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio15
    {
        public void Main()
        {
            double VUnitario, VaFinal;
            int Cant;

            Console.WriteLine("Digite la cantidad de Elementos a comprar: ");
            Cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio del articulo en cuestion de unidad: ");
            VUnitario = double.Parse(Console.ReadLine());
            VaFinal = VUnitario * Cant;
            Console.WriteLine("Usted debe abonar un valor de: " + VaFinal);
            Console.ReadKey();

        }
    }
}
