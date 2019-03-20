using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio66
    {

        public void Main()
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;
            int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12;
            Console.WriteLine("Ingrese 12 numero para el primer vector: ");
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
            Console.WriteLine("");
            Console.WriteLine("Ingrese 12 numero para el segundo vector: ");
            Console.Write("N1  "); j1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); j2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); j3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); j4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); j5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); j6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); j7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); j8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); j9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); j10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); j11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); j12 = int.Parse(Console.ReadLine());

            int[] Vector1 = new int[12] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 };
            int[] Vector2 = new int[12] { j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12 };
            int[] Vector3 = new int[12] ;
            int[] Vector4 = new int[12];

            
            Console.WriteLine("");
            Console.WriteLine("La suma del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i<12; i++)
            {
                Vector3[i] = Vector1[i] + Vector2[i];

                Console.WriteLine("La suma es: "+ Vector3[i]  );

            }

            Console.WriteLine("");
            Console.WriteLine("La resta del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i < 12; i++)
            {
                Vector4[i] = Vector1[i] - Vector2[i];

                Console.WriteLine("La resta es: " + Vector4[i]);

            }
            Console.ReadKey();
        }
    }
}
