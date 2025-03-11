using System.ComponentModel;

public class Zadanie01
{
    public static void Main(string[] args)
    {
        Zadanie01 myAplikacja = new Zadanie01();
        int[] tablica = new int[] { 1, 2, 3, 4, 5 };

        try
        {
            Console.WriteLine("Argumenty funkcji potega: 2, 2, 2");
            Console.WriteLine("potega: " + myAplikacja.potega(2, 2, 2));
        }
        catch (WarningException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("=======================");
        Console.WriteLine("Tablica przed zapiszWTablicy: ");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine("");
        tablica = myAplikacja.zapiszWTablicy(tablica, 2);
        Console.WriteLine("Tablica po zapiszWTablicy(tablica, 2): ");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.WriteLine("");
       Console.WriteLine("=======================");

        var r = 2;
        Console.WriteLine("Pole koła dla promienia równego " + r + " : " + myAplikacja.poleKola(r));
        Console.WriteLine("=======================");

        var sumowanaLiczba = 123;
        Console.WriteLine("Argument funkcji sumaCyfr: " + sumowanaLiczba);
        Console.WriteLine("sumaCyfr: " + myAplikacja.sumaCyfr(sumowanaLiczba));
        Console.WriteLine("=======================");

        Console.WriteLine("Tablica przed zamienElementy(): ");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine("");

        tablica = myAplikacja.zamienElementy(tablica, 1, 2, 1);
        Console.WriteLine("Tablica po zamienElementy(tablica, 1, 2, 1): ");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Wpisz 0, aby zakończyć program: ");
            var end = int.Parse(Console.ReadLine());
            if (end == 0)
            {
                break;
            }
        }
    }

    public int potega(int a, int b, int c)
    {
        if (c <= 0)
        {
            throw new WarningException("Trzeci argument jest mniejszy lub równy 0.");
        }

        if (b < 0)
        {
            throw new WarningException("Wykładnik jest mniejszy od 0.");
        }

        return (int)Math.Pow(a, b);
    }

    public int[] zapiszWTablicy(int[] tab, int a)
    {
        int[] tablica = new int[tab.Length];
        for (int i = 0; i < tab.Length; i++)
        { 
            tablica[i] = tab[i] * a;
        }
        

        return tablica;
    }

    public double poleKola(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    public string sumaCyfr(int liczba)
    {
        if (liczba >= 100 && liczba <= 999)
        {
            int suma = 0;
            int temp = liczba;
            while (temp > 0)
            {
                suma += temp % 10;
                temp /= 10;
            }

            if (suma % 3 == 0)
            {
                return "liczba podzielna przez 3";
            }
            else
            {
                return "liczba nie jest podzielna przez 3";
            }
        }
        else
        {
            return "Podana liczba nie jest trzycyfrowa";
        }
    }
    public int[] zamienElementy(int[] tab, int index1, int index2, int warunek)
    {
        if (index1 < 0 || index1 >= tab.Length || index2 < 0 || index2 >= tab.Length)
        {
            throw new WarningException("Indeks spoza zakresu");
        }

        if (warunek > 0)
        {
            int temp = tab[index1];
            tab[index1] = tab[index2];
            tab[index2] = temp;
        }

        return tab;
    }
}