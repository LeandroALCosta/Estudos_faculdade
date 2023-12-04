using System;

class Program
{
    public static void Main(string[] args)
    {
        char valor = ' ';
        PilhaFlexivel p = new PilhaFlexivel();
        PilhaFlexivel pI = new PilhaFlexivel();
        
        Console.Write("Frase/Palavra: ");
        string frase = Console.ReadLine();

        int tamanhoFrase = frase.Length;
        char[] vetorString = new char[tamanhoFrase];
        frase.CopyTo(vetorString);

        for(int i = 0; i < tamanhoFrase; i++)
        {
            p.Inserir(vetorString[i]);
        }
        while(p.Verify() == false){
            pI.Inserir(p.Remover());
        }
        
        p.Mostrar();
        while(p.Verify() == false){
            pI.Inserir(p.Remover());
        }
        pI.Mostrar();

        if(p == pI){
            bool i = true;
        }
    }
}


class CelulaFlexivelPilha
{
    private char elemento;
    private CelulaFlexivelPilha prox;
    public CelulaFlexivelPilha(char elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
    public CelulaFlexivelPilha()
    {
        this.elemento = ' ';
        this.prox = null;
    }
    public CelulaFlexivelPilha Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public char Elemento
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
    public void Inserir(char x)
    {
        CelulaFlexivelPilha tmp = new CelulaFlexivelPilha(x);
        tmp.Prox = topo;
        topo = tmp;
        tmp = null;
    }
    public char Remover()
    {
        if (topo == null)
            throw new Exception("Erro!");
        char elemento = topo.Elemento;
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
