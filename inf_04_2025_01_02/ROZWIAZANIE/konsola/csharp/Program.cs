Pralka pralka = new();
Odkurzacz odkurzacz = new();

Console.WriteLine("Podaj nr programu (1-12): ");
int program = int.Parse(Console.ReadLine()!);
if (program == pralka.Ustaw_nr_prania(program))
{
    Console.WriteLine("Program został włączony");
}
else
{
    Console.WriteLine("Podano niepoprawny numer programu");
}

odkurzacz.on();
odkurzacz.on();
odkurzacz.on();

odkurzacz.Komunikat("Odkurzacz wyładował się");
odkurzacz.off();