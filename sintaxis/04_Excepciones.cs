using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Excepciones
{
    class Hola
    {
        static void Main(string[] args)
        {
            string s = "hola";
            try
            {
                Console.WriteLine(args[0]);

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion en: {0}", e.StackTrace);
                
            }
            Console.ReadLine();
        }
    }
}
