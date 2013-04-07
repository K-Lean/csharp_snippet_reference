using System;

class Hola 
{
	public static int Main() 
	{
		Console.WriteLine("Hola, Mundo!");
		return 0;
	}
}

/**
Si sólo hay un método Main, el compilador lo interpretará automáticamente
como el punto de entrada al programa. El siguiente código muestra un ejemplo:
*/

// UnaEntrada.cs
class UnaEntrada
{
	static void Main( )
	{
		...
	}
}
// fin del archivo

/** 
Si, por el contrario, existen varios métodos llamados Main, es necesario que 
uno de ellos esté designado explícitamente como punto de entrada al programa 
(y que ese Main también sea público explícitamente). 
El siguiente código muestra un ejemplo:
*/

// DosEntradas.cs
using System;

class EntradaUno
{
	public static void Main( )
	{
		Console.Write("EntradaUno.Main( )");
	}
}

class EntradaDos
{
	public static void Main( )
	{
		Console.Write("EntradaDos.Main( )");
    }
}
// Fin del archivo

¿Por qué Main es estático?

El hecho de que Main sea estático hace que sea posible invocarlo sin que el 
runtime tenga que crear una instancia de la clase.

Las llamadas a métodos no estáticos sólo pueden estar en un objeto, como se 
ve en el siguiente código:

class Ejemplo
{
	void NonStatic( ) { ... }

	static void Main( )
	{
		Ejemplo eg = new Ejemplo( );
		eg.NonStatic( ); // Compila
		NonStatic( ); // error al compilar, necesito un objeto para usar el metodo
	}
	...
}


Esto significa que si Main no es estático, como en el siguiente código, 
el runtime necesita crear un objeto para hacer una llamada a Main.

class Ejemplo
{
	void Main( )
	{
		...
	}
}

En otras palabras, en la práctica el runtime tendría que ejecutar el 
siguiente código:

Ejemplo ejecuta = new Ejemplo( );
ejecuta.Main( );















