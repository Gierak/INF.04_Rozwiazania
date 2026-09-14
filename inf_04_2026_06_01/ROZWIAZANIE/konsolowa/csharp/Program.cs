Generator generator = new Generator();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Hasło nr. {i + 1}: {generator.GenerujBezpieczneHaslo()}");
}