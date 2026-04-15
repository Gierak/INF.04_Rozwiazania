/************************************************
klasa:          Narzedzia
opis:           Klasa reprezentuje narzędzia do operowania na tekstach (liczenie samoglosek i usuwanie duplikatów liter z tekstu)
metody:         LiczSamogloski - liczbę całkowitą oznaczającą ilość samogłosek
                UsunDuplikaty - zwraca tekst bez duplikatów liter
autor:          Karol - Gierak - Gieracki (https://github.com/Gierak)
************************************************/
class Narzedzia
{
    static public int LiczSamogloski(string tekst)
    {
        if (string.IsNullOrEmpty(tekst))
        {
            return 0;
        }

        int licz = 0;

        foreach (char c in tekst)
        {
            if ("aąeęiouóyAĄEĘIOUÓY".Contains(c))
            {
                licz++;
            }
        }
        return licz;
    }

    static public string UsunDuplikaty(string tekst)
    {
        if (string.IsNullOrEmpty(tekst))
        {
            return "";
        }

        string nowyTekst = "";

        for (int i = 0; i < tekst.Length - 1; i++)
        {
            if (tekst[i] == tekst[i + 1])
            {
                continue;
            }
            nowyTekst += tekst[i];
        }
        return nowyTekst + tekst[^1];
    }
}