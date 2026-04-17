Kosc kosc = new();

Console.WriteLine("Liczba instancji: " + Kosc.liczbaInstancji);
Console.WriteLine($"Liczba oczek: {kosc.liczbaOczek} ({kosc.WartoscWyrzucona()})");
Console.WriteLine("Nazwa pliku: " + kosc.obrazy[kosc.liczbaOczek]);

Console.WriteLine("\nPodaj liczbę oczek: ");
Kosc kosc2 = new(int.Parse(Console.ReadLine()!));

Console.WriteLine("\nLiczba instancji: " + Kosc.liczbaInstancji);
Console.WriteLine($"Liczba oczek: {kosc2.liczbaOczek} ({kosc2.WartoscWyrzucona()})");
Console.WriteLine("Nazwa pliku: " + kosc2.obrazy[kosc2.liczbaOczek]);