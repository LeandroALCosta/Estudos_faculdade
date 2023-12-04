using System;

class Lista
{
    private string[] array;
    private string[] arrayInvert;
    private int n;
    public Lista() { inicializar(0); }
    public Lista(int tamanho)
    {
        inicializar(tamanho);
    }
    private void inicializar(int tamanho)
    {
        this.array = new string[tamanho];
        this.arrayInvert = new string[tamanho];
        this.n = 0;
    }
    public void inserirInicio(string x)
    {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = x;
        n++;
    }
    public void inserirFim(string x)
    {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    public void inserir(string x, int pos)
    {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--)
        {
            array[i] = array[i - 1];
        }
        array[pos] = x;
        n++;
    }
    public string removerInicio()
    {
        if (n == 0)
            throw new Exception("Erro!");
        string resp = array[0];
        n--;
        for (int i = 0; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }
    public string removerFim()
    {
        if (n == 0)
            throw new Exception("Erro!");
        n = n - 1;
        return array[n];
    }
    public string remover(int pos)
    {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        string resp = array[pos];
        n--;
        for (int i = pos; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }
    public void mostrar()
    {
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }

    public void pesquisar(string filme)
    {
        for (int i = 0; i < n; i++)
        {
            if (array[i] == filme)
            {
                Console.WriteLine("Filme encontrado!");
            }
        }
    }

    public void inverter()
    {
        string temp;

        for(int i = 0; i < n; i++)
        {
            arrayInvert[i] = array[n-i-1];
        }
        for(int i = 0; i < n; i++)
        {
            array[i] = arrayInvert[i];
        }
        Console.WriteLine("Lista invertida com sucesso!");
    }

    public void removerFilme(string filme)
    {
        for(int i = 0; i < n; i++)
        {
            if(array[i] == filme)
            {
                remover(i);
                Console.WriteLine("Filme "+filme+(" removido com sucesso!"));
            }
        }
    }

}

class Program
{
    public static void Main(string[] args)
    {
        int op = -1;
        int posi = -1;
        string filme = " ";

        Console.Write("Qual o tamanho deseja que sua lista tenha? ");
        int tam = Convert.ToInt32(Console.ReadLine());
        Lista L = new Lista(tam);

        do
        {
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme em uma posição específica da lista");
            Console.WriteLine("3 - Remover um filme da lista"); 
            Console.WriteLine("4 - Remover um filme em uma posição específica da lista"); 
            Console.WriteLine("5 - Pesquisar se um filme consta na lista"); 
            Console.WriteLine("6 - Listar todos os filmes da lista"); 
            Console.WriteLine("7 - Inverter a ordem dos filmes presentes na lista"); 
            Console.WriteLine("8 - Encerrar o programa"); 

            Console.Write("opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();

                    L.inserirInicio(filme);
                    Console.WriteLine("Filme inserido com sucesso!");
                    break;

                case 2:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();
                    Console.Write("Posição: ");
                    posi = Convert.ToInt32(Console.ReadLine());

                    L.inserir(filme, posi);
                    Console.WriteLine("Filme inserido com sucesso!");
                    break;

                case 3:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();

                    L.removerFilme(filme);
                    break;

                case 4:
                    Console.Write("Posição: ");
                    posi = Convert.ToInt32(Console.ReadLine());

                    filme = L.remover(posi);
                    Console.WriteLine("Filme " + filme + " removido com sucesso!");
                    break;

                case 5:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();

                    L.pesquisar(filme);
                    break;

                case 6:
                    L.mostrar();
                    break;

                case 7:
                    L.inverter();
                    break;
            }

        } while (op != 8);
    }
}