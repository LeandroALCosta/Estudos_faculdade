class Cliente{
    public int i = 0;
    public string nome_do_cliente;
    public int numero_da_identificacao;
    public Livro[] lista_de_livros_emprestados = new Livro[4];

    public void Inicializar (string cliente, int identificacao){
        nome_do_cliente = cliente;
        numero_da_identificacao = identificacao;
    }

    public void Emprestar(Livro obj){
        lista_de_livros_emprestados[i] = obj;
        i++;
        obj.AlterarStatusEmprestado();
    }
    public void Devolver(Livro obj, int o){
        lista_de_livros_emprestados[o] = null;
        i--;
        obj.AlterarStatusDisponivel();
    }

    public void Exibir(){
        Console.WriteLine("Numero do cliente: " + nome_do_cliente);
        Console.WriteLine("Numero do : " + numero_da_identificacao);
        for(int i = 0; i < 4; i++){
            if(lista_de_livros_emprestados[i] != null){
                Console.Write(lista_de_livros_emprestados[i]);
            }
        }
    }
}