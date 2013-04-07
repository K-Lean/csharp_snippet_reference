Conversión de tipos valor
------------------------------------------------------------------------------

C# permite las conversiones de datos implícitas y explícitas.


Conversiones implícitas
-----------------------
Para tipos valor hemos aprendido dos formas de convertir datos: 
conversión implícita y conversión explícita utilizando el operador 
de cast (molde).

Se dice que una conversión es implícita cuando un valor de un tipo se 
asigna a otro tipo. C# únicamente permite la conversión implícita para 
ciertas combinaciones de tipos, normalmente cuando el primer valor se 
puede convertir al segundo sin pérdida de datos. El siguiente ejemplo 
muestra una conversión implícita de datos de int a long:

		int a = 4;
		long b;
		b = a; // Conversión implícita de int a long


Conversiones explícitas
-----------------------
Los tipos valor se pueden convertir explícitamente usando el operador de cast, 
como en este ejemplo:

		int a;
		long b = 7;
		a = (int) b;


Excepciones
-----------
Al utilizar el operador de cast hay que tener en cuenta que pueden surgir 
problemas si la variable de destino no puede contener el valor. Si se detecta 
un problema durante una conversión explícita (como tratar de encajar el 
valor 9.999.999.999 en una variable int), C# puede lanzar una excepción 
(en este caso, OverflowException). Si se desea, se pueden utilizar bloques 
try-catch para capturar la excepción:

	try {
		a = checked((int) b);
	}
	catch (Exception) {
		Console.WriteLine("Problema en cast");
	}

En operaciones con enteros hay que emplear la palabra reservada checked o bien 
compilar utilizando la configuración adecuada del compilador, ya que de lo 
contrario no se efectuará la comprobación.

Clase System.Convert
--------------------
Las conversiones entre los distintos tipos base (como int, long y bool) 
se controlan mediante la clase System.Convert de .NET Framework. 
Normalmente no es necesario hacer llamadas a métodos de System.Convert, ya 
que el compilador realiza esas llamadas automáticamente.

Conversiones padre/hija
---------------------------------------------------------------------------

Bajo ciertas circunstancias, es posible convertir una referencia a un objeto 
de una clase hija a un objeto de su clase padre, y viceversa.

Conversión a referencia de clase padre
--------------------------------------
Las referencias a objetos de un tipo de clase se pueden convertir en referencias 
a otro tipo si una clase hereda directa o indirectamente de la otra.

Siempre es posible convertir una referencia a un objeto en una referencia a 
un objeto de una clase padre. Esta conversión se puede realizar de forma 
implícita (por asignación o como parte de una expresión) o explícita 
(utilizando el operador de cast).

En los siguientes ejemplos se usarán dos clases: Animal y Pájaro. 
Animal es la clase padre de Pájaro o, por decirlo de otro modo, 
Pájaro hereda de Animal.

En este ejemplo se declara una variable de tipo Animal y otra de tipo Pájaro:

	Animal a;
	Pajaro b = new Pajaro(...);

Supongamos ahora la siguiente asignación, en la que la referencia en b se 
copia a a:

	a = b;

La clase Pájaro hereda de la clase Animal y, por lo tanto, un método que 
esté en Animal estará también en Pájaro (es posible que la clase Pájaro 
haya sustituido algunos métodos de Animal para crear su propia versión de 
ellos, pero en cualquier caso el método estará presente en alguna forma). 

Como consecuencia, es posible asignar referencias a objetos Pájaro a variables 
que contengan referencias a objetos de tipo Animal.

En este caso, C# efectúa una conversión de tipo de Pájaro a Animal. 
Para hacer una conversión explícita de Pájaro a Animal se puede usar un 
operador de cast:

a = (Animal) b;

Este código dará exactamente el mismo resultado.

Conversión a referencia de clase hija
-------------------------------------

También es posible convertir una referencia a un tipo de clase hija, pero es 
necesario hacerlo de forma explícita con un operador de cast. Una conversión 
explícita se somete a una comprobación en tiempo de ejecución para garantizar 
que los tipos son compatibles, como se ve en el siguiente ejemplo:

	Pajaro b = (Pajaro) a; // Okay

Este código se compilará sin problemas. El operador de cast efectúa una 
comprobación en tiempo de ejecución para determinar si el objeto al que se 
apunta está realmente en la clase Pájaro, y si no lo está lanza la excepción 
InvalidCastException.

Si se intenta hacer una asignación a un tipo de clase hija sin emplear un 
operador de conversión, como en el siguiente código, el compilador mostrará 
el mensaje de error “Imposible convertir tipo ‘Animal’ a ‘Pájaro’ de forma 
implícita”.

	b = a; // No se compila

Como con cualquier otra excepción, se puede utilizar un bloque try-catch 
para capturar un error de conversión de tipo, como en el siguiente código:
	
	try {
		b = (Pajaro) a;
	}
	catch (InvalidCastException) {
		Console.WriteLine("No es Pájaro");
	}

El operador is
--------------
Es posible controlar los tipos incompatibles capturando la excepción 
InvalidCastException, pero hay otras formas de hacer frente a este problema, 
como el operador is.

El operador is se puede utilizar para probar el tipo del objeto sin efectuar 
una conversión. Este operador devuelve true si el valor de la izquierda no 
es null y es posible realizar un cast a la clase de la derecha sin que se 
lance una excepción; en caso contrario, devuelve false.

	if (a is Pajaro)
		b = (Pajaro) a; // No hay problema, ya que "a es Pajaro " devuelve true
	else
		Console.WriteLine("No es Pájaro");

Podemos pensar en las relaciones entre clases heredadas como si indicaran una 
relación “es un tipo de”, como en “Un pájaro es un tipo de animal”. 
Las referencias en la variable a deben ser referencias a objetos Animal, y b 
es un tipo de animal. Por supuesto, b es también un pájaro, pero un pájaro 
no es más que un caso especial de un animal. Lo contrario no es cierto: 
Un animal no es un tipo de pájaro; algunos animales son pájaros, pero no 
es cierto (true) que todos los animales sean pájaros.

Así, la siguiente expresión se puede leer como “Si a es un tipo de pájaro” 
o “Si a es un pájaro o un tipo derivado de pájaro”:

	if (a is Pajaro)

El operador as
--------------
Se puede utilizar el operador as para realizar conversiones entre tipos.

Ejemplo
La siguiente instrucción realiza una conversión de la referencia en a 
a un valor que apunta a una clase de tipo Pájaro, y el runtime comprueba 
automáticamente que la conversión está permitida.

	b = a as Pajaro;

Tratamiento de errores
----------------------
El operador as se diferencia del operador de cast por su forma de controlar 
los errores. Si en el ejemplo anterior no fuera posible convertir la 
referencia en la variable a en una referencia a un objeto de clase Pájaro, 
se almacenaría en b el valor null y el programa continuaría. El operador 
as nunca causa una excepción.

El código anterior se puede rescribir de la siguiente manera para que muestre 
un mensaje de error si no se puede hacer la conversión:

	Pajaro b = a as Pajaro;
	
	if (b == null)
	
	Console.WriteLine("No es Pájaro");

Aunque as nunca causa una excepción, cualquier intento de acceso por el valor 
convertido producirá una excepción NullReferenceException si ese valor es null. 
Por lo tanto hay que comprobar siempre el valor devuelto por as.

Conversiones y el tipo object
-----------------------------------------------------------------------------
Todos los tipos referencia se basan en el tipo object. Esto significa que es 
posible almacenar cualquier referencia en una variable de tipo object.

	El tipo object es la base para todas las clases
	El tipo object es la base para todos los tipos referencia.

Se puede asignar a object cualquier referencia
Puesto que todas las clases se basan directa o indirectamente en el tipo 
object, es posible asignar cualquier referencia a una variable de tipo object 
usando una conversión implícita o un operador de cast. El código siguiente 
muestra un ejemplo:

	object buey;
	buey = a;
	buey = (object) a;
	buey = a as object;

Se puede asignar cualquier variable object a cualquier referencia
-----------------------------------------------------------------
Es posible asignar un valor de tipo object a la referencia de cualquier 
otro objeto, siempre y cuando se aplique correctamente el operador cast. 
Hay que recordar que el sistema de tiempo de ejecución comprobará que el 
valor asignado es del tipo correcto. El código siguiente muestra un ejemplo:

	b = (Pajaro) buey;
	b = buey as Pajaro;

Los ejemplos anteriores se pueden escribir con comprobación completa de 
errores de la siguiente manera:

	try {
		b = (Pajaro) buey;
	}
	catch (InvalidCastException) {
		Console.WriteLine("No es posible convertir a Pájaro");
	}

	b = buey as Pajaro;

	if (b == null)
		Console.WriteLine("No es posible convertir a Pájaro");

El tipo object y el operador is
-------------------------------
Puesto que en último término todos los valores derivan de object, el 
operador is siempre devolverá true cuando compruebe si un valor es object.

	if (a is object) // Siempre devuelve true

Conversiones e interfaces
-------------------------------------------------------------------------
Cuando se trabaja con interfaces es posible utilizar los operadores as, is 
y de cast para hacer conversiones.

Por ejemplo, se puede declarar una variable de un tipo interfaz, como:

		IHashCodeProvider hcp;

Conversión de una referencia a una interfaz
-------------------------------------------
El operador de cast se puede usar para convertir la referencia al objeto 
en una referencia a una interfaz determinada:

		IHashCodeProvider hcp;
		hcp = (IHashCodeProvider) x;

Como ocurre en la conversión entre referencias de clase, el operador de 
cast producirá una excepción InvalidCastException si el objeto indicado 
no implementa la interfaz. Antes de aplicar el cast a un objeto hay que 
determinar si ese objeto es compatible con una interfaz, o bien usar un 
bloque try-catch para capturar la excepción.

Implementación de una interfaz
------------------------------
Se puede usar el operador is para determinar si un objeto es compatible 
con una interfaz. La sintaxis es la misma que la que se utiliza para 
clases:

	if (x is IHashCodeProvider) ...

Uso del operador as
-------------------
También se puede utilizar el operador as como alternativa a cast:
		
		IHashCodeProvider hcp;
		hcp = x as IHashCodeProvider;

Como ocurre en la conversión entre clases, el operador as devuelve null 
si la referencia convertida no es compatible con la interfaz.

Una vez convertida una referencia a una clase en una referencia a una 
interfaz, la nueva referencia puede acceder únicamente a miembros de esa 
interfaz, y no a los otros miembros públicos de la clase.

Ejemplo
Consideremos el siguiente ejemplo para ver cómo funciona la conversión de 
referencias en interfaces. Supongamos que hemos creado una interfaz llamada 
IVisual que especifica un método llamado Paint:

	interface IVisual
	{
		void Paint( );
	}

Supongamos que tenemos también una clase Rectangle que implementa la interfaz 
IVisual. Implementa por tanto el método Paint, aunque también puede definir 
sus propios métodos. En este ejemplo, Rectangle ha definido otro método llamado 
Move que no forma parte de IVisual.

Como era de esperar, es posible crear un Rectangle, r, y usar sus métodos 
Move y Paint. Incluso podemos referenciarlo a través de una variable IVisual, 
v. Sin embargo, a pesar del hecho de que tanto v como r apuntan al mismo 
objeto en la memoria, no es posible usar v para llamar al método Move porque 
no forma parte de la interfaz IVisual. 

El siguiente código ofrece algunos ejemplos:

		Rectangle r = new Rectangle( );
		r.Move( ); // Okay
		r.Paint( ); // Okay
		IVisual v = (IVisual) r;
		v.Move( ); // Not valid
		v. Paint( ); // Okay

Boxing y unboxing
-----------------
C# puede convertir tipos valor en referencias a objetos y referencias a 
objetos en tipos valor.

Sistema de tipos unificado
--------------------------
C# tiene un sistema unificado de tipos que permite convertir tipos valor en 
referencias de tipo object y referencias a objetos en tipos valor. Es posible 
convertir tipos valor en referencias de tipo object y viceversa.

De esta forma, los valores de tipos como int y bool se pueden tratar como 
valores simples en casi todos los casos. Normalmente ésta es la técnica más 
eficaz, ya que se evitan las complicaciones causadas por las referencias. 
Sin embargo, también hay un sistema que permite poner estos valores 
temporalmente en una “caja” (box) y utilizarlos como si fueran referencias 
cuando sea necesario.

Boxing
------
Las expresiones de tipos valor también se pueden convertir en valores de 
tipo object, y viceversa. Si se quiere convertir una variable de tipo valor 
en un tipo object, se asigna un objeto box para contener el valor y se copia 
éste en la caja. Este proceso se conoce con el nombre de boxing.

	int p = 123;
	object box;
	box = p; // Boxing (implicit)
	box = (object) p; // Boxing (explicit)

La operación de boxing puede ser implícita o explícita (con un cast a 
un objeto). El boxing se usa especialmente cuando se pasa un tipo valor 
a un parámetro de tipo object.

Unboxing
--------
Cuando un valor en un objeto se vuelve a convertir en un tipo valor, el 
valor se saca de la caja y se copia en la ubicación correspondiente. 
Este proceso se conoce con el nombre de unboxing.

	p = (int) box; // Unboxing

La operación de unboxing se tiene que hacer con un operador de cast explícito.
Si el valor en la referencia no es exactamente del mismo tipo que el cast, 
éste produce una excepción InvalidCastException.

Llamadas a métodos de object en tipos valor
-------------------------------------------
El hecho de que el boxing pueda ser implícito permite hacer llamadas a métodos 
del tipo object type en cualquier variable o expresión, aunque tengan tipos 
valor. El código siguiente muestra un ejemplo:

static void Show(object o)
{
	Console.WriteLine(o.ToString( ));
}
Show(42);

Este código funciona porque de forma implícita se está aplicando boxing al 
valor 42 para convertirlo en un parámetro object, y a continuación se hace 
una llamada al método ToString de este parámetro.

El resultado es el mismo que con el código siguiente:
	
	object o = (object) 42; // Boxing
	Console.WriteLine(o.ToString( ));

NOTA: ----------------------------------------------------------------------
Cuando se llama a métodos de Object directamente en un valor no se produce 
boxing. Por ejemplo, la expresión 42.ToString( ) no aplica boxing a 42 para 
convertirlo en un object. Esto se debe a que el compilador puede determinar 
estáticamente el tipo y decidir qué método llamar.
----------------------------------------------------------------------------