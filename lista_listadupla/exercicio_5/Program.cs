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
    public void InserirOrdenado(int x)
    {
        int indice = 0;

        if (primeiro == ultimo)
        {
            if (primeiro.Elemento > x)
            {
                InserirInicio(x);
            }
            else
            {
                InserirFim(x);
            }
        }
        for (Celula i = primeiro; i != ultimo; i = i.Prox)
        {
            if (i.Elemento > x)
            {
                Inserir(x, indice - 1);
            }
            indice++;
        }
    }
    public void UnirLista(Lista L1, Lista L2)
    {
        int a;
        for (Celula i = L1.primeiro.Prox; i != null; i = i.Prox)
        {
            a = L2.RemoverInicio();
            L1.InserirInicio(a);
        }
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
    public void MostrarD()
    {
        Console.Write("[");
        for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
    public void InserirOrdenadoD(int x)
    {
        int indice = 0;

        if (primeiro == ultimo)
        {
            if (primeiro.Elemento > x)
            {
                InserirInicio(x);
            }
            else
            {
                InserirFim(x);
            }
        }
        for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
        {
            if (i.Elemento > x)
            {
                Inserir(x, indice - 1);
            }
            indice++;
        }
    }
    public void UnirLista(ListaDupla LD1, ListaDupla LD2)
    {
        int a;
        for (CelulaDupla i = LD1.primeiro.Prox; i != null; i = i.Prox)
        {
            a = LD2.RemoverInicio();
            LD1.InserirInicio(a);
        }
    }
}

class Program
{
    public static void Main()
    {
        Lista L1 = new Lista();
        Lista L2 = new Lista();
        ListaDupla LD1 = new ListaDupla();
        ListaDupla LD2 = new ListaDupla();

        L1.InserirFim(1);
        L1.InserirFim(3);
        L1.InserirFim(5);
        L2.InserirFim(2);
        L2.InserirFim(4);
        L2.InserirFim(6);
        L1.UnirLista(L1,L2);
        L1.Mostrar();

        LD1.InserirFim(1);
        LD1.InserirFim(3);
        LD1.InserirFim(5);
        LD2.InserirFim(2);
        LD2.InserirFim(4);
        LD2.InserirFim(6);
        LD1.UnirLista(LD1,LD2);
        LD1.MostrarD();
    }
}