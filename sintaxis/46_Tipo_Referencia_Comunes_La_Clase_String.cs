CLASE STRING
------------------------------------------------------------

Métodos, operadores y propiedades comunes de String
----------------------------------------------------

Corchetes [ ]
-------------
Para extraer un solo carácter en una posición determinada de una cadena de 
caracteres utilizando el nombre de la cadena seguido del índice entre corchetes 
([ and ]). Este proceso es similar al empleado para tablas. El índice del 
primer carácter de una cadena es cero.

El siguiente código muestra un ejemplo:

string s = "Alphabet";
char firstchar = s[2]; // 'p'

No está permitido emplear los corchetes para asignar un carácter, ya que las 
cadenas son inmutables. Si se intenta asignar un carácter a una cadena de esta 
forma, como en el ejemplo, se producirá un error en tiempo de compilación.

s[2] = '*'; // Not valid

Método Insert
-------------
Para insertar caracteres en una variable se puede emplear el método Insert, 
que devuelve una nueva string con un valor especificado insertado en la 
posición indicada de la cadena. Este método recibe dos parámetros: la posición
de inicio de la inserción y la cadena que se desea insertar.

El siguiente código muestra un ejemplo:

string s = "¡Me encanta C!";
s = s.Insert(2, " Sharp ");
Console.WriteLine(s); // ¡Me encanta C Sharp!

Propiedad Length
----------------
La propiedad Length devuelve un entero que representa la longitud de la 
cadena:

string msj = "Hello";
int slen = msj.Length; // 5

Esta propiedad cuenta a partir de 1, 2, 3, ...Length.

Método Copy
-----------
El método de clase Copy copia una cadena para crear otra nueva; es decir, 
hace un duplicado de una cadena especificada.

El siguiente código muestra un ejemplo:

string s1 = "Hello";
string s2 = String.Copy(s1);

Método Concat
-------------
El método de clase Concat crea una nueva cadena de caracteres a partir de una 
o más cadenas o de objetos representados como cadenas.

El siguiente código muestra un ejemplo:

string s3 = String.Concat("a", "b", "c", "d", "e", "f", "g");

El operador + está sobrecargado para cadenas, por lo que el ejemplo anterior 
se podría reescribir de la siguiente manera:

string s = "a" + "b" + "c" + "d" + "e" + "f" + "g";
Console.WriteLine(s);

Método Trim
-----------
El método Trim elimina todos los caracteres indicados o escribe espacios 
entre el principio y el final de una cadena.

El siguiente código muestra un ejemplo:

string s = " Hello ";
s = s.Trim( );
Console.WriteLine(s); // "Hello"

Métodos ToUpper y ToLower
-------------------------
Los métodos ToUpper y ToLower devuelven una cadena con todos los caracteres 
cambiados a mayúsculas y minúsculas, respectivamente:

string sText = "El camino al triunfo ";
Console.WriteLine(sText.ToUpper( )); // EL CAMINO AL TRIUNFO
Console.WriteLine(sText.ToLower( )); // el camino al triunfo

Comparaciones de cadenas de caracteres
--------------------------------------
Se pueden utilizar los operadores == and != sobre variables string para 
comparar sus contenidos.

Método Equals
-------------
La clase System.String contiene un método llamado Equals que se puede 
emplear para comparar dos cadenas y ver si son iguales. El método devuelve 
un valor bool que es true si las cadenas son iguales y false en caso 
contrario. Es un método sobrecargado y se puede usar como método de 
instancia o como método estático. Ambas formas se muestran en el siguiente 
ejemplo.

string s1 = "Bienvenidos";
string s2 = "Bienvenidos";

if (s1.Equals(s2))
	Console.WriteLine("Las cadenas son iguales");

if (String.Equals(s1,s2))
	Console.WriteLine("Las cadenas son iguales");

Método Compare
---------------
El método Compare compara dos cadenas desde el punto de vista léxico; 
es decir, compara las cadenas según su ordenación. Compare puede devolver 
los siguientes valores:

• Un entero negativo si la primera cadena es anterior a la segunda
• 0 si las cadenas son iguales
• Un entero positivo si la primera cadena es posterior a la segunda

string s1 = "Supercalifragilístico";
string s2 = "Velocípedo";

int comp = String.Compare(s1,s2); // Entero negativo

Por definición, cualquier cadena (incluyendo una cadena vacía) es 
siempre mayor que una referencia null, y dos referencias null se consideran 
iguales al compararlas.

Compare es un método sobrecargado. Existe una versión con tres parámetros, 
el tercero de los cuales es un valor bool si en la comparación se deben 
ignorar las mayúsculas. El siguiente ejemplo muestra una comparación que 
no distingue mayúsculas y minúsculas:

s1 = "repollo";
s2 = "Repollo";
comp = String.Compare(s1, s2, true); // Ignorar mayúsculas

Opciones locales de Compare
---------------------------
Existen versiones sobrecargadas del método Compare que permiten comparar 
cadenas a partir de ordenaciones en distintos idiomas. Esto es útil cuando 
se escriben aplicaciones para un mercado internacional. Este aspecto no 
está incluido en el temario de este curso. Para más información, busque 
“espacio de nombres System.Globalization” y “clase CultureInfo” en los 
documentos de ayuda del SDK de .NET Framework.

Operadores de comparación en String
-----------------------------------
Los operadores == and != están sobrecargados para la clase String. 
Estos operadores sirven para examinar los contenidos de cadenas de 
caracteres.

string a = "Test";
string b = "Test";
if (a == b) ... // Devuelve true

Los siguientes operadores y métodos son equivalentes:

	• El operador == es equivalente al método String.Equals.
	• El operador!= es equivalente al método!String.Equals.

Los otros operadores relacionales (<, >, <= y >=) no están sobrecargados 
para la clase String.

