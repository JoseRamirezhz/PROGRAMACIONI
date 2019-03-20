using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio59
    {
        public void Main()
        {

            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;

            int[] vector;
            vector = new int[10];
            
            Console.WriteLine("Ingrese 10 edades: ");
            Console.Write("N1  "); n1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); n2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); n3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); n4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); n5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); n6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); n7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); n8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); n9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); n10 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("---------------------------------------");
            vector[0] = n1;
            vector[1] = n2;
            vector[2] = n3;
            vector[3] = n4;
            vector[4] = n5;
            vector[5] = n6;
            vector[6] = n7;
            vector[7] = n8;
            vector[8] = n9;
            vector[9] = n10;
            

            foreach (int elemento in vector)
            {
                Console.WriteLine("Edad :  " + elemento+ " anios");
            }


            

            Console.ReadKey();

        }
    }
}
