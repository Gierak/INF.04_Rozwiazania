Console.Write("Podaj tekst: ");
string tekst = Console.ReadLine()!;

Console.WriteLine($"Liczba samogłoskek: {Narzedzia.LiczSamogloski(tekst)}");
Console.WriteLine($"tekst bez duplikatów: {Narzedzia.UsunDuplikaty(tekst)}");