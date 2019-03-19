using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio65
    {
        public void Main()
        {
            int num;
            Console.WriteLine("Ingrese la cantidad de clientes atendidos al dia: ");
            num = int.Parse(Console.ReadLine());

            int[] dia;

            dia = new int[num];

            dia[0] = num;
            dia[1] = num;
            dia[2] = num;
            dia[3] = num;
            dia[4] = num;
            dia[5] = num;
            dia[6] = num;
            dia[7] = num;
            dia[8] = num;
            dia[9] = num;
            dia[10] = num;
            dia[11] = num;



            foreach (int elemento in dia)
            {
                Console.WriteLine("Cliente :  " +""+ elemento);
                
            }
            Console.ReadKey();
        }
    }
}
