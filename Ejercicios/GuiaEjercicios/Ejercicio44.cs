﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio44
    {
        public void Main()
        {
            int numero;

            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " : " + (numero * i));
            }
            Console.ReadKey();
        }
    }
}
