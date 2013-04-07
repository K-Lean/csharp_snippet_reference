/**
En ocasiones resulta útil tener un método que pueda aceptar un número 
variable de parámetros. En C# se puede emplear la palabra clave params
para indicar una lista de parámetros de longitud variable. Cuando se 
declara un parámetro de longitud variable hay que:
	• Declarar sólo un parámetro params por método.
	• Poner el parámetro al final de la lista de parámetros.
	• Declarar el parámetro como de tipo tabla unidimensional.
*/


static long AddList(params long[ ] v) {
	long total, i;
	for (i = 0, total = 0; i < v.Length; i++)
		total += v[i];
	return total;
}

// Como un parámetro params es siempre una tabla, todos los valores 
// deben ser del mismo tipo.

static void Main( ) 
{
	long x = AddList(63,21,84);
}

/**
SOBRE EL PASO DE VALORES EN LOS PARAMS

Hay dos maneras de pasar valores al parámetro params cuando se hace 
una llamada a un método con un parámetro de longitud variable:
	• Como una lista de elementos separados por comas 
		(la lista puede estar vacía)
	• Como una tabla
		Ambas técnicas se muestran en el siguiente código. El 
		compilador trata las dos técnicas de la misma forma.

static void Main( )
{
long x;
x = AddList (63, 21, 84); // Lista
x = AddList (new long[ ]{ 63, 21, 84 }); // Tabla
}
Independientemente del método empleado para hacer la llamada al método, 
el parámetro params se trata siempre como una tabla. Se puede usar la 
propiedad Length de la tabla para determinar el número de parámetros 
pasados a cada llamada.

Los datos se copian en el parámetro params y, aunque es posible modificar
los valores dentro del método, los valores fuera del método no cambian.

Para conservar los cambios realizados en el método se usa una tabla object.
*/