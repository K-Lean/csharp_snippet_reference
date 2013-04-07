try 
{
	Console.WriteLine("Escriba el primer número");
	int i = int.Parse(Console.ReadLine());
	Console.WriteLine("Escriba el segundo número");
	int j = int.Parse(Console.ReadLine());

	int k = i / j;
} 
catch (OverflowExceptioncapturada) {…}
catch (DivideByZeroExceptioncapturada) {…}