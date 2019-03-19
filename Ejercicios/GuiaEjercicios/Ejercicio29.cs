using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio29
    {
        public void Main()
        {
            Ejercicio29 obj1;
            obj1 = new Ejercicio29();
            obj1.Ejer29();
        }
        public void Ejer29()
        {
            double temp;
            Console.WriteLine("PROGRAMA QUE ME MUESTRA COMO ESTA EL CLIMA EN BASE A TEMPERATURA INGRESADA");
            Console.WriteLine("INGRESAR TEMPERATURA EN GRADOS CELSIUS");
            temp = double.Parse(Console.ReadLine());
            if (temp > 35)
            {
                Console.WriteLine("Que semana Tan Calurosa");
            }
            else if (temp >= 15 && temp <= 35)
            {
                Console.WriteLine("Que clima tan Delicioso");
            }
            else
            {
                Console.WriteLine("Que Semana tan Fria");
            }
            Console.ReadKey();
        }
    }
}
