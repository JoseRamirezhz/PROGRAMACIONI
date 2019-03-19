using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio68
    {
        public void Main()
        {
            int[] Num;
            int cant, menor, mayor;
            int suma=0;

            Console.WriteLine("Dijte la cantidad de Salones: ");
            cant = int.Parse(Console.ReadLine());
            Num = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Cuantos alumnos tiene el salon numero " + (i + 1) + "  : ");
                Num[i] = int.Parse(Console.ReadLine());
                suma = Num[i] * cant;
            }
            
            mayor = Num[0];
            menor = Num[0];
            for (int i = 0; i < cant; i++)
            {
                if (Num[i] > mayor)
                {
                    mayor = Num[i];
                }
                else if(Num[i] < menor)
                {
                    menor = Num[i];
                }
            }

            Console.WriteLine("El total de estdudiantes es es: " + suma);
            Console.WriteLine("El numero menor de estudiantes es: "+ menor);
            Console.WriteLine("El numero mayor de estudiantes es: "+ mayor);
            Console.ReadKey();

        }
    }
}
