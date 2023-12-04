using System;

class Program
{
    public static void Main(string[] args)
    {
        Fila f = new Fila(10);
        Pilha p = new Pilha(10);

        int valor;
        Console.WriteLine("Digite 10 numeros.");
        for(int i = 0; i < 10; i++)
        {
            Console.Write("numero: ");
            valor = Convert.ToInt32(Console.ReadLine());
            f.inserir(valor);
        }

        for(int i = 0; i < 10; i++)
        {
            p.push(f.remover());
        }
        for(int i = 0; i < 10; i++)
        {
            f.inserir(p.pop());
        }
        Console.Write("A fila ao contraio fica: ");
        f.mostrar();
    }
}

class Fila
{
    private int[] array;
    private int primeiro, ultimo;
    public Fila() { inicializar(5); }
    public Fila(int tamanho)
    {
        inicializar(tamanho);
    }
    public void inicializar(int tamanho)
    {
        array = new int[tamanho + 1];
        primeiro = ultimo = 0;
    }
    public void inserir(int x)
    {
        if (((ultimo + 1) % array.Length) == primeiro)
            throw new Exception("Erro!");
        array[ultimo] = x;
        ultimo = (ultimo + 1) % array.Length;
    }
    public int remover()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        int resp = array[primeiro];
        primeiro = (primeiro + 1) % array.Length;
        return resp;
    }
    public void mostrar()
    {
        int i = primeiro;
        Console.Write("[");
        while (i != ultimo)
        {
            Console.Write(array[i] + " ");
            i = (i + 1) % array.Length;
        }
        Console.WriteLine("]");
    }
}

class Pilha
{
    private int[] array;
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
        this.array = new int[tamanho];
        this.topo = 0;
    }
    public void push(int x)
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
