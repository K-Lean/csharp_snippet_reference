class Example4 {
	static void Main(string[ ] args) {
		
		foreach (string arg in args) {
			System.Console.WriteLine(arg);
		}
	}
}

--------------------------------------------------------------
Cuando se puede emplear, la instrucción foreach 
resulta útil porque simplifica el proceso de recorrer 
de uno en uno todos los elementos de una tabla. 
Sin foreach se podría escribir:
--------------------------------------------------------------
for (int i = 0; i < args.Length; i++) {
	System.Console.WriteLine(args[i]);
}


Con foreach se convertiría en:
--------------------------------------------------------------
foreach (string arg in args) {
	System.Console.WriteLine(arg);
}

Con la instrucción foreach no se necesita ni se utiliza:
• Un índice entero (int i)
• Una comprobación de los límites de la tabla (i < args.Length)
• Una expresión de acceso a la tabla (args[i])

También se puede usar la instrucción foreach para recorrer de uno 
en uno todos los elementos de una tabla de rango 2 o superior. 
Por ejemplo, la siguiente instrucción foreach escribirá los 
valores 0, 1, 2, 3, 4 y 5:


int[,] numbers = { {0,1,2}, {3,4,5} };

foreach (int number in numbers) {
	System.Console.WriteLine(number);
}