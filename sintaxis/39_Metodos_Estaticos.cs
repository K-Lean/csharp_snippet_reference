// Los métodos estaticos siguen teniendo accesso a todos los miembros 
// privados de una clase y pueden acceder a datos privados no estaticos
// por medio de una referencia a objeto. Ejemplo:

class Reloj {
	...

	private int hora, minuto;

	public static void Reset(Reloj t) // metodo estatico qu erecibe un objeto Reloj t
	{
		t.hora = 0;   // Ok
		t.minuto = 0; // Ok
		hora = 0;     // error al compilar
		minuto = 0;   // error al compilar

	}

}

