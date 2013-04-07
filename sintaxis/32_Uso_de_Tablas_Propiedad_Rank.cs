// Definimos una tabla fila
long[ ] fila = new long[4];

// Definimos una tabla fila desde con tamaño
// ingresado por consola (en tiempo de ejecucion):
string s = Console.ReadLine();

// parseamos a un entero
int tamano = int.Parse(s);

long[ ] fila = new long[tamano];

// UN EJEMPLO MAS COMPLETO
System.Console.WriteLine("Escriba el número de filas: ");
string s1 = System.Console.ReadLine( );
int filas = int.Parse(s1);

System.Console.WriteLine("Escriba el número de columnas: ");
string s2 = System.Console.ReadLine( );
int columnas = int.Parse(s2);
...

int[,] matriz = new int[filas,columnas];


// También se puede emplear una mezcla de constantes de 
// tiempo de compilación y expresiones de tiempo de ejecución:
System.Console.WriteLine("Escriba el número de filas: ");
string s1 = System.Console.ReadLine( );
int filas = int.Parse(s1);
...

int[,] matriz = new int[filas,4];

// Hay una pequeña restricción, ya que no está permitido usar
// una expresión de tiempo de ejecución para especificar el 
// tamaño de una tabla en combinación con inicializadotes de tablas:
string s = System.Console.ReadLine( );
int tamano = int.Parse(s);
int[ ] data = new int[tamano]{0,1,2,3}; // No permitido