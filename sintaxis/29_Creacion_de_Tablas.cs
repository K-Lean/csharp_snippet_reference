// CREACION DE TABLAS

// Declarar una variable de tabla no es lo mismo
// que crear una tabla! 
// Para crear la tabla explícitamente hay que usar new.
// El valor implícito por defecto de los elementos de 
// una tabla es cero

// TABLA UNIDIMENSIONAL

int[] filaDeEnteros = new int[8]; // los elementos se inicializan en cero por defecto

// Creacion e Inicializacion 
int[] filaDeEnteros = new int[8]; { 1, 2, 3, 4, 5, 6, 7, 8 };

// es equivalente a hacer:
int[] otraFila = { 1, 2, 3, 4, 5, 6, 7, 8 }; // es interpretada como new int[8] y se inicializa 

