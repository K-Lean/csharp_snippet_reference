using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saludos
{
    class Saludar
    {
        static void Main(string[] args)
        {
            string miNombre;
            try
            {
                Console.WriteLine("Por favor, escriba su nombre");
                miNombre = Console.ReadLine();

                Console.WriteLine("Hola {0}", miNombre);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
