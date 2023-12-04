// 3 – Faça um programa que mantenha um ranking de jogadores de um jogo usando uma
//     SortedList<int, string> onde a chave é a pontuação do jogador (int) e o valor é o nome do jogador
//     (string). Implemente as seguintes funcionalidades:
//          a) Adicionar um novo jogador e sua pontuação;
//          b) Verificar a pontuação de um jogador em específico;
//          c) Remover um jogador, bem como sua pontuação;
//          d) Exibir o ranking de pontuação de forma crescente.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        SortedList<int, string> SL = new SortedList<int, string>();
        int op = -1;
        int pontos = -1;
        string nome;

        do
        {
            Console.WriteLine("--------------------------------=--------------------------------");
            Console.WriteLine("1 - inserir novo jogador e sua pontuaçao");
            Console.WriteLine("2 - verificar pontuaçao de um jogador");
            Console.WriteLine("3 - remover jogador");
            Console.WriteLine("4 - exibir ranking");
            Console.WriteLine("0 - sair");
            Console.Write("Opçao: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Nome do jogador: ");
                    nome = Console.ReadLine();
                    Console.Write("Pontuaçao: ");
                    pontos = Convert.ToInt32(Console.ReadLine());

                    SL.Add(pontos, nome);
                    Console.WriteLine("Adicionado com sucesso!");
                    break;

                case 2:
                    Console.Write("Nome do jogador que deseja buscar: ");
                    nome = Console.ReadLine();
                    bool jogadorEncontrado = false;

                    foreach (var kvp in SL)
                    {
                        if (kvp.Value == nome)
                        {
                            Console.WriteLine("Pontuação do(a) " + nome + ": " + kvp.Key);
                            jogadorEncontrado = true;
                            break;
                        }
                    }

                    break;

                case 3:
                    Console.Write("Nome do jogador que deseja remover: ");
                    nome = Console.ReadLine();

                    int jogadorRemove = -1;
                    foreach (var kvp in SL)
                    {
                        if (kvp.Value == nome)
                        {
                            jogadorRemove = kvp.Key;
                            break;
                        }
                    }

                    if (jogadorRemove != -1)
                    {
                        SL.Remove(jogadorRemove);
                        Console.WriteLine("Jogador removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Jogador não encontrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Ranking:");

                    for (int i = SL.Count - 1; i >= 0; i--)
                    {
                        var jogador = SL.ElementAt(i);
                        Console.WriteLine($"{jogador.Value}: {jogador.Key} pontos");
                    }
                    break;
            }
        } while (op != 0);

    }
}