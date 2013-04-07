// DECLARACION TABLA DE RANGO UNO (FILA)

tipo[ ] nombre; // Permitida

tipo nombre[ ]; // No permitida e C#
tipo[4] nombre; // Tampoco permitida en C#

// DECLARACION TABLA DE RANGO DOS (Cuadrilla)
tipo[ , ] nombre;

// Nota: En la declaracion de una variable de tabla no 
// se incluye la longitud de las dimensiones.

// Recorrer una Tabla Fila (dimension 1)
int[] fila = new int[4] {1, 2, 3, 4};

for (int i = 0; i < fila.Length; i++) {
	Console.WriteLine(fila[i]);
}

// La propiedad Length es la longitud total de la tabla, 
// independientemente de su rango. Para determinar la 
// longitud de una dimensión concreta se puede utilizar
// el método GetLength como se muestra a continuación:

// Recorrer una Tabla cuadrilla (dos dimensiones)

for (int r = 0; r < cuadr.GetLength(0); r++) {
	
	for (int c = 0; c < cuadr.GetLength(1); c++) {
	
		Console.WriteLine(cuadr[r,c]);
	
	}
}
