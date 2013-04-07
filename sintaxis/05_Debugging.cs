namespace Converter
{
using System;

/// <summary>
///    The ConvertIt class will convert a temperature in the
///    Fahrenheit scale to the equivalent value in the Celsius scale
/// </summary>
public class ConvertIt
{

    public static int Main(string[] args)
    {
		string temp;
		int degreesFahrenheit;
		float degreesCelsius;
		
		try {
		   Console.Write("Please give me a temperature in degrees F:");
		   temp = Console.ReadLine();
		   degreesFahrenheit = Int32.Parse(temp);
		   degreesCelsius = (degreesFahrenheit - 32f) * 5 / 9;
		   Console.WriteLine("{0} degrees F is {1} degrees C", 
		 	   degreesFahrenheit, degreesCelsius);
		} catch (Exception e) {
			Console.WriteLine("An error occured: {0}", e);
		}

        return 0;
    }
}
}
