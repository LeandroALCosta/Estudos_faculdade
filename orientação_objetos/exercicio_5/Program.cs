using System;

class Triangulo
{
    // Campos da classe
    private double lado1;
    private double lado2;
    private double lado3;

    // Construtor que recebe os valores dos lados como parâmetros
    public Triangulo(double lado1, double lado2, double lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    // Construtor sem parâmetros, com valores iniciais definidos
    public Triangulo()
    {
        lado1 = 1.0;
        lado2 = 1.0;
        lado3 = 1.0;
    }

    // Método para verificar se os lados formam um triângulo
    public bool VerificarTriangulo()
    {
        return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
    }

    // Método para calcular o perímetro do triângulo
    public double CalcularPerimetro()
    {
        return lado1 + lado2 + lado3;
    }

    // Método para definir os valores dos lados
    public void DefinirLados(double lado1, double lado2, double lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um triângulo com valores definidos no construtor
        Triangulo triangulo1 = new Triangulo(3.0, 4.0, 5.0);

        // Criando um triângulo com valores padrão
        Triangulo triangulo2 = new Triangulo();
        triangulo2.DefinirLados(2.0, 2.0, 2.0);

        Console.WriteLine("Triângulo 1:");
        Console.WriteLine($"Perímetro: {triangulo1.CalcularPerimetro()}");

        Console.WriteLine("\nTriângulo 2:");
        Console.WriteLine($"Perímetro: {triangulo2.CalcularPerimetro()}");
    }
}
