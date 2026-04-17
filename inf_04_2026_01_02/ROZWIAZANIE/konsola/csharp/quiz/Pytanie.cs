abstract class Pytanie
{
    protected string pytanie;
    protected string plik;
    protected bool odpPoprawna;

    public Pytanie(string tresc, string plik)
    {
        pytanie = tresc;
        this.plik = plik;
        odpPoprawna = false;
    }

    public abstract bool SprawdzOdpowiedz(char odpowiedz);
}