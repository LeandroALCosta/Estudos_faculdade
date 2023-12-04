/*Crie uma classe chamada "Livro" com os campos "título", "autor", "anoPublicação" e
“Gênero”. Adicione um método para exibir as informações completas do livro. Adicione um
segundo método que retorna true caso um determinado livro seja de ficção e false, caso
contrário*/

class Program{
    static void Main(string[] args){
        Livro obj = new Livro();
        obj.Começar("A volta dos que nao foram", "Leandro", "ficçao", 2021);
        obj.Exibir();
        obj.Verificar();
    }
    
}

class Livro{
    public string titulo;
    public string autor;
    public string genero;
    public int ano;

    public void Começar(string titulo, string autor, string genero, int ano){
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.ano = ano;
    }
    public void Exibir(){
        Console.WriteLine(titulo);
        Console.WriteLine(autor);
        Console.WriteLine(ano);
        Console.WriteLine(genero);
    }

    public void Verificar(){
        bool ver;
        if (genero == "ficçao"){
            ver = true;
        }
        else{
            ver = false;
        }
    }
}