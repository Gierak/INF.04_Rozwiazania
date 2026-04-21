namespace testy;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void WyrzuconaWartoscWZakresie1Do6()
    {
        Kosc kosc = new();
        Assert.IsInRange(1, 6, kosc.liczbaOczek);
    }

    [TestMethod]
    public void WartoscKosciGdyNiedostepna()
    {
        Kosc kosc = new();
        int lbOczekPrzed = kosc.liczbaOczek;
        kosc.BlokujKosc();
        kosc.RzucKoscia();
        Assert.AreEqual(lbOczekPrzed, kosc.liczbaOczek);
    }
}
