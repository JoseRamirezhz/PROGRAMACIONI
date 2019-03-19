using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio10
    {
        public void Main()
        {
            double VUnitario, VaFinal, VDesc;
            int Cant;

            Console.WriteLine("Digite la cantidad de Elementos a comprar: ");
            Cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio del articulo en cuestion de unidad: ");
            VUnitario = double.Parse(Console.ReadLine());
            VaFinal = VUnitario * Cant;
            VDesc = VaFinal - (VaFinal * 0.13);
            Console.WriteLine("El valor final a cancelar es:  " + VDesc);
            Console.ReadKey();
        }
    }
}
