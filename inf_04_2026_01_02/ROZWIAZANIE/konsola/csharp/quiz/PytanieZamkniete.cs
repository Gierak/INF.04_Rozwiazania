class PytanieZamkniete : Pytanie
{
    private string trescA;
    private string trescB;
    private string trescC;
    private char poprawnaOdpowiedz;

    public PytanieZamkniete(string tresc, string plik, string trescA, string trescB, string trescC, char poprawnaOdpowiedz) : base(tresc, plik)
    {
        this.trescA = trescA;
        this.trescB = trescB;
        this.trescC = trescC;
        this.poprawnaOdpowiedz = poprawnaOdpowiedz;
    }



    public override bool SprawdzOdpowiedz(char odpowiedz)
    {
        odpPoprawna = odpowiedz == poprawnaOdpowiedz;
        return odpPoprawna;
    }
}