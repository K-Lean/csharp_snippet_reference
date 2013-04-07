class Example2 {
	static void Main( ) {
		int[ ] arg = {10, 9, 8, 7};
		Method(arg);
		System.Console.WriteLine(arg[0]);
	}

	// Metodo: modifica la tabla original creada en Main
	static void Metodo(int[ ] parametro) {
		parametro[0]++;
	}
}

/** 
Cuando se pasa una variable de tabla como argumento para un método
, el parámetro del método pasa a ser una copia del argumento de la 
variable de tabla. En otras palabras, el parámetro de tabla se 
inicializa desde el argumento. Para inicializar el parámetro de tabla 
se usa la misma sintaxis que para inicializar una variable de tabla, 
como se explicó anteriormente en el tema “Copia de variables de 
tablas”. Tanto el argumento de tabla como el parámetro de tabla apuntan 
a la misma tabla.

arg se inicializa con una tabla de longitud 4 que contiene los enteros 
10, 9, 8 y 7. A continuación se pasa arg como argumento para Method. 
Method acepta arg como parámetro, lo que quiere decir que tanto arg 
como el parámetro apuntan a la misma tabla (la empleada para inicializar
arg). La expresión parametro[0]++ en Method hace que se incremente el 
elemento inicial de la misma tabla de 10 a 11 (el elemento inicial de 
una tabla también recibe el nombre de elemento “cero”, ya que se accede 
a él con el valor de índice 0, no 1). Method devuelve el valor de arg[0] 
y Main lo escribe en la consola. El parámetro arg continúa apuntando a 
la misma tabla cuyo elemento cero ha sido incrementado, por lo que en la 
consola se escribe 11.

Cuando se pasa una variable de tabla no se crea una copia profunda de 
la tabla, lo que hace que pasar una tabla como parámetro sea muy rápido. 
Esta copia superficial es más que suficiente si se quiere que un método 
tenga acceso de escritura a la tabla del argumento.
El método Array.Copy resulta útil para asegurarse de que el método 
llamado no puede modificar la tabla, aunque esta seguridad se paga con 
un tiempo de ejecución más largo. También es posible pasar como parámetro
de tabla una tabla de nueva creación de la siguiente manera:
*/
Method(new int[4]{10, 9, 8, 7});