//Pytanie pytanie = new Pytanie("tresc", "plik.png");

Console.Write("Podaj treść pytania: ");
string tresc = Console.ReadLine()!;

Console.Write("Podaj sciezke zdjęcia: ");
string sciezka = Console.ReadLine()!;

Console.Write("Podaj odpowiedź A: ");
string odpA = Console.ReadLine()!;

Console.Write("Podaj odpowiedź B: ");
string odpB = Console.ReadLine()!;

Console.Write("Podaj odpowiedź C: ");
string odpC = Console.ReadLine()!;

Console.Write("Podaj poprawną odpowiedź (A,B,C): ");
char poprawna = Console.ReadLine()![0];

PytanieZamkniete pytanieZamkniete = new(tresc, sciezka, odpA, odpB, odpC, poprawna);

Console.Write("Podaj twoją odpowiedź na pytanie: ");
if (pytanieZamkniete.SprawdzOdpowiedz(char.Parse(Console.ReadLine()!)))
{
    Console.WriteLine("Odpowiedź prawidłowa");
}
else
{
    Console.WriteLine("Odpowiedź nieprawidłowa");
}