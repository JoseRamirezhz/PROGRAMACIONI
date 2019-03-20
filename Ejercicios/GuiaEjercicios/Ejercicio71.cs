using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Ejercicio71
    {
        public void Main()
        {
            int[,] Matriz = new int[3,4];

            int suma = 0;
            int fila =0;
            int[]  Matriztot = new int[4];
            for (
                fila = 0; fila < Matriz.GetLength(0); fila++)
            {
               
                for (int columna = 0; columna < Matriz.GetLength(1); columna++)
                {
                    suma = suma + Matriz[fila,columna];  
                }
            }
            Console.WriteLine(Matriztot[fila]);
            Console.ReadKey();
        }
   }    
}
