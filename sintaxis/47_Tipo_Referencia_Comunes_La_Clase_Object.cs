El tipo object contiene varios métodos comunes que heredan todos los demás 
tipos referencia.

Métodos comunes para todos los tipos referencia
-----------------------------------------------
El tipo object proporciona varios métodos comunes. Los métodos derivados 
también incluyen estos métodos, ya que todos ellos heredan de object. 
Entre estos métodos comunes están los siguientes:

	• ToString
	• Equals
	• GetType
	• Finalize

Método ToString
---------------
El método ToString devuelve una cadena de caracteres que representa el objeto 
actual.

Su forma predeterminada, que se encuentra en la clase Object, devuelve el 
nombre de tipo de la clase. El siguiente ejemplo utiliza la clase coordinate 
definida anteriormente:

coordenada c = new coordinate( );
Console.WriteLine(c.ToString( ));

Este ejemplo escribirá “coordenada” en la consola.

Sin embargo, es posible sobrecargar el método ToString en la clase coordinate 
para que devuelva objetos de ese tipo que sean más representativos, como una 
cadena con los valores que contiene el objeto.

Método Equals
--------------
El método Equals determina si el objeto especificado es el mismo que el objeto 
actual. Como ya hemos visto, la forma predeterminada de Equals incluye 
únicamente la igualdad entre referencias.

Este método puede ser reemplazado por subclases para incluir la igualdad entre 
valores.

Método GetType
--------------
Este método permite extraer de un objeto información sobre su tipo en tiempo 
de ejecución. Se discutirá con más detalle en la sección sobre conversiones 
de datos de este mismo módulo.

Método Finalize
---------------
El sistema de tiempo de ejecución hace una llamada a este método cuando un 
objeto se hace inaccesible.

