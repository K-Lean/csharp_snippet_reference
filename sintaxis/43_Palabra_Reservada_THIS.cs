La palabra reservada this apunta implícitamente al objeto que está haciendo una 
llamada a un método de objeto.
En el siguiente código, la instrucción nombre = nombre no tendría ningún 
efecto, ya que el identificador nombre en el lado izquierdo de la asignación 
no se corresponde al campo privado de CuentaBancaria llamado nombre. Los dos 
identificadores se refieren al parámetro del método, que también se llama 
nombre.

class CuentaBancaria
{
	public void PoneNombre(string nombre)
	{
		nombre = nombre;
	}

	private string nombre;
}

_____________________________________________________________________________

Aviso: 
El compilador de C# no emite un aviso para alertar de este error.
_____________________________________________________________________________

Uso de la palabra reservada this
Este problema de referencia se puede resolver con la palabra reservada this, 
La palabra reservada this apunta al objeto actual para el que se hace la 
llamada al método.

Nota: Los métodos estáticos no pueden usar this, puesto que no se les llama 
empleando un objeto.

Cambio del nombre del parámetro
También es posible resolver el problema de referencia cambiando el nombre del
parámetro, como en el siguiente ejemplo:

class CuentaBancaria
{
	public void PoneNombre(string nuevoNombre)
	{
		nombre = nuevoNombre;
	}

	private string nombre;
}

Consejo:
En C# es muy habitual usar this para escribir constructores. 
El siguiente código muestra un ejemplo:

struct Reloj
{
	public Reloj(int hora, int minuto)
	{
		this.hora = hora;
		this.minuto = minuto;
	}

	private int hora, minuto;
}

Consejo:
La palabra clave this se usa también para encadenar llamadas. En la siguiente 
clase, los dos métodos devuelven el objeto que ha hecho la llamada:

class Libro
{
	public Libro PoneAutor(string autor)
	{
		this.autor = autor;
		return this;
	}

	public Libro PoneTitulo(string titulo)
	{
		this.titulo = titulo;
		return this;
	}

	private string autor, titulo;

}

La devolución de this permite encadenar llamadas a métodos, como se muestra 
a continuación:

class Uso
{
	static void Cadena(Libro bueno)
	{
		bueno.PoneAutor(" Fowler").PoneTitulo(" Refactoring");
	}

	static void NoCadena(Libro bueno)
	{
		bueno.PoneAutor("Fowler");
		bueno.PoneTitulo (" Refactoring");
	}
}

Nota:
Un método estático existe a nivel de clase y las llamadas a él se hacen 
en referencia a la clase y no a un objeto. Esto significa que un método 
estático no puede usar el operador this.