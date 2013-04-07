// Los parámetros de salida son útiles cuando se quiere devolver 
// valores de un método por medio de un parámetro sin tener que 
// asignar a éste un valor inicial.

static void DemoOut(out int p)
{
	// ...
}

int n;
DemoOut(out n);

// En el cuerpo del método al que se hace la llamada no hay ninguna 
// indicación al contenido del parámetro de salida, por lo que éste 
// se trata como si fuera una variable local sin asignar. El valor 
// del parámetro out se tiene que asignar dentro del método.