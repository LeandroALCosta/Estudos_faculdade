using System;

class Program
{
    public static void Main(string[] args)
    {
        int op = -1;
        int valor = -1;
        PilhaFlexivel p = new PilhaFlexivel();
        PilhaFlexivel pI = new PilhaFlexivel();
        
        Console.WriteLine("Digite 0 para parar de inserir");
        do{
            Console.Write("numero: ");
            valor = Convert.ToInt32(Console.ReadLine());
            p.Inserir(valor);
        }while(valor != 0);
        p.Mostrar();
        while(p.Verify() == false){
            pI.Inserir(p.Remover());
        }
        pI.Mostrar();
    }
}


class CelulaFlexivelPilha
{
    private int elemento;
    private CelulaFlexivelPilha prox;
    public CelulaFlexivelPilha(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public CelulaFlexivelPilha()
    {
        this.elemento = 0;
        this.prox = null;
    }
    public CelulaFlexivelPilha Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
class PilhaFlexivel
{
    private CelulaFlexivelPilha topo;
    public PilhaFlexivel()
    {
        topo = null;
    }
    public void Inserir(int x)
    {
        CelulaFlexivelPilha tmp = new CelulaFlexivelPilha(x);
        tmp.Prox = topo;
        topo = tmp;
        tmp = null;
    }
    public int Remover()
    {
        if (topo == null)
            throw new Exception("Erro!");
        int elemento = topo.Elemento;
        CelulaFlexivelPilha tmp = topo;
        topo = topo.Prox;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }
    public bool Verify()
    {
        if(topo == null)
        return true;
        else{
            return false;
        }
    }
    public void Mostrar()
    {
        Console.Write("[ ");
        for (CelulaFlexivelPilha i = topo; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}
