using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio52
    {
            public void Main()
            {
                int i = 1, notas;
                string ma;
                double no, acu = 0, may = 0, pro;

                Console.WriteLine("Digite el nombre de la materia: ");
                ma = Console.ReadLine();
                Console.WriteLine("Digite la cantidad de notas a ingresar: ");
                notas = int.Parse(Console.ReadLine());

                while (i <= notas)
                {
                    Console.WriteLine("Digite la nota número " + i + ":");
                    no = double.Parse(Console.ReadLine());

                    acu = acu + no;

                    if (may < no)
                    {
                        may = no;
                    }
                    i = i + 1;
                }

                pro = acu / notas;

                Console.WriteLine("La nota mayor es: " + may);
                Console.WriteLine("El promedio es: " + pro);

                if (pro >= 4.0)
                {
                    Console.WriteLine("*Alumno Aprobado*");
                    Console.WriteLine("*Materia: " + ma + "*");
                }
                else
                {
                    Console.WriteLine("*Alumno Reprobado*");
                    Console.WriteLine("*Materia: " + ma + "*");
                }
                Console.ReadKey();


            }
        }
}

