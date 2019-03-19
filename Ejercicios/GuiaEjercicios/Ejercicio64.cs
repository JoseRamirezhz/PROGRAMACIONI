using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio64
    {
        public void Main()
        {
            
            int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10, n11, n12, n13, n14, n15, n16, n17;

            int[] vector;
            vector = new int[17];
            Console.WriteLine("Ingrese 17 numero para el vector: ");
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
            Console.Write("N11 "); n11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); n12 = int.Parse(Console.ReadLine());
            Console.Write("N13 "); n13 = int.Parse(Console.ReadLine());
            Console.Write("N14 "); n14 = int.Parse(Console.ReadLine());
            Console.Write("N15 "); n15 = int.Parse(Console.ReadLine());
            Console.Write("N16 "); n16 = int.Parse(Console.ReadLine());
            Console.Write("N17 "); n17 = int.Parse(Console.ReadLine());

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
            vector[10] = n11;
            vector[11] = n12;
            vector[12] = n13;
            vector[13] = n14;
            vector[14] = n15;
            vector[15] = n16;
            vector[16] = n17;

            foreach(int elemento in vector)
            {
                Console.WriteLine("vector :  "+ elemento);
            }


            vector[16] = n1;
            vector[15] = n2;
            vector[14] = n3;
            vector[13] = n4;
            vector[12] = n5;
            vector[11] = n6;
            vector[10] = n7;
            vector[9] = n8;
            vector[8] = n9;
            vector[7] = n10;
            vector[6] = n11;
            vector[5] = n12;
            vector[4] = n13;
            vector[3] = n14;
            vector[2] = n15;
            vector[1] = n16;
            vector[0] = n17;

            Console.WriteLine("--------------------------------------------");
            foreach (int elemento in vector)
            {
                
                Console.WriteLine("vector : "+  elemento);
            }

            Console.ReadKey();

        }
    }
}
