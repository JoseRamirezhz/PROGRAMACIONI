using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio54
    {
        public void Main()
        {

            int na = 0;//Nunmero de articulos

            int a = 0;//Articulos

            //int t = 0;//Total

            int s = 0;



            Console.WriteLine("\tTienda firulais");

            Console.WriteLine("\n\tbienvenido");

            string resp = "s";

            while (resp == "si" || resp == "s")
            {

                s = 0; //suma de los articulos

                Console.WriteLine("\nNumero de articulos a comprar");

                na = int.Parse(Console.ReadLine());

                for (int i = 0; i <= na; i++)
                {

                    Console.WriteLine("\nintroducir precio de cada articulo");

                    a = int.Parse(Console.ReadLine());

                    s += a;
                    //t = na * a;


                }

                Console.WriteLine("la suma total es {0}", s);

                Console.Write("\nDesea realizar otro calculo?: ");
                resp = Console.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
