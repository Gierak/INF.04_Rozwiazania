namespace testy;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void DanePodstawowe()
    {
        Assert.AreEqual("def", Szyfr.Szyfrowanie("abc", 3));
    }

    [TestMethod]
    public void Zawijanie()
    {
        Assert.AreEqual("abc", Szyfr.Szyfrowanie("xyz", 3));
    }

    [TestMethod]
    public void Odszyfrowanie()
    {
        Assert.AreEqual("abc", Szyfr.Szyfrowanie("def", -3));
    }

    [TestMethod]
    public void KluczWiekszyNizDlugoscAlfabetu()
    {
        Assert.AreEqual("def", Szyfr.Szyfrowanie("abc", 29));
    }

    [TestMethod]
    public void SpacjeWTekscie()
    {
        Assert.AreEqual("cd ef", Szyfr.Szyfrowanie("ab cd", 2));
    }
}
