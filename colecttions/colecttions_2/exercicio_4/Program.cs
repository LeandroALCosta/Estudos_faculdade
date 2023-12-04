// 4 – Implemente um programa que mantenha um dicionário de sinônimos usando uma
//     SortedList<string, List<string>> onde a chave é uma palavra (string) e o valor é uma lista de
//     sinônimos (List<string>). Implemente as seguintes funcionalidades:
//          a) Adicionar uma nova palavra e seus sinônimos;
//          b) Pesquisar os sinônimos de uma palavra em específico;
//          c) Exibir o dicionário em ordem alfabética das palavras.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string, List<string>> SL = new SortedList<string, List<string>>();

        int op = -1;

        string palavra;
        string sinonimo;

        do
        {
            Console.WriteLine("1 - adicionar uma nova palavra e seus sinônimos");
            Console.WriteLine("2 - pesquisar os sinônimos de uma palavra especifica");
            Console.WriteLine("3 - exibir o dicionario");
            Console.Write("Opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:

                    Console.Write("Palavra que deseja incluir: ");
                    palavra = Console.ReadLine();

                    Console.Write("Digite os sinônimos (separados por vírgula): ");
                    string[] sinonimosVetor = Console.ReadLine().Split(',');

                    SL[palavra] = sinonimosVetor.ToList();

                    break;
                case 2:

                    Console.Write("Palavra que deseja pesquisar: ");
                    palavra = Console.ReadLine();

                    if(SL.TryGetValue(palavra, out List<string> sinonimosEncontrados)){
                        Console.WriteLine("Sinônimos de "+palavra+": ");
                        foreach (var sinoni in sinonimosEncontrados)
                        {
                            Console.WriteLine(sinoni);
                        }
                    }
                    else{
                        Console.WriteLine("Palavra nao encontrada");
                    }

                    break;
                case 3:

                    foreach (var kvp in SL)
                    {
                        Console.WriteLine(kvp.Key + ": " + string.Join(", ", kvp.Value));
                    }

                    break;
            }
        } while (op != 0);
    }
}