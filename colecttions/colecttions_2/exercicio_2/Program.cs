// 2 – Crie um programa que receba uma lista (use uma list da collection List<int>) de números
//     inteiros como entrada e use um Dictionary<int, int> para calcular a frequência de cada número
//     na lista. O dicionário deve mapear o número (int) para a quantidade de vezes que ele aparece
//     na lista. Posteriormente, forneça algumas funcionalidades ao programa, tais como:
//          a) Verificar se um determinado número consta no dicionário;
//          b) Dar a opção de se consultar quantos números distintos, constam no dicionário;
//          c) Imprimir todos os números e suas frequências de ocorrências.

using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<int> L = new List<int>();
        Dictionary<int, int> D = new Dictionary<int, int>();
        int op = -1;
        int numeroRepeticao = 1;
        int add = 0;
        int a = 0;

        do
        {
            Console.WriteLine("--------------------------------=--------------------------------");
            Console.WriteLine("1 - inserir numero");
            Console.WriteLine("2 - passar para o dicionario");
            Console.WriteLine("3 - verificar se um determinado número consta no dicionário");
            Console.WriteLine("4 - consultar quantos números distintos, constam no dicionário");
            Console.WriteLine("5 - imprimir todos os números e suas frequências de ocorrências");
            Console.WriteLine("0 - sair");
            Console.Write("Opçao: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("--------------------------------=--------------------------------");
                    Console.Write("Numero: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    L.Add(num);

                break;

                case 2:
                    L.Sort();
                    int[] lista;
                    lista = L.ToArray();

                    for (int j = 0; j < L.Count; j++)
                    {
                        if (D.ContainsKey(lista[j]))
                        {
                            D.TryGetValue(lista[j], out add);
                            D.Remove(lista[j], out a);
                            D.Add(lista[j], add + 1);
                        }

                        else
                        {
                            D.Add(lista[j], numeroRepeticao);
                        }
                    }
                    Console.WriteLine("--------------------------------=--------------------------------");
                    Console.WriteLine("Efetuado com sucesso");
                break;

                case 3:
                    Console.WriteLine("--------------------------------=--------------------------------");
                    Console.Write("Qual numero deseja buscar: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (D.ContainsKey(i))
                    {
                        Console.WriteLine("Contem!");
                    }
                    else
                    {
                        Console.WriteLine("Nao tem!");
                    }
                break;

                case 4:
                    Console.WriteLine("--------------------------------=--------------------------------");
                    Console.WriteLine(D.Count());
                break;

                case 5:
                    Console.WriteLine("--------------------------------=--------------------------------");
                    foreach (KeyValuePair<int, int> kv in D)
                    {
                        Console.WriteLine(kv.Key + "\t" + kv.Value);
                    }
                break;
            }

        } while (op != 0);
    }
}
