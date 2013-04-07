Abrir y Cerrar un Archivo como una Secuencia
--------------------------------------------

Ejemplo de System.IO
--------------------
A continuación se incluye un breve ejemplo en el que se muestra cómo abrir y 
leer un archivo como una secuencia. Este ejemplo no es indicativo de todas 
las maneras posibles de emplear el espacio de nombres System.IO, pero ilustra 
cómo se puede efectuar una sencilla operación de copia de archivos.

	using System;
	using System.IO; // Usar espacio de nombres IO
	// ...
	StreamReader reader = new StreamReader("archivoentrada.txt");
	// Entrada de texto desde archivo

	StreamWriter writer = new StreamWriter("archivosalida.txt");
	// Salida de texto a archivo

	string line;
	while ((line = reader.ReadLine( )) != null) {
		writer.WriteLine(line);
	}

	reader.Close( );
	writer.Close( );

Para abrir un archivo para lectura, el código del ejemplo crea un nuevo objeto 
StreamReader y pasa el nombre del archivo que se desea abrir en el constructor. 
Del mismo modo, el ejemplo crea un nuevo objeto StreamWriter y pasa el nombre 
del archivo de salida en su constructor para abrir un archivo para escritura. 
En este ejemplo los nombres de los archivos están incluidos en el código, 
pero también podrían ser variables string.

El programa del ejemplo copia un archivo leyendo línea a línea de la secuencia 
de entrada y escribiendo esa línea en la secuencia de salida.
