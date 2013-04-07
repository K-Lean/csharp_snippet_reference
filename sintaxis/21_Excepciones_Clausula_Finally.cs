
/**
Las excepciones siempre se producen en el momento más inoportuno. 
La instrucción finally de C# permite liberar los recursos utilizados 
y evita la pérdida de información.
*/

Monitor.Enter(x);
try {
	...
}
finally {
	Monitor.Exit(x);
}




/**
La cláusula finally de C# contiene un conjunto de instrucciones que es 
necesario ejecutar sea cual sea el flujo de control. Así, las instrucciones
del bloque finally se ejecutarán aunque el control abandone un bucle try 
como resultado de la ejecución normal porque el flujo de control llega al 
final del bloque try. Del mismo modo, también se ejecutarán las instrucciones
del bloque finally si el control abandona un bucle try como resultado de una
instrucción throw o una instrucción de salto como break, continue o goto.
El bloque finally es útil en dos casos: para evitar la repetición de 
instrucciones y para liberar recursos tras el lanzamiento de una excepción.
*/

// Repetición de instrucciones
// Si las instrucciones del final de un bloque try están repetidas en un 
// bloque catch general, se puede evitar la duplicación pasando las 
// instrucciones a un bloque finally. Consideremos el siguiente ejemplo:
try {
	...
	instrucciones
}
catch {
	...
	instrucciones
}

// Este código se puede reescribir de la siguiente manera para simplificarlo:
try {
	...
}
catch {
	...
}
finally {
	instrucciones
}

// Es un error que una instrucción break, continue o goto transfiera el control 
// fuera de un bloque finally. Estas instrucciones sólo se pueden utilizar si el
// objetivo del salto está en el mismo bloque finally. Sin embargo, siempre es un
// error que haya una instrucción return en un bloque finally, aunque sea la 
// última instrucción del bloque.

// Si se lanza una excepción durante la ejecución de un bloque finally, 
//se propagará hasta el siguiente bloque try :

try {
	try {
		...
	}
	catch {
		// EjemploExcepcion no se captura aquí
	}
	finally {
		throw new EjemploExcepcion ("¿quién me capturará?");
	}
}
catch {
	// EjemploExcepcion se captura aquí
}

// Si se lanza una excepción durante la ejecución de un bloque finally y ya 
// se estaba propagando otra excepción, se perderá la excepción original:
try {
	throw new EjemploExcepcion ("Se pierde");
}
finally {
	throw new EjemploExcepcion ("Se puede encontrar y capturar");
}