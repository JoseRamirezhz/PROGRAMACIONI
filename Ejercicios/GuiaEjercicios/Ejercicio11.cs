using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio11
    {
        public void Main()
        {
            double SalarioDia, Salud, Pension, Total;
            int DiasTrab;
            Console.WriteLine("Digite el salario en cuestion de dia: ");
            SalarioDia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de dias laborados:  ");
            DiasTrab = int.Parse(Console.ReadLine());
            Salud = (SalarioDia * DiasTrab) * .15;
            Pension = (SalarioDia * DiasTrab) * .10;
            Total = (SalarioDia * DiasTrab) - Salud - Pension;
            Console.WriteLine("El total a pagar al empleado descontando un 10% de pension y 15% salud ");
            Console.WriteLine("Es: $" + Total);
            Console.ReadKey();
        }
    }
}
