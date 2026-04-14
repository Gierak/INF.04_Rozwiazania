Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.licznik}");
Osoba osoba_bezparametrowa = new();

Console.Write("Podaj id: ");
int id = int.Parse(Console.ReadLine()!);

Console.Write("Podaj imię: ");
string imie = Console.ReadLine()!;

Osoba osoba_parametrowa = new(id, imie);

Osoba osoba_kopia = new(osoba_parametrowa);

osoba_bezparametrowa.Wypisywanie("Jan");
osoba_parametrowa.Wypisywanie("Jan");
osoba_kopia.Wypisywanie("Jan");

Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.licznik}");