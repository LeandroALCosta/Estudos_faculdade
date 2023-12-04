using System.Diagnostics;
using System.IO;

class Program
{
    public static void Main()
    {
        //------------------------INICIALIZANDO------------------------//
        Metodos metodos = new Metodos();
        Stopwatch stopwatch = new Stopwatch();
        int[] vetorMil = new int[1000];
        int[] vetorDezMil = new int[10000];
        int[] vetorCemMil = new int[100000];
        int[] vetorDuzentosMil = new int[200000];

        //------------------------MEDIAS-ordenado------------------------//
        float ordenadoMediaMilBolha = 0, ordenadoMediaDezMilBolha = 0, ordenadoMediaCemMilBolha = 0, ordenadoMediaDuzentosMilBolha = 0, ordenadoMediaMilInserção = 0, ordenadoMediaDezMilInserção = 0, ordenadoMediaCemMilInserção = 0, ordenadoMediaDuzentosMilInserção = 0, ordenadoMediaMilSeleção = 0, ordenadoMediaDezMilSeleção = 0, ordenadoMediaCemMilSeleção = 0, ordenadoMediaDuzentosMilSeleção = 0;
        //------------------------MEDIAS-desordenado------------------------//
        float desordenadoMediaMilBolha = 0, desordenadoMediaDezMilBolha = 0, desordenadoMediaCemMilBolha = 0, desordenadoMediaDuzentosMilBolha = 0, desordenadoMediaMilInserção = 0, desordenadoMediaDezMilInserção = 0, desordenadoMediaCemMilInserção = 0, desordenadoMediaDuzentosMilInserção = 0, desordenadoMediaMilSeleção = 0, desordenadoMediaDezMilSeleção = 0, desordenadoMediaCemMilSeleção = 0, desordenadoMediaDuzentosMilSeleção = 0;
        //------------------------MEDIAS-ordenadoInverso------------------------//
        float ordenadoInversoMediaMilBolha = 0, ordenadoInversoMediaDezMilBolha = 0, ordenadoInversoMediaCemMilBolha = 0, ordenadoInversoMediaDuzentosMilBolha = 0, ordenadoInversoMediaMilInserção = 0, ordenadoInversoMediaDezMilInserção = 0, ordenadoInversoMediaCemMilInserção = 0, ordenadoInversoMediaDuzentosMilInserção = 0, ordenadoInversoMediaMilSeleção = 0, ordenadoInversoMediaDezMilSeleção = 0, ordenadoInversoMediaCemMilSeleção = 0, ordenadoInversoMediaDuzentosMilSeleção = 0;

        //------------------------INCLUINDO_VALORES------------------------//
        metodos.InicializandoBolha(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilBolha, ref ordenadoMediaDezMilBolha, ref ordenadoMediaCemMilBolha, ref ordenadoMediaDuzentosMilBolha, ref ordenadoInversoMediaMilBolha, ref ordenadoInversoMediaDezMilBolha, ref ordenadoInversoMediaCemMilBolha, ref ordenadoInversoMediaDuzentosMilBolha, ref desordenadoMediaMilBolha, ref desordenadoMediaDezMilBolha, ref desordenadoMediaCemMilBolha, ref desordenadoMediaDuzentosMilBolha);
        metodos.InicializandoInserção(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilInserção, ref ordenadoMediaDezMilInserção, ref ordenadoMediaCemMilInserção, ref ordenadoMediaDuzentosMilInserção, ref ordenadoInversoMediaMilInserção, ref ordenadoInversoMediaDezMilInserção, ref ordenadoInversoMediaCemMilInserção, ref ordenadoInversoMediaDuzentosMilInserção, ref desordenadoMediaMilInserção, ref desordenadoMediaDezMilInserção, ref desordenadoMediaCemMilInserção, ref desordenadoMediaDuzentosMilInserção);
        metodos.InicializandoSeleção(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilSeleção, ref ordenadoMediaDezMilSeleção, ref ordenadoMediaCemMilSeleção, ref ordenadoMediaDuzentosMilSeleção, ref ordenadoInversoMediaMilSeleção, ref ordenadoInversoMediaDezMilSeleção, ref ordenadoInversoMediaCemMilSeleção, ref ordenadoInversoMediaDuzentosMilSeleção, ref desordenadoMediaMilSeleção, ref desordenadoMediaDezMilSeleção, ref desordenadoMediaCemMilSeleção, ref desordenadoMediaDuzentosMilSeleção);

        string diretorio = Directory.GetCurrentDirectory() + "/texto.txt";
        using (StreamWriter writer = new StreamWriter(diretorio, append: true))
        {
            string data = $"{ordenadoMediaMilBolha / 10},{ordenadoMediaDezMilBolha/10}, {ordenadoMediaCemMilBolha/10}, {ordenadoMediaDuzentosMilBolha/10}, {ordenadoMediaMilInserção/10}, {ordenadoMediaDezMilInserção/10}, {ordenadoMediaCemMilInserção/10}, {ordenadoMediaDuzentosMilInserção/10}, {ordenadoMediaMilSeleção/10}, {ordenadoMediaDezMilSeleção/10}, {ordenadoMediaCemMilSeleção/10}, {ordenadoMediaDuzentosMilSeleção/10},{desordenadoMediaMilBolha/10}, {desordenadoMediaDezMilBolha/10}, {desordenadoMediaCemMilBolha/10}, {desordenadoMediaDuzentosMilBolha/10}, {desordenadoMediaMilInserção/10}, {desordenadoMediaDezMilInserção/10}, {desordenadoMediaCemMilInserção/10}, {desordenadoMediaDuzentosMilInserção/10}, {desordenadoMediaMilSeleção/10}, {desordenadoMediaDezMilSeleção/10}, {desordenadoMediaCemMilSeleção/10}, {desordenadoMediaDuzentosMilSeleção/10},{ordenadoInversoMediaMilBolha/10}, {ordenadoInversoMediaDezMilBolha/10}, {ordenadoInversoMediaCemMilBolha/10}, {ordenadoInversoMediaDuzentosMilBolha/10}, {ordenadoInversoMediaMilInserção/10}, {ordenadoInversoMediaDezMilInserção/10}, {ordenadoInversoMediaCemMilInserção/10}, {ordenadoInversoMediaDuzentosMilInserção/10}, {ordenadoInversoMediaMilSeleção/10}, {ordenadoInversoMediaDezMilSeleção/10}, {ordenadoInversoMediaCemMilSeleção/10}, {ordenadoInversoMediaDuzentosMilSeleção/10}";
            writer.WriteLine(data);
        }
    }
}

class Metodos
{
    public void CompletarVetorOrdenadoCrescente(int[] a, int[] b, int[] c, int[] d)
    {
        for (int i = 0; i < 1000; i++)
        {
            a[i] = i + 1;
        }
        for (int i = 0; i < 10000; i++)
        {
            b[i] = i + 1;
        }
        for (int i = 0; i < 100000; i++)
        {
            c[i] = i + 1;
        }
        for (int i = 0; i < 200000; i++)
        {
            d[i] = i + 1;
        }
    }
    public void CompletarVetorOrdenadoDecrescente(int[] a, int[] b, int[] c, int[] d)
    {
        int j = 0;
        int k = 0;
        int y = 0;
        int l = 0;
        for (int i = 1000; i >= 0; i--)
        {
            if (i > 0)
                a[j] = i;
            j++;
        }
        for (int i = 10000; i >= 0; i--)
        {
            if (i > 0)
                b[k] = i;
            k++;
        }
        for (int i = 100000; i >= 0; i--)
        {
            if (i > 0)
                c[y] = i;
            y++;
        }
        for (int i = 200000; i >= 0; i--)
        {
            if (i > 0)
                d[l] = i;
            l++;
        }
    }
    public void CompletarVetorDesordenado(int[] a, int[] b, int[] c, int[] d)
    {
        Random random = new Random();

        for (int i = 0; i < 1000; i++)
        {
            a[i] = random.Next(1000);
        }
        for (int i = 0; i < 10000; i++)
        {
            b[i] = random.Next(10000);
        }
        for (int i = 0; i < 100000; i++)
        {
            c[i] = random.Next(100000);
        }
        for (int i = 0; i < 200000; i++)
        {
            d[i] = random.Next(200000);
        }
    }
    public void InicializandoSeleção(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilSeleção, ref float ordenadoMediaDezMilSeleção, ref float ordenadoMediaCemMilSeleção, ref float ordenadoMediaDuzentosMilSeleção, ref float ordenadoInversoMediaMilSeleção, ref float ordenadoInversoMediaDezMilSeleção, ref float ordenadoInversoMediaCemMilSeleção, ref float ordenadoInversoMediaDuzentosMilSeleção, ref float desordenadoMediaMilSeleção, ref float desordenadoMediaDezMilSeleção, ref float desordenadoMediaCemMilSeleção, ref float desordenadoMediaDuzentosMilSeleção)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilSeleção += Seleção(a, "ordenado", "Seleção");
            ordenadoMediaDezMilSeleção += Seleção(b, "ordenado", "Seleção");
            ordenadoMediaCemMilSeleção += Seleção(c, "ordenado", "Seleção");
            ordenadoMediaDuzentosMilSeleção += Seleção(d, "ordenado", "Seleção");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilSeleção += Seleção(a, "decrescente", "Seleção");
            ordenadoInversoMediaDezMilSeleção += Seleção(b, "decrescente", "Seleção");
            ordenadoInversoMediaCemMilSeleção += Seleção(c, "decrescente", "Seleção");
            ordenadoInversoMediaDuzentosMilSeleção += Seleção(d, "decrescente", "Seleção");
        }
        // ---------Seleção----------
        for (int z = 0; z < 10; z++)
        {
            int[] e = new int[a.Length];
            int[] f = new int[b.Length];
            int[] g = new int[c.Length];
            int[] h = new int[d.Length];
            for (int i = 0; i < a.Length; i++)
            {
                e[i] = a[i];
                Console.WriteLine(e[i]);
            }
            for (int j = 0; j < b.Length; j++)
            {
                f[j] = b[j];
            }
            for (int k = 0; k < c.Length; k++)
            {
                g[k] = c[k];
            }
            for (int l = 0; l < d.Length; l++)
            {
                h[l] = d[l];
            }
            desordenadoMediaMilSeleção += Seleção(e, "desordenado", "Seleção");
            desordenadoMediaDezMilSeleção += Seleção(f, "desordenado", "Seleção");
            desordenadoMediaCemMilSeleção += Seleção(g, "desordenado", "Seleção");
            desordenadoMediaDuzentosMilSeleção += Seleção(h, "desordenado", "Seleção");
        }
    }
    public void InicializandoInserção(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilInserção, ref float ordenadoMediaDezMilInserção, ref float ordenadoMediaCemMilInserção, ref float ordenadoMediaDuzentosMilInserção, ref float ordenadoInversoMediaMilInserção, ref float ordenadoInversoMediaDezMilInserção, ref float ordenadoInversoMediaCemMilInserção, ref float ordenadoInversoMediaDuzentosMilInserção, ref float desordenadoMediaMilInserção, ref float desordenadoMediaDezMilInserção, ref float desordenadoMediaCemMilInserção, ref float desordenadoMediaDuzentosMilInserção)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilInserção += Inserção(a, "ordenado", "Inserção");
            ordenadoMediaDezMilInserção += Inserção(b, "ordenado", "Inserção");
            ordenadoMediaCemMilInserção += Inserção(c, "ordenado", "Inserção");
            ordenadoMediaDuzentosMilInserção += Inserção(d, "ordenado", "Inserção");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilInserção += Inserção(a, "decrescente", "Inserção");
            ordenadoInversoMediaDezMilInserção += Inserção(b, "decrescente", "Inserção");
            ordenadoInversoMediaCemMilInserção += Inserção(c, "decrescente", "Inserção");
            ordenadoInversoMediaDuzentosMilInserção += Inserção(d, "decrescente", "Inserção");
        }
        // ---------Inserção----------
        for (int z = 0; z < 10; z++)
        {
            int[] e = new int[a.Length];
            int[] f = new int[b.Length];
            int[] g = new int[c.Length];
            int[] h = new int[d.Length];
            for (int i = 0; i < a.Length; i++)
            {
                e[i] = a[i];
                Console.WriteLine(e[i]);
            }
            for (int j = 0; j < b.Length; j++)
            {
                f[j] = b[j];
            }
            for (int k = 0; k < c.Length; k++)
            {
                g[k] = c[k];
            }
            for (int l = 0; l < d.Length; l++)
            {
                h[l] = d[l];
            }
            desordenadoMediaMilInserção += Inserção(e, "desordenado", "Inserção");
            desordenadoMediaDezMilInserção += Inserção(f, "desordenado", "Inserção");
            desordenadoMediaCemMilInserção += Inserção(g, "desordenado", "Inserção");
            desordenadoMediaDuzentosMilInserção += Inserção(h, "desordenado", "Inserção");
        }
    }
    public void InicializandoBolha(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilBolha, ref float ordenadoMediaDezMilBolha, ref float ordenadoMediaCemMilBolha, ref float ordenadoMediaDuzentosMilBolha, ref float ordenadoInversoMediaMilBolha, ref float ordenadoInversoMediaDezMilBolha, ref float ordenadoInversoMediaCemMilBolha, ref float ordenadoInversoMediaDuzentosMilBolha, ref float desordenadoMediaMilBolha, ref float desordenadoMediaDezMilBolha, ref float desordenadoMediaCemMilBolha, ref float desordenadoMediaDuzentosMilBolha)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilBolha += Bolha(a, "ordenado", "Bolha");
            ordenadoMediaDezMilBolha += Bolha(b, "ordenado", "Bolha");
            ordenadoMediaCemMilBolha += Bolha(c, "ordenado", "Bolha");
            ordenadoMediaDuzentosMilBolha += Bolha(d, "ordenado", "Bolha");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilBolha += Bolha(a, "decrescente", "Bolha");
            ordenadoInversoMediaDezMilBolha += Bolha(b, "decrescente", "Bolha");
            ordenadoInversoMediaCemMilBolha += Bolha(c, "decrescente", "Bolha");
            ordenadoInversoMediaDuzentosMilBolha += Bolha(d, "decrescente", "Bolha");
        }
        // ---------BOLHA----------
        for (int z = 0; z < 10; z++)
        {
            int[] e = new int[a.Length];
            int[] f = new int[b.Length];
            int[] g = new int[c.Length];
            int[] h = new int[d.Length];
            for (int i = 0; i < a.Length; i++)
            {
                e[i] = a[i];
                Console.WriteLine(e[i]);
            }
            for (int j = 0; j < b.Length; j++)
            {
                f[j] = b[j];
            }
            for (int k = 0; k < c.Length; k++)
            {
                g[k] = c[k];
            }
            for (int l = 0; l < d.Length; l++)
            {
                h[l] = d[l];
            }
            desordenadoMediaMilBolha += Bolha(e, "desordenado", "Bolha");
            desordenadoMediaDezMilBolha += Bolha(f, "desordenado", "Bolha");
            desordenadoMediaCemMilBolha += Bolha(g, "desordenado", "Bolha");
            desordenadoMediaDuzentosMilBolha += Bolha(h, "desordenado", "Bolha");
        }
    }
    public float Seleção(int[] a, string tipoOrdenação, string metodoOrdenação)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < (a.Length - 1); i++)
        {
            int menor = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[menor] > a[j])
                {
                    menor = j;
                }
            }
        }
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }
    public float Bolha(int[] a, string tipoOrdenação, string metodoOrdenação)
    {
        Stopwatch stopwatch = new Stopwatch();
        int temp;
        stopwatch.Start();
        for (int i = 0; i < (a.Length - 1); i++)
        {
            for (int j = a.Length - 1; j > i; j--)
            {
                if (a[j] < a[j - 1])
                {
                    temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }
        }
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }
    public float Inserção(int[] a, string tipoOrdenação, string metodoOrdenação)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 1; i < a.Length; i++)
        {
            int tmp = a[i];
            int j = i - 1;
            while ((j >= 0) && (a[j] > tmp))
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = tmp;
        }
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }
    public void LerArquivo()
    {
        string diretorio = Directory.GetCurrentDirectory() + "/texto.txt";
        string[] data = File.ReadLines(diretorio).ToArray();
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
    public void SalvarInfos(string tipoOrdenação, string metodoOrdenação, float time, int quantidadeNum)
    {
        string diretorio = Directory.GetCurrentDirectory() + "/texto.txt";
        using (StreamWriter writer = new StreamWriter(diretorio, append: true))
        {
            string data = $"Tipo de ordenação: [{tipoOrdenação}], Metodo [{metodoOrdenação}], [{time}] milisegundos gastos, [{quantidadeNum}] elementos no vetor";
            writer.WriteLine(data);
        }
    }
}