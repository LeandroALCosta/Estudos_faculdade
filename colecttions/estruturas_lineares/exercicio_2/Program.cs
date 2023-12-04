using System;

class Lista
{
    private int[] array;
    private int[] arrayInvert;
    private int n;
    public Lista() { inicializar(0); }
    public Lista(int tamanho)
    {
        inicializar(tamanho);
    }
    private void inicializar(int tamanho)
    {
        this.array = new int[tamanho];
        this.arrayInvert = new int[tamanho];
        this.n = 0;
    }
    public void inserirInicio(int x)
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
    public void inserirFim(int x)
    {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    public void inserir(int x, int pos)
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
    public int removerInicio()
    {
        if (n == 0)
            throw new Exception("Erro!");
        int resp = array[0];
        n--;
        for (int i = 0; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }
    public int removerFim()
    {
        if (n == 0)
            throw new Exception("Erro!");
        n = n - 1;
        return array[n];
    }
    public int remover(int pos)
    {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        int resp = array[pos];
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

    public void pesquisar(int filme)
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
        int temp;

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

    public void removerFilme(int filme)
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

    public void somarTodos()
    {
        int soma = 0;

        for(int i = 0; i < n; i++)
        {
            soma += array[i];
        }

        Console.WriteLine("A soma de todos os valores é "+soma+".");
    }


    public void maiorMenor()
    {
        int maior = 0;
        int menor = 999999;

        for(int i = 0; i < n; i++)
        {
            if(array[i] > maior)
            {
                maior = array[i];
            }
            if(array[i] < menor)
            {
                menor = array[i];
            }
        }

        Console.WriteLine("O maior é "+maior+" e o menor é "+menor+".");
    }

    public void removerPar()
    {
        for(int i = 0; i < n; i++)
        {
            if(array[i] % 2 == 0)
            {
                array[i] = array[i+1];
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
        int num = 0;

        Console.Write("Qual o tamanho deseja que sua lista tenha? ");
        int tam = Convert.ToInt32(Console.ReadLine());
        Lista L = new Lista(tam);

        do
        {
            Console.WriteLine("1 - Insira um número na lista");
            Console.WriteLine("2 - Verifica se um número se encontra na lista");
            Console.WriteLine("3 - Exiba a soma de todos os números na lista");
            Console.WriteLine("4 - Exiba o maior e menor número na lista");
            Console.WriteLine("5 - Remova todos os números pares da lista");
            Console.WriteLine("6 - Exiba os números que estão na lista, após a remoção dos números pares"); 
            Console.WriteLine("7 - Inverta os elementos da lista");
            Console.WriteLine("8 - SAIR");

            Console.Write("opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    L.inserirInicio(num);
                    Console.WriteLine("Numero inserido com sucesso!");
                    break;

                case 2:
                    Console.Write("Numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    L.pesquisar(num);
                    Console.WriteLine("Numero encontrado com sucesso!");
                    break;

                case 3:
                    L.somarTodos();
                    break;

                case 4:
                    L.maiorMenor();
                    break;

                case 5:
                    L.removerPar();
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