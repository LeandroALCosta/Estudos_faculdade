using System;

class Program
{
    public static void Main(string[] args)
    {
        Lista LF = new Lista();
        Lista LFinvertida = new Lista();

        int temp;
        LF.InserirInicio(1);
        LF.InserirInicio(2);
        LF.InserirInicio(3);
        LF.InserirInicio(4);
        LF.InserirInicio(5);

        LF = LF.Inverter(LF);
        LF.Mostrar();
    }
}

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
    public Lista Inverter(Lista LF){
        int tam = Tamanho();
        int temp;
        Lista LFinvertida = new Lista();
        for(int i = 0; i < tam; i++)
        {
            temp = LF.RemoverFim();
            LFinvertida.InserirFim(temp);
        }
        return LFinvertida;
    }
}

// class Lista
// {
//     private int[] array;
//     private int n;
//     public Lista()
//     {
//         Inicializar(0);
//     }
//     public Lista(int tamanho)
//     {
//         Inicializar(tamanho);
//     }
//     private void Inicializar(int tamanho)
//     {
//         this.array = new int[tamanho];
//         this.n = 0;
//     }

//     public void inserirInicio(int x)
//     {
//         if (n >= array.Length)
//             Console.WriteLine("lista vazia");

//         for (int i = n; i > 0; i--)
//         {
//             array[i] = array[i - 1];
//         }
//         array[0] = x;
//         n++;
//     }

//     public int removerFimUma()
//     {
//         int temp = array.Length;
//         return array[temp - 1];
//     }
//     public int removerInicioUma()
//     {
//         return array[0];
//     }

//     public int remover(int pos)
//     {
//         return array[pos];
//     }
//     public void inserir(int x, int pos)
//     {
//         array[pos] = x;
//     }

//     public void inverter()
//     {
//         int tempFim;
//         int tempInicio;
//         int j = 0;
//         int k = array.Length;

//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             if (j == 0)
//             {
//                 tempFim = removerFimUma();
//                 tempInicio = removerInicioUma();
//                 inserir(tempFim, j);
//                 inserir(tempInicio, k - 1);
//                 j++;
//                 k--;
//             }
//             if (j != k)
//             {
//                 tempFim = remover(k - 1);
//                 tempInicio = remover(j);
//                 inserir(tempFim, j);
//                 inserir(tempInicio, k - 1);
//                 j++;
//                 k--;
//             }
//             else
//             {
//                 Console.WriteLine("Erro");
//             }
//         }
//     }
//     public void mostrar()
//     {
//         Console.Write("[");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine("]");
//     }
// }