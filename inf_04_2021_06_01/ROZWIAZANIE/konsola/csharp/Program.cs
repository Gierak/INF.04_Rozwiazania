Sortowanie sortowanie = new();
Console.WriteLine("Podaj 10 liczb całkowitch do wysortowania");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Podaj {i + 1}. liczbe: ");
    sortowanie.tablica[i] = int.Parse(Console.ReadLine()!);

}
sortowanie.SortowaniePrzezWybieranie();
sortowanie.WypiszTablice();