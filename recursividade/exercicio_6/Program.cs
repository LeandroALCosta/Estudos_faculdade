class Program
{
    static void Main()
    {
        int n;
        Console.Write("Digite um número inteiro positivo N: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n >= 0)
        {
            int resultado = Superfatorial(n);
            Console.WriteLine($"O superfatorial de {n} é {resultado}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }
    }
    static int Fatorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Fatorial(n - 1);
        }
    }

    static int Superfatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return Fatorial(n) * Superfatorial(n - 1);
        }
    }
}