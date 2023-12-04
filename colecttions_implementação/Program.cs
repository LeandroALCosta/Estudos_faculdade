class Program
{
    static void Main()
    {
        int opcao = -1;
        int x1, x2, x3;

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("==== PILHA LINEAR ====");
                Pilha pilha = new Pilha(6);
                
                pilha.push(1);
                pilha.push(7);
                pilha.push(9);
                pilha.mostrar();
                x1 = pilha.pop();
                x2 = pilha.pop();
                x3 = pilha.pop();
                Console.Write(x1 + ", " + x2 + ", " + x3);
                break;
            case 2:
                Console.WriteLine("==== PILHA FLEXÍVEL ====");
                PilhaFlexivel pilhaFlexivel = new PilhaFlexivel();
                
                pilhaFlexivel.Inserir(1);
                pilhaFlexivel.Inserir(7);
                pilhaFlexivel.Inserir(9);
                pilhaFlexivel.Mostrar();
                x1 = pilhaFlexivel.Remover();
                x2 = pilhaFlexivel.Remover();
                x3 = pilhaFlexivel.Remover();
                Console.Write(x1 + ", " + x2 + ", " + x3);
                break;
            case 3:
                Console.WriteLine("==== LISTA LINEAR ====");
                Lista lista = new Lista(6);
                
                lista.inserirInicio(1);
                lista.inserirFim(7);
                lista.inserirFim(9);
                lista.inserirInicio(3);
                lista.inserir(8, 3);
                lista.inserir(4, 2);
                lista.mostrar();
                x1 = lista.removerInicio();
                x2 = lista.removerFim();
                x3 = lista.remover(2);
                Console.Write(x1 + ", " + x2 + ", " + x3);
                lista.mostrar();
                break;
            case 4:
                Console.WriteLine("==== FILA CIRCULAR ====");
                Fila fila = new Fila();
                
                fila.inserir(1);
                fila.inserir(3);
                fila.inserir(5);
                fila.inserir(7);
                fila.inserir(9);
                //fila.inserir(2);
                fila.mostrar();
                x1 = fila.remover();
                x2 = fila.remover();
                fila.inserir(4);
                fila.inserir(6);
                x3 = fila.remover();
                fila.inserir(8);
                fila.mostrar();
                Console.Write(x1 + ", " + x2 + ", " + x3);
                break;
            case 5:
                Console.WriteLine("==== FILA FLEXÍVEL ====");
                FilaFlexivel filaFlexivel = new FilaFlexivel();
                
                filaFlexivel.Inserir(1);
                filaFlexivel.Inserir(3);
                filaFlexivel.Inserir(5);
                filaFlexivel.Inserir(7);
                filaFlexivel.Inserir(9);
                //filaFlexivel.inserir(2);
                filaFlexivel.Mostrar();
                x1 = filaFlexivel.Remover();
                x2 = filaFlexivel.Remover();
                filaFlexivel.Inserir(4);
                filaFlexivel.Inserir(6);
                x3 = filaFlexivel.Remover();
                filaFlexivel.Inserir(8);
                filaFlexivel.Mostrar();
                Console.Write(x1 + ", " + x2 + ", " + x3);
                break;
        }









    }
}
