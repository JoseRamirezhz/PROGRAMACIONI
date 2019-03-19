using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio27
    {
        public void Main()
        {
            Ejercicio27 obj1;
            obj1 = new Ejercicio27();
            obj1.Ejer27();
        }
        public void Ejer27()
        {
            int cant;
            double preciou, total, totald, desc;
            Console.WriteLine("Ingrese Total de Productos");
            cant = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Precio Global Unitario de los Producto");
            preciou = double.Parse(Console.ReadLine());
            total = preciou * cant;
            if (total <= 20000)
            {
                totald = total * 0.15;
                desc = total - totald;
                Console.WriteLine("Total a cancelar es de: " + desc);
            }
            else
            {
                totald = total * 0.35;
                desc = total - totald;
                Console.WriteLine("Total a cancelar es de: " + desc);
            }
            Console.ReadKey();
        }
    }
}
