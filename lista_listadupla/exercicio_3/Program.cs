using System;
class Celula
{
    private int elemento;
    private Celula prox;
    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public Celula Prox
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
class Lista
{
    private Celula primeiro, ultimo;
    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }
    public void InserirInicio(int x)
    {
        Celula tmp = new Celula(x);
        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;
        if (primeiro == ultimo)
        {
            ultimo = tmp;
        }
        tmp = null;
    }
    public void InserirFim(int x)
    {
        ultimo.Prox = new Celula(x);
        ultimo = ultimo.Prox;
    }
    public int RemoverInicio()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }
    public int RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula i;
        for (i = primeiro; i.Prox != ultimo; i = i.Prox) ;
        int elemento = ultimo.Elemento;
        ultimo = i;
        i = ultimo.Prox = null;
        return elemento;
    }
    public int Tamanho()
    {
        int tam = 0;
        for (Celula i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }
        return tam;
    }
    public void Inserir(int x, int pos)
    {
        int tamanho = Tamanho();
        if (pos < 0 || pos > tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            InserirInicio(x);
        }
        else if (pos == tamanho)
        {
            InserirFim(x);
        }
        else
        {
            Celula i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            Celula tmp = new Celula(x);
            tmp.Prox = i.Prox;
            i.Prox = tmp;
            tmp = i = null;
        }
    }
    public int Remover(int pos)
    {
        int elemento, tamanho = Tamanho();
        if (primeiro == ultimo || pos < 0 || pos >= tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            elemento = RemoverInicio();
        }
        else if (pos == tamanho - 1)
        {
            elemento = RemoverFim();
        }
        else
        {
            Celula i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            Celula tmp = i.Prox;
            elemento = tmp.Elemento;
            i.Prox = tmp.Prox;
            tmp.Prox = null;
            i = tmp = null;
        }
        return elemento;
    }
    public void Mostrar()
    {
        Console.Write("[");
        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
    public bool ProcurarMaior(out int maior, out int indice)
    {
        if (primeiro == ultimo)
        {
            maior = -1;
            indice = -1;
            return false;
        }
        maior = primeiro.Prox.Elemento;
        indice = 0;
        for (Celula i = primeiro; i.Prox != null; i = i.Prox)
        {
            if (maior < i.Elemento)
            {
                maior = i.Elemento;
            }
            indice++;
        }
        Console.WriteLine(maior);
        return true;
    }
}

class CelulaDupla
{
    private int elemento;
    private CelulaDupla prox, ant;
    public CelulaDupla(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
        this.ant = null;
    }
    public CelulaDupla()
    {
        this.elemento = 0;
        this.prox = null;
        this.ant = null;
    }
    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }
    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
class ListaDupla
{
    private CelulaDupla primeiro, ultimo;
    public ListaDupla()
    {
        primeiro = new CelulaDupla();
        ultimo = primeiro;
    }
    public void InserirInicio(int x)
    {
        CelulaDupla tmp = new CelulaDupla(x);
        tmp.Ant = primeiro;
        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;
        if (primeiro == ultimo)
        {
            ultimo = tmp;
        }
        else
        {
            tmp.Prox.Ant = tmp;
        }
        tmp = null;
    }
    public void InserirFim(int x)
    {
        ultimo.Prox = new CelulaDupla(x);
        ultimo.Prox.Ant = ultimo;
        ultimo = ultimo.Prox;
    }
    public int RemoverInicio()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        CelulaDupla tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        tmp.Prox = primeiro.Ant = null;
        tmp = null;
        return elemento;
    }
    public int RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        int elemento = ultimo.Elemento;
        ultimo = ultimo.Ant;
        ultimo.Prox.Ant = null;
        ultimo.Prox = null;
        return elemento;
    }
    public int Tamanho()
    {
        int tam = 0;
        for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }
        return tam;
    }
    public void Inserir(int x, int pos)
    {
        int tamanho = Tamanho();
        if (pos < 0 || pos > tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            InserirInicio(x);
        }
        else if (pos == tamanho)
        {
            InserirFim(x);
        }
        else
        {
            CelulaDupla i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            CelulaDupla tmp = new CelulaDupla(x);
            tmp.Ant = i;
            tmp.Prox = i.Prox;
            tmp.Ant.Prox = tmp.Prox.Ant = tmp;
            tmp = i = null;
        }
    }
    public int Remover(int pos)
    {
        int elemento, tamanho = Tamanho();
        if (primeiro == ultimo)
        {
            throw new Exception("Erro!");
        }
        else if (pos < 0 || pos >= tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            elemento = RemoverInicio();
        }
        else if (pos == tamanho - 1)
        {
            elemento = RemoverFim();
        }
        else
        {
            CelulaDupla i = primeiro.Prox;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            i.Ant.Prox = i.Prox;
            i.Prox.Ant = i.Ant;
            elemento = i.Elemento;
            i.Prox = i.Ant = null;
            i = null;
        }
        return elemento;
    }
    public void Mostrar()
    {
        Console.Write("[");
        for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
    public bool ProcurarMaiorD(out int maiorD, out int indiceD)
    {
        if(primeiro == ultimo)
        {
            maiorD = -1;
            indiceD = -1;
            return false;
        }
        maiorD = primeiro.Prox.Elemento;
        indiceD = 0;

        for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
        {
            if(maiorD < i.Elemento){
                maiorD = i.Elemento;
            }
            indiceD++;
        }
        Console.WriteLine(maiorD);
        return true;
    }
}

class Program
{
    static void Main()
    {
        Lista L = new Lista();
        int indice = 0;
        int maior = 0;

        L.InserirInicio(10);
        L.InserirInicio(11);
        L.InserirInicio(2);
        L.InserirInicio(1);
        L.InserirInicio(20);
        Console.WriteLine(L.ProcurarMaior(out maior, out indice));

        ListaDupla LD = new ListaDupla();
        int indiceD = 0;
        int maiorD = 0;

        LD.InserirInicio(10);
        LD.InserirInicio(11);
        LD.InserirInicio(2);
        LD.InserirInicio(1);
        LD.InserirInicio(21);
        Console.WriteLine(LD.ProcurarMaiorD(out maiorD, out indiceD));
    }
}
