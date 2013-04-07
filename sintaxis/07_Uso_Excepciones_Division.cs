using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Uso_Excepciones_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int unEntero;
            int otroEntero;

            try
            {
                Console.WriteLine("Por favor, ingrese un valor entero: ");
                temp = Console.ReadLine();
                unEntero = Int32.Parse(temp);

                Console.WriteLine("Ingrese otro valor entero: ");
                temp = Console.ReadLine();
                otroEntero = Int32.Parse(temp);

                int k = unEntero / otroEntero; // Se puede producir una excepción

                Console.WriteLine(unEntero + " dividido " + otroEntero + " da: " + k);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Excepcion lanzada: {0}", e);
            }

            


        }
    }
}
