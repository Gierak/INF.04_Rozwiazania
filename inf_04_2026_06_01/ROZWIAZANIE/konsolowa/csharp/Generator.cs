public class Generator
{
    private string maleLitery = "abcdefghijklmnopqrstuvwxyz";
    private string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string polskieDiakryczne = "ąęłńóśżźĄĘŁŃÓŚŻŹ";
    private string znakiSpecjalne = "!@#$%^&*()_+";
    private string cyfry = "1234567890";
    private Random random = new Random();

    /************************************************
    nazwa metody:           GenerujBezpieczneHaslo
    opis metody:            Metoda generuje bezpieczne 12 znakowe hasło 
    parametry:              brak
    zwracany typ i opis:    typ napisowy - zwraca bezpieczne 12 znakowe hasło
    autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
    ************************************************/
    public string GenerujBezpieczneHaslo()
    {
        string haslo = "";

        // 3 male litery
        for (int i = 0; i < 3; i++)
        {
            haslo += maleLitery[random.Next(0, maleLitery.Length)];
        }

        // 3 wielkie litery
        for (int i = 0; i < 3; i++)
        {
            haslo += wielkieLitery[random.Next(0, wielkieLitery.Length)];
        }

        // 2 znaki diakryczne
        for (int i = 0; i < 2; i++)
        {
            haslo += polskieDiakryczne[random.Next(0, polskieDiakryczne.Length)];
        }

        // 2 cyfry
        for (int i = 0; i < 2; i++)
        {
            haslo += cyfry[random.Next(0, cyfry.Length)];
        }

        // 2 znaki specjalne
        for (int i = 0; i < 2; i++)
        {
            haslo += znakiSpecjalne[random.Next(0, znakiSpecjalne.Length)];
        }

        char[] hasloTablica = haslo.ToCharArray();

        for (int i = 0; i < haslo.Length; i++)
        {
            int pozycja = random.Next(0, haslo.Length);
            (hasloTablica[i], hasloTablica[pozycja]) = (hasloTablica[pozycja], hasloTablica[i]);
        }

        return new string(hasloTablica);
    }
}