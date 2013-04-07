/**
Los inicializadores de tablas se ejecutan de izquierda
a derecha y pueden incluir llamadas a métodos y expresiones 
complejas, como en el siguiente ejemplo:
*/
int[ ] data = new int[4]{a, b( ), c*d, e( )+f( )};

// Los inicializadores de tablas también se pueden utilizar
// para inicializar tablas de estructuras:
struct Date { ... }
Date [ ] dates = new Date[2];

/** 
Esta notación abreviada sólo se puede emplear cuando 
se inicializa una tabla como parte de la declaración 
de una variable de tabla, y no como parte de una instrucción
de asignación normal.
*/
int[ ] data1 = new int[4]{0, 1, 2, 3}; // Permitido (forma Explicita)
int[ ] data2 = {0, 1, 2, 3}; // Permitido (forma implicita)

data2 = new int[4]{0, 1, 2, 3}; // Permitido
data2 = {0, 1, 2, 4}; // No permitido

/**
Cuando se inicializan tablas hay que inicializar 
explícitamente todos los elementos de la tabla. 
No es posible dejar que sólo algunos elementos 
adopten su valor cero predeterminado:
*/
int[ ] data3 = new int[2]{}; // No permitido
int[ ] data4 = new int[2]{42}; // No Permitido
int[ ] data5 = new int[2]{42,42}; // Permitido

// CREACION E INICIALIZACION TABLA MULTIDIMENSIONAL

// forma Explicita:
int[,] cuadr = new int[2,3] {
	{5, 4, 3},
	{2, 1, 0}
};

// forma Implicita
int[,] cuadr = {
	{5, 4, 3},
	{2, 1, 0}
};