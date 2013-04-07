using System; // System namespace. 

// TODO: Declare enum
enum TipoCuenta { Corriente, Ahorro }

class TestAccount
{
    static void Main()
    {
	// TODO: Write Code
        TipoCuenta goldCuenta;
        TipoCuenta platinumCuenta;
        goldCuenta = TipoCuenta.Corriente;
        platinumCuenta = TipoCuenta.Ahorro;

        Console.WriteLine("El tipo de cuenta del cliente es {0}", goldCuenta);
        Console.WriteLine("El tipo de cuenta del cliente es {0}", platinumCuenta);


    }
}

