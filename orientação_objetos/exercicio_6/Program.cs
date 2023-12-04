class Funcionario
{
    private string nome;
    private string cargo;
    private double salario; 

    public Funcionario(string nome, string cargo, double salario = 0.0)
    {
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
    }
        public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: R${salario:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario("João", "Desenvolvedor");
        Funcionario funcionario2 = new Funcionario("Maria", "Gerente", 5000.0);

        funcionario1.ExibirInformacoes();
        Console.WriteLine();
        funcionario2.ExibirInformacoes();
    }
}
