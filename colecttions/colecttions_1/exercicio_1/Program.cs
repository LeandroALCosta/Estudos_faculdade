using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> o = new List<string>();
            int op = -1;

            string nome = " ";
            int posicao = -1;

            while (op != 9)
            {
                Console.WriteLine("Hola, vamos gerenciar su lista de películas. ");

                Console.WriteLine("1 - Inserir um filme no final da lista");
                Console.WriteLine("2 - Inserir um filme em uma posição específica da lista");
                Console.WriteLine("3 - Remover um filme da lista");
                Console.WriteLine("4 - Remover um filme em uma posição específica da lista");
                Console.WriteLine("5 - Pesquisar se um filme consta na lista");
                Console.WriteLine("6 - Listar todos os filmes da lista");
                Console.WriteLine("7 - Inverter a ordem dos filmes presentes na lista");
                Console.WriteLine("8 - Ordenar a lista de filmes");
                Console.WriteLine("9 - Encerrar o programa");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Deseja adicionar qual filme a sua lista?");
                        nome = Console.ReadLine();
                        o.Add(nome);
                        Console.WriteLine("Filme adicionado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Deseja adicionar qual filme a sua lista?");
                        nome = Console.ReadLine();
                        Console.WriteLine("Em qual posição?");
                        posicao = Convert.ToInt32(Console.ReadLine());
                        o.Insert(posicao, nome);
                        Console.WriteLine("Filme adicionado com sucesso na posição " + posicao);
                        break;

                    case 3:
                        Console.WriteLine("Deseja remover qual filme a sua lista?");
                        nome = Console.ReadLine();
                        o.Remove(nome);
                        Console.WriteLine("Filme removido com sucesso!");
                        break;

                    case 4:
                        Console.WriteLine("Quaal a posição do filme que deseja remover?");
                        posicao = Convert.ToInt32(Console.ReadLine());
                        o.RemoveAt(posicao);
                        Console.WriteLine("Filme removido com sucesso!");
                        break;

                    case 5:
                        Console.WriteLine("Quaal filme deseja ver se tem na sua lista?");
                        nome = Console.ReadLine();
                        if (o.Contains(nome))
                            Console.WriteLine("Filme encontrado!");
                        else
                        {
                            Console.WriteLine("Nao esta na lita!");
                        }

                        break;

                    case 6:
                        foreach (string a in o)
                        {
                            Console.WriteLine(a);
                        }
                        break;

                    case 7:
                        o.Reverse();
                        break;

                    case 8:
                        o.Sort();
                        break;

                }
            }
        }
    }
}