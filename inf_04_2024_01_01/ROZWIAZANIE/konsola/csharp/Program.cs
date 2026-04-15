/**********************************************
nazwa funkcji:          plec
opis funkcji:           funkcja sprawdza plec osoby po nr. pesel
parametry:              pesel - pesel osoby do sprawdzenia
zwracany typ i opis:    char - literka M gdy osoba to mężczyzna, literka K gdy osoba to kobieta
autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
***********************************************/
static char plec(string pesel)
{
    if (pesel[9] % 2 == 0)
    {
        return 'K';
    }
    return 'M';
}

static bool suma_kontrolna(string pesel)
{
    int[] waga = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3];
    int S = 0;
    int pozycja = 0;

    foreach (int w in waga)
    {
        S += w * int.Parse(pesel[pozycja].ToString());
        pozycja++;
    }

    int M = S % 10;

    int R;
    if (M == 0)
    {
        R = 0;
    }
    else
    {
        R = 10 - M;
    }
    return R == int.Parse(pesel[10].ToString());
}

string pesel = "55030101193";

Console.Write("Podaj nr pesel: ");
pesel = Console.ReadLine()!;
if (plec(pesel) == 'K')
{
    Console.WriteLine("Kobieta");
}
else
{
    Console.WriteLine("Mężyczna");
}
if (suma_kontrolna(pesel))
{
    Console.WriteLine("Suma kontrolna zgodna");
}
else
{
    Console.WriteLine("Suma kontrolnia NIE zgodna");
}