using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SomaSerie(4, 7, 2));
    }

    public static int SomaSerie(int i, int j, int k)
    {
        if (i > j){
            return 0;
        }
        else{
            return i + SomaSerie(i + k, j, k);
        }
    }
}