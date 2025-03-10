using System.ComponentModel;

public class Zadanie01
{
    public static void Main(string[] args)
    {
        Zadanie01 myAplikacja = new Zadanie01();
        int[] tablica = new int[] { 1, 2, 3, 4, 5 };

        try
        {
            Console.WriteLine(myAplikacja.potega(2, 2, 2));

            tablica = myAplikacja.zapiszWTablicy(tablica, 2);
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine("");
            
            Console.WriteLine(myAplikacja.poleKola(2));

            Console.WriteLine(myAplikacja.sumaCyfr(123));

            tablica = myAplikacja.zamienElementy(tablica, 1, 2, 1);
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
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