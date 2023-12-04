using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string linha;
        string[] dados;
        int add = 0;
        int numRepeti = 1;
        int a = 0;
        int op = -1;

        Dictionary<string, int> D = new Dictionary<string, int>();

        try
        {
            StreamReader arqLeit = new StreamReader("text.txt", Encoding.UTF8);
            linha = arqLeit.ReadLine();
            linha = Regex.Replace(linha, "[,.]", "");
            linha = linha.ToLower();
            dados = linha.Split(' ');

            for (int i = 0; i < dados.Length; i++)
            {
                if (D.ContainsKey(dados[i]))
                {
                    D.TryGetValue(dados[i], out add);
                    D.Remove(dados[i], out a);
                    D.Add(dados[i], add + 1);
                }

                else
                {
                    D.Add(dados[i], numRepeti);
                }
            }
            do
            {
                Console.WriteLine("1 - buscar palavra");
                Console.WriteLine("2 - ver quantas palavras distintas possuem o dicionario");
                Console.WriteLine("3 - ver palavras e frequencia");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual palavra deseja buscar: ");
                        string i = Console.ReadLine();
                        if (D.ContainsKey(i))
                        {
                            Console.WriteLine("Contem!");
                        }
                        else
                        {
                            Console.WriteLine("Nao tem!");
                        }
                    break;
                    
                    case 2:
                        Console.WriteLine(D.Count());
                    break;

                    case 3:
                        foreach (KeyValuePair<string, int> kv in D)
                        {
                            Console.WriteLine(kv.Key + "\t" + kv.Value);
                        }
                    break;
                }
            } while (op != 0);
        }
        catch
        {
            Console.WriteLine("Deu ruim");
        }
    }
}