Console.Write("Podaj tytul: ");
string tytul1 = Console.ReadLine()!;

Console.Write("Podaj tresc: ");
string tresc1 = Console.ReadLine()!;

Notatka notatka = new(tytul1, tresc1);

notatka.Wyswietl();
notatka.Diagnostyczna();

Notatka notatka2 = new("Lista zakupowa", "jajka, masło, przecier pomidorowy");

notatka2.Wyswietl();
notatka2.Diagnostyczna();