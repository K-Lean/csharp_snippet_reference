// Clase con un campo o valor privado
class CuentaBancaria
{
	
	// metodo publico
	public void Ingresar(decimal cantidad)
	{
		saldo += cantidad;
	}

	// valor o miembro privado 
	private decimal saldo;

}

// Clase con un valor privado u otro estatico

class CuentaBancaria
{
	// metodo publico
	public void Ingresar(decimal cantidad) { ... }

	// metodo publico y estatico Main
	public static void Main( ) { ... }
	...

	// valores o campos (atributos) privados
	private decimal saldo;
    private static decimal interés;

}


Un miembro de una clase para el que no se especifique ningún modificador 
de acceso será privado por defecto. En otras palabras, los dos métodos 
siguientes son idénticos semánticamente:

// Esto
class CuentaBancaria
{
	...
	decimal saldo; // es privado en forma implicita (por defecto)
}

// Es lo mismo que esto
class CuentaBancaria
{
	...
	private decimal saldo; // privado en forma explicita
}


Consejos:
El orden en que se declaran los miembros de una clase no tiene importancia 
para el compilador de C#. Sin embargo, se considera una buena práctica de 
programación declarar los miembros públicos (métodos) antes que los privados 
(datos). Esto se debe a que el usuario de una clase sólo tiene acceso a los 
miembros públicos, por lo que declarar estos antes que los privados refleja 
esa prioridad.








