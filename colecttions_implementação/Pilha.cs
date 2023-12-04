using System;
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
