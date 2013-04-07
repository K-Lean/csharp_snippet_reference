/**
En este ejemplo se emplea la instrucción throw para lanzar una excepción definida 
por el usuario, InvalidTimeException, si el tiempo analizado no es válido.
En general, las excepciones esperan como parámetro una cadena con un mensaje 
significativo que se puede mostrar o quedar registrado cuando se captura la excepción.
*/
if (minuto < 1 || minuto >= 60) {
	string fallo = minuto + "no es un minuto válido";
	throw new InvalidTimeException(fallo);
	// !!No alcanzado!!
}

/** 
Se puede utilizar una instrucción throw en un bloque catch para volver a lanzar 
el mismo objeto excepción, como en el siguiente ejemplo:
*/

catch (Exception capturada) {
	...
	throw capturada;
}

/** 
También es posible lanzar un nuevo objeto excepción de un tipo distinto:
*/
catch (IOException capturada) {
	...
	throw new FileNotFoundException(nombre_de_archivo);
}

/**
 En el ejemplo anterior, el objeto IOException y toda la información que
 contiene se pierde cuando la excepción se convierte en un objeto 
 FileNotFoundException. Es más conveniente ajustar la excepción, añadiendo 
 nueva información pero conservando la que tiene, como se ve en el siguiente 
 código:
*/
catch (IOException capturada) {
	...
	throw new FileNotFoundException(nombre_de_archivo, capturada);
}