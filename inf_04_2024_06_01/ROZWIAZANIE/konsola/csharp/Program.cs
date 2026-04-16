Kosci kosci = new();
while (true)
{
    Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
    if (!int.TryParse(Console.ReadLine()!, out int ilosc_kosci)) continue;
    if (ilosc_kosci > 10 || ilosc_kosci < 3) continue;
    kosci.iloscKosci = ilosc_kosci;
    kosci.RzucWszystkimiKoscmi();
    for (int i = 0; i < kosci.wylosowane.Length; i++)
    {
        Console.WriteLine($"Kostka {i + 1}: {kosci.wylosowane[i]}");
    }
    Console.WriteLine($"Liczba uzyskanych punktów: {kosci.LiczPunkty()}");

    Console.WriteLine("Jeszcze raz? (t/n)");
    if (Console.ReadLine() == "n") break;
}