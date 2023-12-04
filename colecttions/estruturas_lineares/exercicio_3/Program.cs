using System;
using System.ComponentModel;
using System.Runtime.Versioning;

class Program
{
    public static void Main()
    {
        int valor = -1;

        Console.Write("Qual a quantidade de elementos deseja ver? \nDigite um numero maior que 3: ");
        valor = Convert.ToInt32(Console.ReadLine());

        Pilha P = new Pilha(valor);

        int aux = 1;
        int atual = 0;


        for (int i = 0; i < valor; i++)
        {
            P.push(atual);
            int c = aux+atual;
            atual = aux;
            aux = c;
        }
        for(int i = 0; i < valor; i++)
        {
            Console.Write(P.pop()+" ");
        }

        // P.mostrar();

    }
}

class Pilha
{
    public int[] array;
    public int topo;
    public Pilha()
    {
        Inicializar(3);
    }
    public Pilha(int tamanho)
    {
        Inicializar(tamanho);
    }
    public void Inicializar(int tamanho)
    {
        this.array = new int[tamanho+1];
        this.topo = 0;
    }
    public void push(int x)
    {
        if (topo > array.Length)
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
        for (int i = array.Length; i > 0; i--)
        {
            Console.Write(array[i - 1]);
        }
    }
}