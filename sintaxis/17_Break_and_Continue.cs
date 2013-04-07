/**  La instrucción break salta fuera de una iteración
 *   La instrucción continue salta a la siguiente iteración.
 *   Una instrucción break abandona la instrucción switch, 
 *   while, do, for o foreach más próxima. Una instrucción 
 *   continue comienza una nueva iteración de la instrucción 
 *   while, do, for o foreach más próxima.
*/

int i = 0;
while (true) {
	Console.WriteLine(i);
	i++;
	if (i < 10) 
		continue;
	else 
		break;
}
