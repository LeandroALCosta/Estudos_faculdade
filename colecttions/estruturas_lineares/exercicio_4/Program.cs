using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite uma frase para iverte-la: ");
        string frase = Console.ReadLine();
        int tamanhoFrase = frase.Length;
        char[] vetorString = new char[tamanhoFrase];
        frase.CopyTo(vetorString);

        Pilha P = new Pilha(tamanhoFrase);

        for(int i = 0; i < tamanhoFrase; i++)
        {
            P.push(vetorString[i]);
        }

        for(int i = vetorString.Length; i > 0; i--)
        {
            Console.Write(vetorString[i-1]);
        }
    }
}

class Pilha
{
    private char[] array;
    private int topo;
    public Pilha()
    {
        Inicializar(5);
    }
    public Pilha(int tamanho)
    {
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho)
    {
        this.array = new char[tamanho];
        this.topo = 0;
    }
    public void push(char x)
    {
        if (topo >= array.Length)
            throw new Exception("Erro!");
        array[topo] = x;
        topo++;
    }
    public int pop()
    {
        if (topo == 0)
            throw new Exception("Erro!");
        topo = topo - 1;
        return array[topo];
    }
    public void mostrar()
    {
        Console.Write("[ ");
        for (int i = 0; i < topo; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }
}
