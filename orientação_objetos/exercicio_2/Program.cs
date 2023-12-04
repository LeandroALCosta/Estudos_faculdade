class Program{
    static void Main(string[] args){
        ContaBancaria obj = new ContaBancaria();
        int op;
        do{
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Ver saldo");
        Console.WriteLine("4 - Sair");
        op = Convert.ToInt32(Console.ReadLine());
        

        switch(op){
            case 1:
                obj.Depositar();
            break;
            case 2:
                obj.Sacar();
            break;
            case 3:
                obj.SaldoAtual();
            break;

        }
        }while(op != 0);
    }
}

class ContaBancaria{
    private double saldo;
    public string titular;

    public void Depositar(){
        Console.WriteLine("Quanto deseja depositar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        this.saldo = valor;
    }    
    public void Sacar(){
        Console.WriteLine("Quanto deseja sacar: ");
        double valor = Convert.ToInt32(Console.ReadLine());
        if(valor <= saldo){
            saldo -= valor;
        }
        else{
            Console.WriteLine("Nao a saldo disponivel neste valor!");
        }
    }    
    public void SaldoAtual(){
        Console.WriteLine(saldo);
    }    

}