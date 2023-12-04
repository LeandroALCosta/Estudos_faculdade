using System;
using System.Reflection.Emit;
using System.Security.AccessControl;
class Program
{
    public static void Main(string[] args)
    {
        Fila filaInicia = new Fila(10);
        Fila filaMestrado = new Fila(10);

        int opc = 0;
        string nome;

        do{
            Console.WriteLine("1 - Inserir um aluno na fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("2 - Inserir um aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("3 - Remover um aluno da fila de bolsas de Iniciação Científica");
            Console.WriteLine("4 - Remover um aluno da fila de bolsas de Mestrado");
            Console.WriteLine("5 - Mostrar fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("6 - Mostrar fila de espera de bolsas de Mestrado");
            Console.WriteLine("7 - Pesquisar aluno na fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("8 - Pesquisar aluno na fila de espera de bolsas de Mestrado");
            Console.WriteLine("9 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Iniciação Científica");
            Console.WriteLine("10 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Mestrado");
            Console.WriteLine("11- Encerrar o programa");
            Console.Write("opção: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch(opc){
                case 1:
                    Console.Write("Aluno: ");
                    nome = Console.ReadLine();

                    filaInicia.inserir(nome);
                    Console.WriteLine("--adicionado--");
                    break;

                case 2:
                    Console.Write("Aluno: ");
                    nome = Console.ReadLine();

                    filaMestrado.inserir(nome);
                    Console.WriteLine("--adicionado--");
                    break;

                case 3:
                    Console.WriteLine(filaInicia.remover()+" removido da fila");
                    break;

                case 4:
                    Console.WriteLine(filaMestrado.remover()+" removido da fila");
                    break;

                case 5:
                    filaInicia.mostrar();
                    break;

                case 6:
                    filaMestrado.mostrar();
                    break;

                case 7:
                    Console.Write("Pesquisar: ");
                    nome = Console.ReadLine();
                    filaInicia.pesquisar(nome);
                    break;

                case 8:
                    Console.Write("Pesquisar: ");
                    nome = Console.ReadLine();
                    filaMestrado.pesquisar(nome);
                    break;

                case 9:
                    filaInicia.proximo();
                    break;

                case 10:
                    filaMestrado.proximo();
                    break;

                case 11:
                    break;

            }
        }while(opc != 11);
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
        int i = primeiro;
        Console.Write("[");
        while (i != ultimo)
        {
            Console.Write(array[i] + " ");
            i = (i + 1) % array.Length;
        }
        Console.WriteLine("]");
    }
    public void proximo()
    {
        Console.WriteLine(array[primeiro]+" será o proximo");
    }
    public void pesquisar(string x)
    {
        int i = primeiro;
        for( ;i < array.Length; i++)
        {
            if(x == array[i])
            Console.WriteLine("Esta na lista");
        }
    }
}
