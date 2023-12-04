using System;

class Program
{
    public static void Main(string[] args)
    {

    }
}

class CelulaFlexivelFila
{
    private int elemento;
    private CelulaFlexivelFila prox;
    public CelulaFlexivelFila(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public CelulaFlexivelFila()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public CelulaFlexivelFila Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
class FilaFlexivel
{
    private CelulaFlexivelFila primeiro, ultimo;
    public FilaFlexivel()
    {
        primeiro = new CelulaFlexivelFila();
        ultimo = primeiro;
    }
    public void Inserir(int x)
    {
        ultimo.Prox = new CelulaFlexivelFila(x);
        ultimo = ultimo.Prox;
    }
    public int Remover()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        CelulaFlexivelFila tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }
    public void Mostrar()
    {
        Console.Write("[");
        for (CelulaFlexivelFila i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}
