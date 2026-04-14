/********************************************************
* nazwa funkcji: Szyfruj
*
* parametry wejściowe: tekst - przechowuje tekst do zaszyfrowania
* wartość zwracana: funkcja zwraca zaszyfrowany tekst
* opis funkcji: funkcja wykonuje szyfrowanie tekstu szyfrem GADERYPOLUKI.
*
* autor: Karol - Gierak - Gieracki (https://github.com/Gierak)
* ****************************************************/
static string Szyfruj(string tekst)
{
    string szyfr = "";
    foreach (char c in tekst)
    {
        szyfr += c switch
        {
            'g' => "a",
            'a' => "g",
            'd' => "e",
            'e' => "d",
            'r' => "y",
            'y' => "r",
            'p' => "o",
            'o' => "p",
            'l' => "u",
            'u' => "l",
            'k' => "i",
            'i' => "k",
            _ => c,
        };
    }
    return szyfr;
}

Console.Write("Podaj tekst do zaszyfrowania: ");
string tekst = Console.ReadLine()!;
Console.WriteLine("Szyfr: " + Szyfruj(tekst));