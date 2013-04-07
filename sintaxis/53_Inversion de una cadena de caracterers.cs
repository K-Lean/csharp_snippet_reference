Inversión de una cadena de caracteres
-------------------------------------


 // Invierte una cadena
    public static void Invertir(ref string s) {
        string sInv = "";
        for (int k = s.Length-1; k >= 0; k--)
            sInv += s[k];
        
        // devolver el resultado a llamador
        s = sInv;
    }



 namespace Utils
{
    using System;
    public class Test
    {
        public static void Main()
        {
            string unaCadena;

            // Obtenemos una cadena de entrada
            Console.WriteLine("Escriba una cadena para invertirla: ");
            unaCadena = Console.ReadLine();

            // Invertimos la cadena
            Utils.Invertir(ref unaCadena);

            // Mostramos el resultado
            Console.WriteLine(unaCadena);
        }
    }
}
