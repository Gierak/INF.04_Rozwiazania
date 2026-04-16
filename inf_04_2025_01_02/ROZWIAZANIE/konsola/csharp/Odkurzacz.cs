class Odkurzacz : Urzadzenie
{
    private bool stan = false;

    public void on()
    {
        if (!stan)
        {
            stan = true;
            Komunikat("Odkurzacz włączono");
        }
    }

    public void off()
    {
        if (stan)
        {
            stan = false;
            Komunikat("Odkurzacz wyłączono");
        }
    }
}