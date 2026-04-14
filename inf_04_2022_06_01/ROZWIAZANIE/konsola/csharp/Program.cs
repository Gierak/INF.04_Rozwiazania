int[] tablica = new int[51];
Random random = new();

void WypelnijTablice(int[] tb)
{
    for (int i = 0; i < 50; i++)
    {
        tb[i] = random.Next(1, 101);
    }
}

/******************************************************
nazwa funkcji:  Przeszukaj
argumenty:
                tb - przechowuje tablicę którą przeszukujemy,
                szukana - liczba której szukamy w tablicy
typ zwracany:   liczba całkowita oznaczająca indeks znalezionoego elementu (gdy brak to -1)
informacje:     funkcja szuka danego elementu w danej tablicy i zwraca odpowiedni rezultat
autor:          Karol - Gierak - Gieracki (https://github.com/Gierak)
*****************************************************/
int Przeszukaj(int[] tb, int szukana)
{
    tb[^1] = szukana;

    for (int i = 0; i < tb.Length; i++)
    {
        if (tb[i] == szukana && i != tb.Length - 1)
        {
            return i;
        }
    }
    return -1;
}

WypelnijTablice(tablica);
Console.Write("Podaj wartość do wyszukania w zbiorze (1-100): ");
int wartosc = int.Parse(Console.ReadLine()!);
int pozycja = Przeszukaj(tablica, wartosc);
Console.WriteLine(String.Join(',', tablica) + Environment.NewLine);
if (pozycja == -1)
{
    Console.WriteLine("Nie znaleiono elementu w tablicy");
}
else
{
    Console.WriteLine($"Znalazłem! jest ona na indeksie: {pozycja}");
}
