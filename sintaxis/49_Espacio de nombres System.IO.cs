Espacio de nombres System.IO
----------------------------
El espacio de nombres System.IO es importante porque contiene muchas clases que 
permiten a una aplicación efectuar distintas operaciones de entrada y salida 
(I/O) en el sistema de archivos.

Incluye también clases para que una aplicación pueda realizar operaciones de 
entrada y salida sobre archivos y directorios.

El espacio de nombres System.IO es demasiado grande para que podamos explicarlo 
aquí con detalle. No obstante, la siguiente lista da una idea de las 
posibilidades:

• Las clases File y Directory permiten a una aplicación crear, borrar y 
	manipular directorios y archivos.

• Las clases StreamReader y StreamWriter permiten a un programa acceder a 
	los contenidos de un archivo como una secuencia de bytes o caracteres.

• La clase FileStream se puede emplear para dar acceso aleatorio a archivos.

• Las clases BinaryReader y BinaryWriter ofrecen una forma de leer y escribir 
	tipos de datos primitivos como valores binarios.

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

ReadLine y WriteLine nos pueden resultar familiares, ya que la clase Console 
incluye dos métodos estáticos del mismo nombre. En el ejemplo, estos métodos 
son métodos de instancia de las clases StreamReader y StreamWriter, 
respectivamente.

Para más información sobre el espacio de nombres System.IO, busque 
“espacio de nombres System.IO” en los documentos de ayuda del SDK de 
.NET Framework.

