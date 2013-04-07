// Es posible dar el mismo nombre a más de un método en una clase.
class OverloadingExample {
	static int Suma(int a, int b) {
		return a + b;
	}

	static int Suma(int a, int b, int c) {
		return a + b + c;
	}

	static void Main( ) {
		Console.WriteLine(Suma(1,2) + Suma(1,2,3));
	}
}

// Un Ejemplo Completo
class GreetDemo
{
	enum TimeOfDay { Manana, Tarde, Noche }
	
	static void Greet( )
	{
		Console.WriteLine("Hola");
	}
	
	static void Greet(string Name)
	{
		Console.WriteLine("Hola " + Name);
	}
	
	static void Greet(string Name, TimeOfDay td)
	{
		string Message = "";
		switch(td)
		{
		case TimeOfDay.Manana:
			Message="Buenos días";
			break;
		case HoraDelDia.Tarde:
			Message="Buenas tardes";
			break;
		case HoraDelDia.Noche:
			Message="Buenas noches";
			break;
		}
	Console.WriteLine(Mensaje + " " + Name);
	}
	
	static void Main( )
	{
		Greet( );
		Greet("Alex");
		Greet("Sandra", HoraDelDia.Manana);
	}
}