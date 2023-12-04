using System;

class Program
{
    public static void Main(string[] args)
    {
        Fila f = new Fila(10);
        int op = -1;

        string nome;

        do
        {
            Console.WriteLine("1 - adicionar alguem a fila");
            Console.WriteLine("2 - atender um cliente");
            Console.WriteLine("3 - exibir a quantidade de clientes na fila");
            Console.WriteLine("4 - proximo a ser atendido");
            Console.Write("opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.Write("ADD: ");
                    nome = Console.ReadLine();
                    f.inserir(nome);
                    Console.WriteLine("---adicionado---");
                    break;
                case 2:
                    Console.WriteLine(f.remover()+" sua vez!");
                    break;
                case 3:
                    f.quantidade();
                    break;
                case 4:
                    f.mostrar();
                    break;
            }
        }while(op!= 0);
    }
}

class Fila
{
    private string[] array;
    private int primeiro, ultimo;
    public Fila() { inicializar(5); }
    public Fila(int tamanho)
    {
        inicializar(tamanho);
    }
    public void inicializar(int tamanho)
    {
        array = new string[tamanho + 1];
        primeiro = ultimo = 0;
    }
    public void inserir(string x)
    {
        if (((ultimo + 1) % array.Length) == primeiro)
            throw new Exception("Erro!");
        array[ultimo] = x;
        ultimo = (ultimo + 1) % array.Length;
    }
    public string remover()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        string resp = array[primeiro];
        primeiro = (primeiro + 1) % array.Length;
        return resp;
    }
    public void mostrar()
    {
        Console.WriteLine("Proximo -> "+array[primeiro]);
    }
    public void quantidade()
    {
        int i = ultimo-primeiro;
        Console.WriteLine(i+" pessoas na fila");
        
    }
}
