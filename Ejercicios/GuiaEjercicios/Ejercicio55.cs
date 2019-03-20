using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio55
    {
        public void Main()
        {
            string resp = "s";
            while (resp == "si" || resp == "s")

            {

                double ma = 0, me = 0, num = 0;
                Console.WriteLine("Cuantas estaturas va ingresar");
                double numeros = double.Parse(Console.ReadLine());



                for (double i = 1; i <= numeros; i++)
                {
                    Console.WriteLine("Digite una estatura : ");
                    num = double.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        ma = num;
                        me = num;
                    }
                    if (num > ma) { ma = num; }
                    if (num < me) { me = num; }



                    num = 0;
                }


                Console.WriteLine("la estatura mayor es: " + ma);
                Console.WriteLine("la estatura menor es: " + me);


                Console.Write("\nDesea realizar otro calculo?: ");
                resp = Console.ReadLine();
                Console.ReadKey();
            }
        } 
       }
}
