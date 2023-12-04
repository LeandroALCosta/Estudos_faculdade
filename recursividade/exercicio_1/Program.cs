class Program{
    static void Main(string[] args){
        int n = 5;
        Console.WriteLine(SomaCubo(n));
    }

    public static int SomaCubo(int n){
        if(n == 1){
            return 1;
        }
        else{
            return (int)Math.Pow(n,3)+SomaCubo(n-1);
        }
    }
}