using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> o = new List<int>();
            int op = -1;

            int numero = -1;
            int posicao = -1;

            while (op != 9)
            {
                Console.WriteLine("Hola, vamos gerenciar su lista de películas. ");

                Console.WriteLine("1 - Insira um número na lista");
                Console.WriteLine("2 - Verifica se um número se encontra na lista");
                Console.WriteLine("3 - Exiba a soma de todos os números na lista");
                Console.WriteLine("4 - Exiba o maior número na lista");
                Console.WriteLine("5 - Exiba o menor número na lista");
                Console.WriteLine("6 - Remova todos os números pares da lista");
                Console.WriteLine("7 - Exiba os números que estão na lista, após a remoção dos números pares");
                Console.WriteLine("8 - Inverta os elementos da lista");
                Console.WriteLine("9 - Encerrar o programa");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Deseja adicionar qual numero a sua lista?");
                        numero = Convert.ToInt32(Console.ReadLine());
                        o.Add(numero);
                        Console.WriteLine("Numero adicionado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Qual numero deseja buscar?");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if(o.Contains(numero)){
                            Console.WriteLine("Numero encontrado!");
                        }
                        else{
                            Console.WriteLine("Numero nao encontrado!");
                        }
                        break;

                    case 3:
                        foreach(int e in o){
                            numero += e;
                        }
                        Console.WriteLine("A soma de todos será: "+numero);
                        break;

                    case 4:
                        
                        

                        break;

                    case 5:
                        Console.WriteLine("Qual Numero deseja ver se tem na sua lista?");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if (o.Contains(numero))
                            Console.WriteLine("Numero encontrado!");
                        else
                        {
                            Console.WriteLine("Nao esta na lita!");
                        }

                        break;

                    case 6:
                        foreach (int f in o)
                        {
                            Console.WriteLine(f);
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