Console.WriteLine("Podaj tekst: ");
string tekst = Console.ReadLine()!;

Console.WriteLine("Podaj klucz (lb. całk.): ");
int klucz = int.Parse(Console.ReadLine()!);

Console.WriteLine(Environment.NewLine + Szyfr.Szyfrowanie(tekst, klucz));