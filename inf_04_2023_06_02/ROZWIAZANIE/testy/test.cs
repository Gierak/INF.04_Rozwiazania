static void BubbleSort(int[] tb)
{
    for (int i = 0; i < tb.Length; i++)
    {
        for (int j = 0; j < tb.Length - i - 1; j++)
        {
            if (tb[j] > tb[j + 1])
            {
                int bufor = tb[j];
                tb[j] = tb[j + 1];
                tb[j + 1] = bufor;
            }
        }
    }
}

Random random = new();
int[] tablica = new int[100];

for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = random.Next(0, 1001);
}

Console.WriteLine("Przed sortowaniem:");
Console.WriteLine(String.Join(",", tablica));

BubbleSort(tablica);

Console.WriteLine("\nPo sortowaniu:");
Console.WriteLine(String.Join(",", tablica));