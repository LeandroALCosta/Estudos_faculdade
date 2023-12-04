using System;

class Program
{
    public static void Main(string[] args)
    {
        PilhaFlexivel p = new PilhaFlexivel();
        FilaFlexivel f = new FilaFlexivel();
        int num = 0;

        Console.WriteLine("Digite (999) para parar de inserir");
        while(num != 999)
        {
            Console.Write("Numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num != 999)
            f.Inserir(num);
        }
        Console.Write("A lista esta assim: ");
        f.Mostrar();

        while(f.Verify() == false)
        {
            p.Inserir(f.Remover());
        }

        while(p.Verify() == false)
        {
            f.Inserir(p.Remover());
        }
        Console.Write("Invertida fica: ");
        f.Mostrar();
    }
}

class CelulaFlexivelPilha
{
    private int elemento;
    private CelulaFlexivelPilha prox;
    public CelulaFlexivelPilha(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public CelulaFlexivelPilha()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public CelulaFlexivelPilha Prox
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
class PilhaFlexivel
{
    private CelulaFlexivelPilha topo;
    public PilhaFlexivel()
    {
        topo = null;
    }
    public void Inserir(int x)
    {
        CelulaFlexivelPilha tmp = new CelulaFlexivelPilha(x);
        tmp.Prox = topo;
        topo = tmp;
        tmp = null;
    }
    public int Remover()
    {
        if (topo == null)
            throw new Exception("Erro!");
        int elemento = topo.Elemento;
        CelulaFlexivelPilha tmp = topo;
        topo = topo.Prox;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }
    public void Mostrar()
    {
        Console.Write("[ ");
        for (CelulaFlexivelPilha i = topo; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
    public bool Verify()
    {
        if(topo == null)
        return true;
        else{
            return false;
        }
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
    public bool Verify()
    {
        if(primeiro.Prox == null)
        return true;
        else{
            return false;
        }
    }
}
