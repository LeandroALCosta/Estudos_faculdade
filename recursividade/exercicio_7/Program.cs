class Program
{
    static void Main()
    {
        double[] vetor = new double[10];

        Console.WriteLine("Digite 10 números reais:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        InverterVetorRecursivamente(vetor, 0, 9);

        Console.WriteLine("\nVetor invertido:");

        foreach (double elemento in vetor)
        {
            Console.Write(elemento + " ");
        }

        Console.WriteLine();
    }
    static void InverterVetorRecursivamente(double[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            double temp = vetor[inicio];
            vetor[inicio] = vetor[fim];
            vetor[fim] = temp;

            InverterVetorRecursivamente(vetor, inicio + 1, fim - 1);
        }
    }
}