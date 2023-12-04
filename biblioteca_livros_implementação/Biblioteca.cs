class Biblioteca{
    Livro liv = new Livro();
    Cliente cli = new Cliente();
    Livro[] acervo = new Livro[10];
    Cliente [] listaC = new Cliente[20];
    public int i = 0;
    public int j = 0;

    public void AdcLivro(string titulo, string autor, int ano, int numero){

        liv.Comecar(titulo, autor, ano, numero);
        acervo[i] = liv;
        i++;

    }
    public void RemoverLivro(){
        
    }
    public void RegistrarCliente(string cliente, int identificacao){

        cli.Inicializar(cliente, identificacao);
        listaC[j] = cli;
        j++;

    }
    public void RemoverCliente(){}
    public void ExibirLivrosDisponiveis(){

        for(int i = 0; i < acervo.Length; i++){
            if(acervo[i] != null){
                acervo[i].Exibir();
            }
        }

    }
    public void ExibirClientes(){

        

    }
}
