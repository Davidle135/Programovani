using System;

class Program
{
    static Random rnd = new Random();

    static void Main(string[] args)
    {
        
        Console.Write("Počet řádků: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Počet sloupců: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[m, n];
        

        // Generování čísel 
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = rnd.Next(20);
                

            }
        }
        Console.WriteLine("první matice");
        VypsatMatici(a);

        

        

        int[,] c = new int[m, n];


        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                c[i, j] = 0;

            }
        }


        // Násobení matice číslem, ktetý yadá uživatel
        Console.Write("Vynásobit matici číslem: ");
        int s = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                c[i, j] = a[i, j] * s;
            }
        }


        VypsatMatici(c);

        

        int[,] b = new int[m, n];


        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = rnd.Next(20);

            }
        }
        Console.WriteLine("Druhá matice");
        VypsatMatici2(b);

        

        Console.WriteLine("Násobení dvou matic: ");
        

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                c[i, j] = a[i, j] * b[i, j];
            }
        }

        VypsatMatici2(c);

        Console.WriteLine("sčítaní dvou matic ");


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        VypsatMatici2(c);


        Console.WriteLine("odečítání dvou matic ");


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                c[i, j] = a[i, j] - b[i, j];
            }
        }

        VypsatMatici2(c);

        // Transpozice matice

        

        














    }













    static void VypsatMatici(int[,] a)
    {
        // Vypsání matice
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write("{0,5}", a[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void VypsatMatici2(int[,] b)
    {
        // Vypsání matice
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
                Console.Write("{0,5}", b[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void VypsatMatici3(int[,] c)
    {
        // Vypsání matice
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
                Console.Write("{0,5}", c[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    
}