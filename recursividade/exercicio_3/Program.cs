class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        if (n % 2 == 0)
        {
            Console.WriteLine("O número deve ser ímpar para calcular o fatorial duplo.");
        }
        else
        {
            int resultado = FatorialDuplo(n);
            Console.WriteLine(n+"!! = "+resultado);
        }
    }

    public static int FatorialDuplo(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * FatorialDuplo(n - 2);
        }
    }
}
