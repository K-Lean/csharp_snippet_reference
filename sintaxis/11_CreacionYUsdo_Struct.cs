using System;

// ENUM
public enum TipoCuenta {Corriente, Ahorro}

// STRUCT
public struct CuentaBancaria {
    public long cuentaNum;
    public decimal cuentaSaldo;
    public TipoCuenta cuentaTipo;
}


class Test
{
    static void Main()
    {
		// TODO: Test Structure
        CuentaBancaria goldCuenta;

        goldCuenta.cuentaTipo = TipoCuenta.Corriente;
        goldCuenta.cuentaSaldo = (decimal)3200.00;

        Console.Write("Introduzca el numero de cuenta: ");
        goldCuenta.cuentaNum = long.Parse(Console.ReadLine());


        Console.WriteLine("Numero de cuenta {0}", goldCuenta.cuentaNum);
        Console.WriteLine("Tipo de cuenta {0}", goldCuenta.cuentaTipo);
        Console.WriteLine("Saldo de cuenta {0}", goldCuenta.cuentaSaldo);
        




    }
}


