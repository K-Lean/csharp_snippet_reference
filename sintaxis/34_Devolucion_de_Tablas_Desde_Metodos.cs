class Example {
	static void Main( ) {
		
		// en un array guardo lo que me devuelve el metodo create
		// al que le paso el tamno (42)
		int[ ] array = CreateArray(42);
		...
	}

	// Crea y devuelve una tabla unidimensional
	static int[ ] CreateArray(int tamano) {
		//int[ ] creada = new int[tamano];
		//return creada; 
		return new int[tamano];
	}

	// Crea y devuelve una tabal bidimensional
	static int[,] CreateArray(int fila, int columna) {
		return new int[fila,columna];
	}

	// Otro ejemplo tipo procedimiento
	// Crea y devuelve una tabla bidimensional
	static int[,] CreateArray() {
		string s1 = System.Console.ReadLine( );
		int filas = int.Parse(s1);
	
		string s2 = System.Console.ReadLine( );
		int columnas = int.Parse(s2);
		
		return new int[fila,columna];
	}
}

/** NOTA:
El método CreateArray en la transparencia contiene dos instrucciones. 
Es posible combinar estas dos instrucciones en una sola instrucción 
return como se indica a continuación:

En ninguno de los dos casos se especifica el tamaño de la tabla que se
devuelve. Si se indica el tamaño de la tabla se obtendrá un error en 
tiempo de ejecución, como en este ejemplo:

static int[4] CreateArray( ) // Error de compilación
{
	return new int[4];
}

También es posible devolver tablas de rango mayor que uno, 
como se ve en el siguiente ejemplo:

static int[,] CreateArray( ) {
	string s1 = System.Console.ReadLine( );
	int filas = int.Parse(s1);
	
	string s2 = System.Console.ReadLine( );
	int columnas = int.Parse(s2);
	
	return new int[filas,columnas];
}

*/


