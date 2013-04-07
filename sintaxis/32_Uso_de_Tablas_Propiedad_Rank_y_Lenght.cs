/**
La propiedad Rank es un valor entero de sólo lectura 
que indica la dimensión de una tabla. 
Por ejemplo, en el código:
*/

int[ ] uno = new int[a];
int[,] dos = new int[a,b];
int[,,] tres = new int[a,b,c];

// los valores resultantes del rango son los siguientes:
uno.Rank == 1
dos.Rank == 2
tres.Rank == 3

// La propiedad Length es un valor entero de sólo lectura 
// que indica la longitud total de una tabla. P
// or ejemplo, dadas las tres declaraciones anteriores de 
// tablas, los valores resultantes de la longitud son:
uno.Length == a
dos.Length == a * b
tres.Length == a * b * c