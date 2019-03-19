using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio23
    {
        public void Main()
        {
            double Valor, Costo;
            int Cant;
            Console.WriteLine("Digite la cantidad de articulos a comprar: ");
            Cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el costo del articulo en cuestion de unidad: ");
            Valor = double.Parse(Console.ReadLine());
            Costo = Valor * Cant;
            if (Costo > 100000)
            {
                Console.WriteLine("La compra ha superado los $100,000 dolares por ende se le hara un descuento del %20 sobre el valor final, terminando por pagar lo siguiente.");
                Console.WriteLine("Costo a pagar sin descuento: " + Costo);
                double CostDesc;
                CostDesc = Costo - (Costo * .20);
                Console.WriteLine("Con el %20 de descuento usted cancelara:  " + CostDesc);
            }
            else
            {
                Console.WriteLine("La compra no supero los $100,000 dolares, por lo tanto la factura a cancelar es de: ");
                Console.WriteLine(" $" + Costo + " Dolares de Estados Unidos de America");
            }
            Console.ReadKey();
        }
    }
}
