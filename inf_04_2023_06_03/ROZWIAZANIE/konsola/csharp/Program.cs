Film film = new();
film.Tytul = "Avatar";

Console.WriteLine($"Tytuł: {film.Tytul}");
Console.WriteLine($"Liczba wypożyczeń: {film.Liczba_wypozyczen}");

film.InkrementujLiczbeWypozyczen();

Console.WriteLine($"Liczba wypożyczeń: {film.Liczba_wypozyczen}");