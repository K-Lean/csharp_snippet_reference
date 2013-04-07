Copia en mayusculas de un archivo
---------------------------------

using System;
using System.IO;

/// <summary>
///    Class to create an upper case copy of a file
/// </summary>

public class CopyFileUpper
{
    public static void Main()
	{
        string nArchivoEntrada; // nombre del archivo de entrada
        string nArchivoSalida; // nombre del archivo de salida

        StreamReader srEntrada;
        StreamWriter swSalida;

        // Pedir el nombre del archivo de entrada
        Console.WriteLine("Ingrese el nombre del archivo a copiar: ");
        nArchivoEntrada = Console.ReadLine();

        // Pedir el nombre del archivo de salida
        Console.WriteLine("Ingrese el nombre del archivo destino (copia): ");
        nArchivoSalida = Console.ReadLine();

        Console.WriteLine("Copiar de {0} a {1}", nArchivoEntrada, nArchivoEntrada);

        try
        {
            srEntrada = new StreamReader(nArchivoEntrada);
            swSalida = new StreamWriter(nArchivoSalida);

            while (srEntrada.Peek() != -1)
            {
                string sBuffer = srEntrada.ReadLine();
                swSalida.WriteLine(sBuffer.ToUpper());
                
            }
            srEntrada.Close();
            swSalida.Close();

        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Archivo de entrada no encontrado!");
            
        }
        catch (Exception e) {
            Console.WriteLine("Excepcion inesperada!", e.Message);
            Console.WriteLine(e.ToString());
            
        }
			
	}       
}

/*
EJECUTABLE:
-----------

Cómo probar el programa
1. Abra una ventana Command y vaya a la carpeta bindebug dentro del
proyecto CopyFileUpper.

2. Ejecute CopyFileUpper.

3. Cuando lo pida el programa, indique como nombre de archivo de origen
drive:\path\CopyFileUpper.cs
ej: c:\archivoOrigen.txt

(es el archivo que acaba de crear).

4. Indique c:\AcrchivoDestino.txt como archivo de destino.

5. Cuando el programa finalice, utilice un editor de texto para examinar el
archivo Test.cs, que debería contener una copia del código fuente en letras
mayúsculas.
*/