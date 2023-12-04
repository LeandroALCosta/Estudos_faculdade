using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        int resultado = CalcularNumeroDePell(n);
        Console.WriteLine("P("+n+") = "+resultado);
    }

    public static int CalcularNumeroDePell(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return 2 * CalcularNumeroDePell(n - 1) + CalcularNumeroDePell(n - 2);
        }
    }
}
