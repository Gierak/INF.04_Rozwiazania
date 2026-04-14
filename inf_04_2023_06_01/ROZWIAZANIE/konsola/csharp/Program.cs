/*******************************************************
nazwa funkcji:          Wypelnianie
parametry wejściowe:    tb - tablica przechowywująca wartości typu logicznego
wartość zwracana:       brak
informacje:             funkcja wypełnia całą tablicę wartością logiczną prawdy
autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
****************************************************/
void Wypelnianie(bool[] tb)
{
    for (int i = 0; i < tb.Length; i++)
    {
        tb[i] = true;
    }
}

void SitoEratostenesa(bool[] tb)
{
    int n = tb.Length;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (tb[i])
        {
            for (int j = i * i; j < n; j += i)
            {
                tb[j] = false;
            }
        }
    }
}

bool[] tablica = new bool[100];
Wypelnianie(tablica);
SitoEratostenesa(tablica);

Console.WriteLine("Liczby pierwsze z przedziału od 2 do 100:");
for (int i = 2; i < tablica.Length; i++)
{
    if (tablica[i])
    {
        Console.Write(i + ", ");
    }
}
Console.Write(Environment.NewLine);