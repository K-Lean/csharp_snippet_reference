// Nos da el termino n de la serie de fibonacci
static ulong Fibonacci(ulong n) {
	if (n <= 2)
		return 1;
	else
		return Fibonacci(n-1) + Fibonacci(n-2);

}