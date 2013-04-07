using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_MostrarDatosEnPantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma de {0} y {1} es {2}: ", 100, 120, 100 + 120);
            Console.WriteLine("\"Justificacion a la derecha en un campo, de anchura 10: {0, 10}\"", 47);
            Console.WriteLine("\"Justificacion a la izquierda en un campo, de anchura 10: {0, -10}\"", 47);

            Console.WriteLine("Ejemplo de un path como string: " + @"C:\Widnows\Leandro\Lean.txt");

            Console.WriteLine("Formato de moneda - {0:C} {1:C4}", 88.8, -888.8);
            Console.WriteLine("Formato entero - {0:D5}", 88);
            Console.WriteLine("Formado exponencial - {0:E}", 888.8);
            Console.WriteLine("Formato de punto fijo - {0:F3}", 888.8888);
            Console.WriteLine("Formato general - {0:G}", 888.8888);
            Console.WriteLine("Formato de número - {0:N}", 8888888.8);
            Console.WriteLine("Formato hexadecimal - {0:X4}", 88);
            Console.ReadLine(); 
        }
    }
}
