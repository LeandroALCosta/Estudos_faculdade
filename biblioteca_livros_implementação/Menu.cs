using System.ComponentModel;

class Menu
{
    public void ExibirMenu(){
        Livro liv = new Livro();
        Cliente cli = new Cliente();
        Biblioteca bib = new Biblioteca();
        //------MENU------//
        int numero;
        do{

        Console.WriteLine("1 - Para adicionar um livro.");
        Console.WriteLine("2 - Para remover um livro.");
        Console.WriteLine("3 - Para emprestar livro.");
        Console.WriteLine("4 - Para devolver livro.");
        Console.WriteLine("5 - Para registrar um novo cliente.");
        Console.WriteLine("6 - Para remover um cliente.");
        Console.WriteLine("7 - Para exibir informaçoes de um livro.");
        Console.WriteLine("8 - Para exibir informaçoes de um cliente.");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Digite o numero da opção que deseja: ");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("--------------------------------------------");

        switch(numero){

            case 1:
                
                Console.Write("Informe o titulo do livro: ");
                string titulo = Console.ReadLine();
                Console.Write("Informe o autor: ");
                string autor = Console.ReadLine();
                Console.Write("Informe o ano de lançamento: ");
                int ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o numero de paginas: ");
                int pag = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Livro adicionado com sucesso!");
                Console.WriteLine("--------------------------------------------");

                bib.AdcLivro(titulo, autor, ano, pag);

            break;
            case 2:
                
            break;
            case 3:
                
            break;
            case 4:
                
            break;
            case 5:
                
            break;
            case 6:
                
            break;
            case 7:
                
                bib.ExibirLivrosDisponiveis();

            break;
            case 8:
                
            break;
            case 0:
                Console.WriteLine("Programa finalizado!!");
            break;


            default:
                Console.WriteLine("**Digite um valor que corresponda a uma das opçoes!**");
                Console.WriteLine(" ");
            break;
        }
        }while(numero != 0);

    }
}