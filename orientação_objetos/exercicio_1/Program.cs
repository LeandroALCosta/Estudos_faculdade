class Program{
    static void Main(string[] args){
        Retangulo obj = new Retangulo();
        obj.Area(2,5);
        obj.Perimetro(2,5);
    }
}

class Retangulo{
    public double largura;
    public double altura;

    public void Area(double largura, double altura){
        double resul = largura*altura;
        Console.WriteLine(resul);
    }
    public void Perimetro(double largura, double altura){
        double resul = 2*(largura+altura);
        Console.WriteLine(resul);
    }
}