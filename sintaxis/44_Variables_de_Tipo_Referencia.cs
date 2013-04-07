VARIABLES DE TIPO REFERENCIA
----------------------------------------------------------


Es posible pasar variables referencia a métodos o fuera de ellos.

REFERENCIAS Y METODOS
----------------------------------------------------------------------------
Para pasar variables referencia como parámetros a métodos se puede emplear 
cualquiera de los tres mecanismos de llamada:
• Por valor
• Por referencia
• Parámetros de salida

El siguiente ejemplo muestra un método que pasa tres referencias de coordenada. 
La primera se pasa por valor, la segunda por referencia y la tercera es un 
parámetro de salida. El valor de devolución del método es una referencia de 
coordenada.

static coordinate Example(coordinate ca, ref coordinate cb,	out coordinate cc)
{
// ...
}

Paso de referencias por valor (El metodo Recibe una COPIA DE LA REFERENCIA)
------------------------------
Si se utiliza una variable de referencia como parámetro valor, el método recibe 
UNA COPIA DE LA REFERENCIA. Esto significa que, mientras dure la llamada, hay 
dos referencias que apuntan al mismo objeto. Por ejemplo, el siguiente código 
muestra los valores 3 y 4:

static void PassCoordinateByValue (coordenada c)
{
	c.x++; c.y++; //c referencing loc
}

coordinate loc = new coordinate( );
loc.x = 2; loc.y = 3;
PassCoordinateByValue (loc);
Console.WriteLine(loc.x + " , " + loc.y);

También significa que los cambios en el parámetro del método no afectan a la 
referencia que hace la llamada. Por ejemplo, el siguiente código muestra los 
valores 0 y 0:

static void PassCoordinateByValue (coordenada c)
{
	c = new coordinate( ); //c no longer referencing loc
	c.x = c.y = 22.22;
}

coordinate loc = new coordinate( );
PassCoordinateByValue (loc);
Console.WriteLine(loc.x + " , " + loc.y);



Paso de referencias por referencia (El metodo NO Recibe una copia de la referencia)
-----------------------------------
Si se utiliza una variable de referencia como parámetro ref, el método recibe 
la variable de referencia. Al contrario de lo que ocurre cuando se pasa por 
valor, en este caso hay sólo una referencia. El método no hace su propia copia. 
Esto significa que los cambios en el parámetro del método afectarán a la 
referencia que hace la llamada. Por ejemplo, el siguiente código muestra los 
valores 33.33 y 33.33:

static void PassCoordinateByRef(ref coordenada c)
{
	c = new coordinate ( );
	c.x = c.y = 33.33;
}

coordinate loc = new coordinate( );
PassCoordinateByRef(ref loc);
Console.WriteLine(loc.x + " , " + loc.y);

Paso de referencias por salida
-------------------------------
Si se utiliza una variable de referencia como parámetro out, the el método 
recibe la variable de referencia. Al contrario de lo que ocurre cuando se 
pasa por valor, en este caso hay sólo una referencia. El método no hace su 
propia copia. El paso por out es similar al paso por ref, salvo que el método 
debe tener el parámetro out. Por ejemplo, el siguiente código muestra los 
valores 44.44 y 44.44:

static void PassCoordinateByOut(out coordenada c)
{
	c = new coordinate( );
	c.x = c.y = 44.44;
}
coordenada loc = new coordinate( );
PassCoordinateByOut(out loc);
Console.WriteLine(loc.x + " , " + loc.y);

