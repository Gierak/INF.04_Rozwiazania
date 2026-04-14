/**********************************************
nazwa funkcji:          NWD
opis funkcji:           Funkcja szuka największego wspólnego dziennika 2 liczb
parametry:              a - liczba całkowita dodatnia, jedna z liczb której szukamy NWD
                        b - liczba całkowita dodatnia, jedna z liczb której szukamy NWD
zwracany typ i opis:    liczba całkowita dodatnia - zwracam najwiękśzy wspólny dzielnik liczby a i b
autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
***********************************************/
static uint NWD(uint a, uint b)
{
    while (a != b)
    {
        if (a > b)
        {
            a -= b;
        }
        else
        {
            b -= a;
        }
    }
    return a;
}

Console.Write("Podaj liczbę a: ");
uint a = uint.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę b: ");
uint b = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"Największy wspólny dzielnik to: {NWD(a, b)}");