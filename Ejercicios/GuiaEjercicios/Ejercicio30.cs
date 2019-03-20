using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio30
    {
        public void Main()
        {
            Ejercicio30 obj1;
            obj1 = new Ejercicio30();
            obj1.Ejer30();
        }
        public void Ejer30()
        {
            double total, totald, desc;
            Console.WriteLine("PROGRAMA QUE PERMITE CALCULAR DESCUENTO POR CANTIDAD TOTAL");
            Console.WriteLine("INGRESE TOTAL A PAGAR");
            total = double.Parse(Console.ReadLine());
            if (total >= 10000 && total <= 20000)
            {
                totald = total * 0.10;
                desc = total - totald;
                Console.WriteLine("DESCUENTO APLICADO DE 10%");
                Console.WriteLine("Total a cancelar es de: " + desc);
            }
            else if (total >= 20001 && total <= 50000)
            {
                totald = total * 0.30;
                desc = total - totald;
                Console.WriteLine("DESCUENTO APLICADO DE 30%");
                Console.WriteLine("Total a cancelar es de: " + desc);
            }
            else if (total >= 50001)
            {
                totald = total * 0.50;
                desc = total - totald;
                Console.WriteLine("DESCUENTO APLICADO DE 50%");
                Console.WriteLine("Total a cancelar es de: " + desc);
            }
            else
            {
                Console.WriteLine("DESCUENTO APLICADO DE 0%");
                Console.WriteLine("Total a cancelar es de: " + total);
            }
            Console.ReadKey();
        }
    }
}
