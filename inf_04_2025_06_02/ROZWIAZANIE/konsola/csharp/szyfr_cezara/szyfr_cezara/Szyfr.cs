public class Szyfr
{
    public static string Szyfrowanie(string tekst, int klucz)
    {
        string szyfr = "";
        foreach (char c in tekst)
        {
            int ascii = (int)c;

            if (ascii < 97 || ascii > 122)
            {
                szyfr += (char)ascii;
            }
            else
            {
                if (klucz < 0)
                {
                    //ujemne
                    int szyfrowana = ascii - 122 + klucz;
                    szyfrowana %= 26;
                    szyfrowana += 122;
                    szyfr += (char)szyfrowana;
                }
                else
                {
                    // dodatni
                    int szyfrowana = ascii - 97 + klucz;
                    szyfrowana %= 26;
                    szyfrowana += 97;
                    szyfr += (char)szyfrowana;
                }
            }
        }
        return szyfr;
    }
}