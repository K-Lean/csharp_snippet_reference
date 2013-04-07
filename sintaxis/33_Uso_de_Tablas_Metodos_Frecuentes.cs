// Métodos utilizados frecuentemente
//  Sort: Ordena los elementos en una tabla de rango 1
//  Clear: Asigna el valor cero onulla un rango de elementos.
//  Clone: Crea una copia de la tabla
//  GetLength: Devuelve la longitud de una dimensión dada
//  IndexOf: Devuelve el índice de la primera vez que aparece un valor

/** 
Método Sort 
Este método efectúa una ordenación en contexto de la tabla pasada
como argumento. Se puede utilizar para ordenar tablas de estructuras
y clases que admitan la interfaz IComparable.
*/
int[ ] data = {4,6,3,8,9,3}; // Sin ordenar
System.Array.Sort(data); // Ordenada

/** Método Clear
Este método cambia el valor de un rango de elementos 
de la tabla a cero (para tipos de valor) o null 
(para tipos de referencia), como en este ejemplo:
*/
int[ ] data = {4,6,3,8,9,3};
System.Array.Clear(data, 0, data.Length);


/** Método Clone
Este método crea una nueva tabla cuyos elementos son copias de 
los elementos de la tabla original. Se puede utilizar para clonar
tablas de estructuras y clases definidas por el usuario. 
El siguiente es un ejemplo:
*/
int[ ] data = {4,6,3,8,9,3};
int[ ] clone = (int [ ])data.Clone( );

PRECAUCION: 
El método Clone realiza una copia superficial. 
Si la tabla copiada contiene referencias a objetos, 
se copiarán las referencias pero no lo objetos; 
las dos tablas apuntarán a los mismos objetos.

/**
Método GetLength
Este método devuelve la longitud de una dimensión 
pasada como un argumento entero. Se puede utilizar
para comprobar los límites de tablas multidimensionales.
El siguiente es un ejemplo:
*/
int[,] data = { {0, 1, 2, 3}, {4, 5, 6, 7} };
int dim0 = data.GetLength(0); // == 2
int dim1 = data.GetLength(1); // == 4

/** 
Método IndexOf
Este método devuelve el índice entero de la primera 
vez que aparece un valor pasado como argumento, 
o –1 si el valor no está presente. Sólo se puede utilizar
en tablas unidimensionales. El siguiente es un ejemplo:
*/
int[ ] data = {4,6,3,8,9,3};
int donde = System.Array.IndexOf(data, 9); // == 4





