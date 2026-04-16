Operacje operacje = new(25);
operacje.WyswietlElementy();

int szukanie = operacje.PierwszeWystapienie(5);
if (szukanie != -1)
{
    Console.WriteLine($"Znaleziono liczbę (5), jest ona na indeksie: {szukanie}");
}

Console.WriteLine("Liczby nieparzyste:");
int ilosc_nieparzystych = operacje.WyswietlNieparzyste();
Console.WriteLine($"Razem nieparzystych: {ilosc_nieparzystych}");

Console.WriteLine($"Średnia wszystkich elementów: {operacje.SredniaArytmetyczna()}");