using System.Diagnostics;
using System.IO;
class Metodos
{
    // MERGESORT
    public float MergeSort(int[] v, int esq, int dir)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        if (esq < dir)
        {
            int meio = (esq + dir) / 2;
            MergeSort(v, esq, meio);
            MergeSort(v, meio + 1, dir);
            Intercala(v, esq, meio, dir);
        }
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }
    public void Intercala(int[] v, int esq, int meio, int dir)
    {
        int n1 = meio - esq + 1;
        int n2 = dir - meio;
        int[] v_esq = new int[n1];
        int[] v_dir = new int[n2];
        for (int i = 0; i < n1; i++)
            v_esq[i] = v[esq + i];
        for (int j = 0; j < n2; j++)
            v_dir[j] = v[meio + 1 + j];
        int cont1 = 0, cont2 = 0;
        int k = esq;
        while (cont1 < n1 && cont2 < n2)
        {
            if (v_esq[cont1] <= v_dir[cont2])
            {
                v[k] = v_esq[cont1];
                cont1++;
            }
            else
            {
                v[k] = v_dir[cont2];
                cont2++;
            }
            k++;
        }
        while (cont1 < n1)
        {
            v[k] = v_esq[cont1];
            cont1++;
            k++;
        }
        while (cont2 < n2)
        {
            v[k] = v_dir[cont2];
            cont2++;
            k++;
        }
    }

    // ShellSort
    public float ShellSort()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int h = 1;
        do { h = (h * 3) + 1; } while (h < n);
        do
        {
            h /= 3;
            for (int cor = 0; cor < h; cor++)
            {
                insercaoPorCor(cor, h);
            }
        } while (h != 1);
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }
    public void insercaoPorCor(int cor, int h)
    {
        for (int i = (h + cor); i < n; i += h)
        {
            int tmp = array[i];
            int j = i - h;
            while ((j >= 0) && (array[j] > tmp))
            {
                array[j + h] = array[j];
                j -= h;
            }
            array[j + h] = tmp;
        }
    }

    // QUICKSORT
    public float Quicksort(int[] array, int esq, int dir)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int i = esq, j = dir, pivo = array[(esq + dir) / 2];
        while (i <= j)
        {
            while (array[i] < pivo)
                i++;
            while (array[j] > pivo)
                j--;
            if (i <= j)
            { Trocar(i, j); i++; j--; }
        }
        if (esq < j)
            Quicksort(array, esq, j);
        if (i < dir){
            Quicksort(array, i, dir);
        }
            
        stopwatch.Stop();
        float time = stopwatch.ElapsedMilliseconds;
        int quantidadeNum = a.Length;
        SalvarInfos(tipoOrdenação, metodoOrdenação, time, quantidadeNum);
        return time;
    }

    // DEPENDENCIAS
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
    public void InicializandoMergeSort(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilMergeSort, ref float ordenadoMediaDezMilMergeSort, ref float ordenadoMediaCemMilMergeSort, ref float ordenadoMediaDuzentosMilMergeSort, ref float ordenadoInversoMediaMilMergeSort, ref float ordenadoInversoMediaDezMilMergeSort, ref float ordenadoInversoMediaCemMilMergeSort, ref float ordenadoInversoMediaDuzentosMilMergeSort, ref float desordenadoMediaMilMergeSort, ref float desordenadoMediaDezMilMergeSort, ref float desordenadoMediaCemMilMergeSort, ref float desordenadoMediaDuzentosMilMergeSort)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilMergeSort += MergeSort(a, "ordenado", "MergeSort");
            ordenadoMediaDezMilMergeSort += MergeSort(b, "ordenado", "MergeSort");
            ordenadoMediaCemMilMergeSort += MergeSort(c, "ordenado", "MergeSort");
            ordenadoMediaDuzentosMilMergeSort += MergeSort(d, "ordenado", "MergeSort");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilMergeSort += MergeSort(a, "decrescente", "MergeSort");
            ordenadoInversoMediaDezMilMergeSort += MergeSort(b, "decrescente", "MergeSort");
            ordenadoInversoMediaCemMilMergeSort += MergeSort(c, "decrescente", "MergeSort");
            ordenadoInversoMediaDuzentosMilMergeSort += MergeSort(d, "decrescente", "MergeSort");
        }
        // ---------MergeSort----------
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
            desordenadoMediaMilMergeSort += MergeSort(e, "desordenado", "MergeSort");
            desordenadoMediaDezMilMergeSort += MergeSort(f, "desordenado", "MergeSort");
            desordenadoMediaCemMilMergeSort += MergeSort(g, "desordenado", "MergeSort");
            desordenadoMediaDuzentosMilMergeSort += MergeSort(h, "desordenado", "MergeSort");
        }
    }
    public void InicializandoQuickSort(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilQuickSort, ref float ordenadoMediaDezMilQuickSort, ref float ordenadoMediaCemMilQuickSort, ref float ordenadoMediaDuzentosMilQuickSort, ref float ordenadoInversoMediaMilQuickSort, ref float ordenadoInversoMediaDezMilQuickSort, ref float ordenadoInversoMediaCemMilQuickSort, ref float ordenadoInversoMediaDuzentosMilQuickSort, ref float desordenadoMediaMilQuickSort, ref float desordenadoMediaDezMilQuickSort, ref float desordenadoMediaCemMilQuickSort, ref float desordenadoMediaDuzentosMilQuickSort)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilQuickSort += QuickSort(a, "ordenado", "QuickSort");
            ordenadoMediaDezMilQuickSort += QuickSort(b, "ordenado", "QuickSort");
            ordenadoMediaCemMilQuickSort += QuickSort(c, "ordenado", "QuickSort");
            ordenadoMediaDuzentosMilQuickSort += QuickSort(d, "ordenado", "QuickSort");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilQuickSort += QuickSort(a, "decrescente", "QuickSort");
            ordenadoInversoMediaDezMilQuickSort += QuickSort(b, "decrescente", "QuickSort");
            ordenadoInversoMediaCemMilQuickSort += QuickSort(c, "decrescente", "QuickSort");
            ordenadoInversoMediaDuzentosMilQuickSort += QuickSort(d, "decrescente", "QuickSort");
        }
        // ---------QuickSort----------
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
            desordenadoMediaMilQuickSort += QuickSort(e, "desordenado", "QuickSort");
            desordenadoMediaDezMilQuickSort += QuickSort(f, "desordenado", "QuickSort");
            desordenadoMediaCemMilQuickSort += QuickSort(g, "desordenado", "QuickSort");
            desordenadoMediaDuzentosMilQuickSort += QuickSort(h, "desordenado", "QuickSort");
        }
    }
    public void InicializandoShellSort(int[] a, int[] b, int[] c, int[] d, ref float ordenadoMediaMilShellSort, ref float ordenadoMediaDezMilShellSort, ref float ordenadoMediaCemMilShellSort, ref float ordenadoMediaDuzentosMilShellSort, ref float ordenadoInversoMediaMilShellSort, ref float ordenadoInversoMediaDezMilShellSort, ref float ordenadoInversoMediaCemMilShellSort, ref float ordenadoInversoMediaDuzentosMilShellSort, ref float desordenadoMediaMilShellSort, ref float desordenadoMediaDezMilShellSort, ref float desordenadoMediaCemMilShellSort, ref float desordenadoMediaDuzentosMilShellSort)
    {
        CompletarVetorDesordenado(a, b, c, d);
        for (int y = 0; y < 10; y++)
        {
            CompletarVetorOrdenadoCrescente(a, b, c, d);
            ordenadoMediaMilShellSort += ShellSort(a, "ordenado", "ShellSort");
            ordenadoMediaDezMilShellSort += ShellSort(b, "ordenado", "ShellSort");
            ordenadoMediaCemMilShellSort += ShellSort(c, "ordenado", "ShellSort");
            ordenadoMediaDuzentosMilShellSort += ShellSort(d, "ordenado", "ShellSort");
            CompletarVetorOrdenadoDecrescente(a, b, c, d);
            ordenadoInversoMediaMilShellSort += ShellSort(a, "decrescente", "ShellSort");
            ordenadoInversoMediaDezMilShellSort += ShellSort(b, "decrescente", "ShellSort");
            ordenadoInversoMediaCemMilShellSort += ShellSort(c, "decrescente", "ShellSort");
            ordenadoInversoMediaDuzentosMilShellSort += ShellSort(d, "decrescente", "ShellSort");
        }
        // ---------ShellSort----------
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
            desordenadoMediaMilShellSort += ShellSort(e, "desordenado", "ShellSort");
            desordenadoMediaDezMilShellSort += ShellSort(f, "desordenado", "ShellSort");
            desordenadoMediaCemMilShellSort += ShellSort(g, "desordenado", "ShellSort");
            desordenadoMediaDuzentosMilShellSort += ShellSort(h, "desordenado", "ShellSort");
        }
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

class Program
{
    static void Main()
    {
        //------------------------INICIALIZANDO------------------------//
        Metodos metodos = new Metodos();
        Stopwatch stopwatch = new Stopwatch();
        int[] vetorMil = new int[1000];
        int[] vetorDezMil = new int[10000];
        int[] vetorCemMil = new int[100000];
        int[] vetorDuzentosMil = new int[200000];

        //------------------------MEDIAS------------------------//
        float ordenadoMediaMilMergeSort = 0, ordenadoMediaDezMilMergeSort = 0, ordenadoMediaCemMilMergeSort = 0, ordenadoMediaDuzentosMilMergeSort = 0, ordenadoMediaMilShellSort = 0, ordenadoMediaDezMilShellSort = 0, ordenadoMediaCemMilShellSort = 0, ordenadoMediaDuzentosMilShellSort = 0, ordenadoMediaMilQuickSort = 0, ordenadoMediaDezMilQuickSort = 0, ordenadoMediaCemMilQuickSort = 0, ordenadoMediaDuzentosMilQuickSort = 0;
        float desordenadoMediaMilMergeSort = 0, desordenadoMediaDezMilMergeSort = 0, desordenadoMediaCemMilMergeSort = 0, desordenadoMediaDuzentosMilMergeSort = 0, desordenadoMediaMilShellSort = 0, desordenadoMediaDezMilShellSort = 0, desordenadoMediaCemMilShellSort = 0, desordenadoMediaDuzentosMilShellSort = 0, desordenadoMediaMilQuickSort = 0, desordenadoMediaDezMilQuickSort = 0, desordenadoMediaCemMilQuickSort = 0, desordenadoMediaDuzentosMilQuickSort = 0;
        float ordenadoInversoMediaMilMergeSort = 0, ordenadoInversoMediaDezMilMergeSort = 0, ordenadoInversoMediaCemMilMergeSort = 0, ordenadoInversoMediaDuzentosMilMergeSort = 0, ordenadoInversoMediaMilShellSort = 0, ordenadoInversoMediaDezMilShellSort = 0, ordenadoInversoMediaCemMilShellSort = 0, ordenadoInversoMediaDuzentosMilShellSort = 0, ordenadoInversoMediaMilQuickSort = 0, ordenadoInversoMediaDezMilQuickSort = 0, ordenadoInversoMediaCemMilQuickSort = 0, ordenadoInversoMediaDuzentosMilQuickSort = 0;

        //------------------------INCLUINDO_VALORES------------------------//
        metodos.InicializandoMergeSort(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilMergeSort, ref ordenadoMediaDezMilMergeSort, ref ordenadoMediaCemMilMergeSort, ref ordenadoMediaDuzentosMilMergeSort, ref ordenadoInversoMediaMilMergeSort, ref ordenadoInversoMediaDezMilMergeSort, ref ordenadoInversoMediaCemMilMergeSort, ref ordenadoInversoMediaDuzentosMilMergeSort, ref desordenadoMediaMilMergeSort, ref desordenadoMediaDezMilMergeSort, ref desordenadoMediaCemMilMergeSort, ref desordenadoMediaDuzentosMilMergeSort);
        metodos.InicializandoShellSort(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilShellSort, ref ordenadoMediaDezMilShellSort, ref ordenadoMediaCemMilShellSort, ref ordenadoMediaDuzentosMilShellSort, ref ordenadoInversoMediaMilShellSort, ref ordenadoInversoMediaDezMilShellSort, ref ordenadoInversoMediaCemMilShellSort, ref ordenadoInversoMediaDuzentosMilShellSort, ref desordenadoMediaMilShellSort, ref desordenadoMediaDezMilShellSort, ref desordenadoMediaCemMilShellSort, ref desordenadoMediaDuzentosMilShellSort);
        metodos.InicializandoQuickSort(vetorMil, vetorDezMil, vetorCemMil, vetorDuzentosMil, ref ordenadoMediaMilQuickSort, ref ordenadoMediaDezMilQuickSort, ref ordenadoMediaCemMilQuickSort, ref ordenadoMediaDuzentosMilQuickSort, ref ordenadoInversoMediaMilQuickSort, ref ordenadoInversoMediaDezMilQuickSort, ref ordenadoInversoMediaCemMilQuickSort, ref ordenadoInversoMediaDuzentosMilQuickSort, ref desordenadoMediaMilQuickSort, ref desordenadoMediaDezMilQuickSort, ref desordenadoMediaCemMilQuickSort, ref desordenadoMediaDuzentosMilQuickSort);

        string diretorio = Directory.GetCurrentDirectory() + "/texto.txt";
        using (StreamWriter writer = new StreamWriter(diretorio, append: true))
        {
            string data = $"{ordenadoMediaMilMergeSort / 10},{ordenadoMediaDezMilMergeSort/10}, {ordenadoMediaCemMilMergeSort/10}, {ordenadoMediaDuzentosMilMergeSort/10}, {ordenadoMediaMilShellSort/10}, {ordenadoMediaDezMilShellSort/10}, {ordenadoMediaCemMilShellSort/10}, {ordenadoMediaDuzentosMilShellSort/10}, {ordenadoMediaMilQuickSort/10}, {ordenadoMediaDezMilQuickSort/10}, {ordenadoMediaCemMilQuickSort/10}, {ordenadoMediaDuzentosMilQuickSort/10},{desordenadoMediaMilMergeSort/10}, {desordenadoMediaDezMilMergeSort/10}, {desordenadoMediaCemMilMergeSort/10}, {desordenadoMediaDuzentosMilMergeSort/10}, {desordenadoMediaMilShellSort/10}, {desordenadoMediaDezMilShellSort/10}, {desordenadoMediaCemMilShellSort/10}, {desordenadoMediaDuzentosMilShellSort/10}, {desordenadoMediaMilQuickSort/10}, {desordenadoMediaDezMilQuickSort/10}, {desordenadoMediaCemMilQuickSort/10}, {desordenadoMediaDuzentosMilQuickSort/10},{ordenadoInversoMediaMilMergeSort/10}, {ordenadoInversoMediaDezMilMergeSort/10}, {ordenadoInversoMediaCemMilMergeSort/10}, {ordenadoInversoMediaDuzentosMilMergeSort/10}, {ordenadoInversoMediaMilShellSort/10}, {ordenadoInversoMediaDezMilShellSort/10}, {ordenadoInversoMediaCemMilShellSort/10}, {ordenadoInversoMediaDuzentosMilShellSort/10}, {ordenadoInversoMediaMilQuickSort/10}, {ordenadoInversoMediaDezMilQuickSort/10}, {ordenadoInversoMediaCemMilQuickSort/10}, {ordenadoInversoMediaDuzentosMilQuickSort/10}";
            writer.WriteLine(data);
        }
        
    }
}