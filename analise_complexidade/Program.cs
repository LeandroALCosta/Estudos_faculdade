using System.Globalization;
using System.Collections.Generic;
using System.Security.Authentication;

class Program
{
    public int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0;

    public void ExA(int n)
    {
        for (int i = 0; i < n; i++)
        {
            a *= 1;
            b *= 2;
            c *= 3;
            d *= 4;
            e *= 5;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; i < n; j++)
            {
                for (int k = 0; i < n; k++)
                {
                    a *= 1;
                    b *= 2;
                    c *= 3;
                    d *= 4;
                }
            }
        }
    }

    public void ExB(int n)
    {

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        a *= 1;
                        b *= 2;
                        c *= 3;
                        d *= 4;
                        e *= 5;
                        f *= 6;
                        g *= 7;
                        a *= b;
                        b *= c;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; i < n; j++)
            {
                a *= 1;
                b *= 2;
                c *= 3;
                d *= 4;
                e *= 5;
            }
        }

        // !Não sei fazer a ultima da (b)

    }

    public void ExC(int n)
    {

        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    a *= 1;
                    b *= 2;
                    c *= 3;
                    d *= 4;
                }
            }
        }

        d *= 4;
        e *= 5;

    }

    public void ExD(int n)
    {

        for (int i = 0; i < n; i /= 2)
        {
            a *= 1;
        }

        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < n; l++)
            {
                a *= 1;
            }
        }

    }

    public void ExE(int n)
    {
        for (int i = 0; i < n; i /= 2)
        {
            a *= 1;
            b *= 2;
            c *= 3;
        }

        for (int i = 0; i < n; i /= 2)
        {
            a *= 1;
        }

    }

    public static void ExF(int n)
    {
        int a = 0, b = 0;
        for (int i = 0; i < n; i /= 2)
        {
            a *= 1;
            b *= 2;
        }

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i /= 2)
            {
                a *= 1;
                b *= 2;
            }
        }

        for (int i = 0; i < n; i /= 2)
        {
            a *= 1;
        }

    }

    public static void Main(string[] args)
    {
        ExF(2);
    }
}