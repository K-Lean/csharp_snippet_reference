REFLEXION
---------
Consiste en obtener información sobre el tipo de objeto que se esta tratando.

Es posible obtener información sobre el tipo de un objeto empleado un mecanismo 
llamado reflexión.

El operador typeof
------------------
En tiempo de compilación se puede utilizar el operador typeof para obtener 
información de tipo para un nombre de tipo concreto.

Este ejemplo obtiene información en tiempo de compilación para el tipo byte 
y muestra el nombre del tipo en la consola.

	using System;
	using System.Reflection;

	Type t = typeof(byte);
	Console.WriteLine("Type: {0}", t);

El siguiente ejemplo muestra información más detallada sobre una clase. 
Más concretamente, muestra los métodos para esa clase.

	using System;
	using System.Reflection;

	Type t = typeof(string); // Obtener información sobre tipo
	InfoMetodos [ ] mi = t. GetMethods( );
	
	foreach (MethodInfo m in mi) {
		Console.WriteLine("Method: {0}", m);
	}


Método GetType
--------------
El operador typeof sólo funciona con clases que existen en tiempo de 
compilación. Cuando se necesita información sobre tipo en tiempo de 
ejecución se puede emplear el método GetType de la clase Object.

Para más información sobre reflexión, busque “System.Reflection” en los 
documentos de ayuda del SDK de .NET Framework.

