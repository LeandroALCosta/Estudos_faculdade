class Program
{
    static void Main()
    {
        int x, y;

        Console.Write("Digite o primeiro número inteiro: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        y = Convert.ToInt32(Console.ReadLine());

        int resultado = MDC(x, y);
        Console.WriteLine("O MDC de "+x+" e "+y+" é:"+resultado);
    }

        static int MDC(int x, int y)
    {
        if (y == 0)
        {
            return x;
        }
        else
        {
            return MDC(y, x % y);
        }
    }
}