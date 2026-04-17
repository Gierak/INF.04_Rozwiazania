public class Kosc
{
    public static int liczbaInstancji;
    public string[] obrazy = ["kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"];
    public int liczbaOczek;
    public int identyfikatorZdjecia;
    public bool KoscDostepna;

    private static Random random = new Random();

    public Kosc(int wartoscWyrzuconejKosci)
    {
        if (wartoscWyrzuconejKosci < 1 || wartoscWyrzuconejKosci > 6)
        {
            wartoscWyrzuconejKosci = 0;
        }

        liczbaOczek = wartoscWyrzuconejKosci;
        identyfikatorZdjecia = wartoscWyrzuconejKosci;
        KoscDostepna = true;
        liczbaInstancji++;
    }

    public Kosc()
    {
        int losowa = random.Next(1, 7);
        liczbaOczek = losowa;
        identyfikatorZdjecia = losowa;
        KoscDostepna = true;
        liczbaInstancji++;
    }

    public void RzucKoscia()
    {
        if (KoscDostepna)
        {
            int losowa = random.Next(1, 7);
            liczbaOczek = losowa;
            identyfikatorZdjecia = losowa;
        }
    }

    public void BlokujKosc()
    {
        KoscDostepna = false;
    }

    public string WartoscWyrzucona()
    {
        return liczbaOczek switch
        {
            0 => "zero",
            1 => "jeden",
            2 => "dwa",
            3 => "trzy",
            4 => "cztery",
            5 => "pięć",
            6 => "sześć",
            _ => "zero",
        };
    }
}