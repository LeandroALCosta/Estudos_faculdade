//* 5 – Crie um programa que permita que um usuário gerencie sua lista de filmes, usando a
//*     collection LinkedList<T>. Para tanto, o programa deverá apresentar para o usuário um menu
//*     com as seguintes opções:
//*          Menu:
//*          1 - Inserir um filme no final da lista
//*          2 - Inserir um filme depois de uma posição específica da lista
//*          3 - Inserir um filme antes de uma posição específica da lista
//*          4 - Remover o filme que estiver no final da lista
//*          5 - Pesquisar se um filme consta na lista
//*          6 - Listar todos os filmes da lista
//*          7 - Encerrar o programa
//*     O programa deverá ler a opção informada pelo usuário e executar a operação selecionada. Em
//*     seguida o programa deverá apresentar novamente o menu para o usuário, ler e executar a
//*     operação selecionada. Esse processo deverá ser repetido até que o usuário digite a opção 7.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> LL = new LinkedList<string>();
        string filme;
        string filmePos;
        int op = -1;

        do{

            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme depois de uma posição específica da lista");
            Console.WriteLine("3 - Inserir um filme antes de uma posição específica da lista");
            Console.WriteLine("4 - Remover o filme que estiver no final da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Encerrar o programa");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op){
                case 1:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();
                    LL.AddFirst(filme);
                break;
                case 2:
                    Console.Write("Qual filme deseja incluir: ");
                    filme = Console.ReadLine();
                    Console.WriteLine("Depois de qual filme: ");
                    filmePos = Console.ReadLine();

                    LinkedListNode<string> depois = LL.FindLast(filmePos);
                    LL.AddAfter(depois, filme);
                    Console.WriteLine("Filme adicionado com sucesso!");
                break;
                case 3:
                    Console.Write("Qual filme deseja incluir: ");
                    filme = Console.ReadLine();
                    Console.WriteLine("Antes de qual filme: ");
                    filmePos = Console.ReadLine();

                    LinkedListNode<string> antes = LL.FindLast(filmePos);
                    LL.AddBefore(antes, filme);
                    Console.WriteLine("Filme adicionado com sucesso!");
                break;
                case 4:
                    LL.RemoveLast();
                    Console.WriteLine("Filme removido com sucesso!");
                break;
                case 5:
                    Console.Write("Filme: ");
                    filme = Console.ReadLine();
                    if(LL.Contains(filme)){
                        Console.WriteLine("filme esta contido na lista");
                    }
                break;
                case 6:
                    foreach (var listFilme in LL)
                    {
                        Console.Write(listFilme+" ");
                    }
                    Console.WriteLine(" ");
                break;
            }
        }while(op != 7);
    }
}