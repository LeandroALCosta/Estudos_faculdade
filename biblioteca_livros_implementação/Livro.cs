class Livro{
    public string titulo_do_livro;
    public string autor_do_livro;
    public int ano_de_publicacao;
    public int numero_de_pagina;
    public string status;
    public static int cont = 0;
    public int id;
    public void Comecar(string titulo, string autor, int ano, int numero){
        titulo_do_livro = titulo;
        autor_do_livro = autor;
        ano_de_publicacao = ano;
        numero_de_pagina = numero;
        status = "disponivel";
        id = cont;
        cont++;
    }

    public void AlterarStatusEmprestado(){
        if (status == "disponivel"){
            status = "emprestado";
        }
    }
    public void AlterarStatusDisponivel(){
        if (status == "emprestado"){
            status = "disponivel";
        }
    }

    public void Exibir(){
        Console.WriteLine("Titulo: " + titulo_do_livro);
        Console.WriteLine("Autor: " + autor_do_livro);
        Console.WriteLine("Ano de lançamento: " + ano_de_publicacao);
        Console.WriteLine("Numero de paginas: " + numero_de_pagina);
        Console.WriteLine("Status do livro: " + status);
    }
}