using System;
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
