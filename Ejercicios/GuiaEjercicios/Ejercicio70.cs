using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio70
    {
        public void Main()
        {
            Console.WriteLine("ingrese numero de filas: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero de columnas: ");
            int colums = int.Parse(Console.ReadLine());

            int[,] matriz = new int[row , colums];

            Console.WriteLine(+matriz[row,colums]);

            Console.ReadKey();
        }
    }
}
