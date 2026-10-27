
using System;

class Program
{
    static void Tafelkaart(int n)
    {
        for (int rij = 1; rij <= n; rij++)
        {
            for (int kolom = 1; kolom <= n; kolom++)
            {
                Console.Write($"{rij * kolom}\t");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Voer een getal in: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Tafelkaart(n);
    }
}
