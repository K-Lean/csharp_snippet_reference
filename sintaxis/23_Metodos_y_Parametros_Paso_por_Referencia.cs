static void AddOne(ref int x)
{
	x++;
}

static void Main( )
{
	int k = 6;
	AddOne(ref k);
	Console.WriteLine(k); // Muestra el valor 7
}