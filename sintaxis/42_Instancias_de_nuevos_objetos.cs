struct Reloj
{
	public int hora, minuto;
}

class Programa
{
	static void Main( )
	{
		Reloj ahora;
		ahora.hora = 11;
		ahora.minuto = 59;
		...
	}
}

Las variables del tipo struct son tipos de valor. Esto quiere decir que, 
cuando se declara una variable de estructura (como ahora en Main), se crea 
un valor en la pila. En este caso, la estructura Reloj contiene dos ints, 
por lo que la declaración de ahora crea dos ints en la pila, una llamada 
ahora.hora y otra ahora.minuto. Estos dos ints NO se inicializan a cero por 
defecto. Por eso no es posible leer el valor de ahora.hora ni de ahora.minuto 
hasta que se les asigna un valor. Los valores sólo tienen validez en el bloque 
en el que se declaran. En este ejemplo, el ámbito de ahora es Main. 
Esto significa que cuando el flujo de control abandona Main (por un return 
normal o porque se ha lanzado una excepción), ahora quedará fuera de ámbito 
y dejará de existir.

Las clases son totalmente distintas, como muestra el siguiente código:

class Reloj // NOTA: Reloj es ahora una clase
{
	public int hora, minuto;
}

class Programa
{
	static void Main( )
	{
		Reloj ahora;
		ahora.hora = 11;
		ahora.minuto = 59;
		...
	}
}

Cuando se declara una variable de clase, no se crea una instancia u objeto de 
esa clase. En este caso, la declaración de ahora no crea un objeto de la clase
Reloj. Al declarar una variable de clase se crea una referencia que puede 
apuntar a un objeto de esa clase. Por esta razón las clases se llaman tipos de 
referencia. Esto significa que, si el runtime ejecutara el código anterior, 
intentaría acceder a los enteros dentro de un objeto Reloj que no existe. 
Afortunadamente, el compilador avisaría de este error con el siguiente mensaje:

error CS0165: Uso de variable local no asignada 'ahora'

Para corregir este error es necesario crear un objeto Reloj (usando la palabra
reservada new) y hacer que la variable de referencia ahora apunte al objeto 
recién creado, como en el siguiente código:

class Programa
{
	static void Main( )
	{
		Reloj ahora = new Reloj( );
		ahora.hora = 11;
		ahora.minuto = 59;
		...
	}
}


Recordemos que, cuando se crea un valor de estructura local en la pila, 
los campos NO se inicializan a cero por defecto. Las clases son diferentes: 
cuando se crea un objeto como una instancia de una clase, como anteriormente, 
los campos del objeto se inicializan a cero por defecto. El siguiente código 
se compilará sin errores:

class Programa
{
	static void Main( )
	{
		Reloj ahora = new Reloj( );
		Console.WriteLine(ahora.hora); // escribe 0
		Console.WriteLine(ahora.minuto); // escribe 0
		...
	}
}
