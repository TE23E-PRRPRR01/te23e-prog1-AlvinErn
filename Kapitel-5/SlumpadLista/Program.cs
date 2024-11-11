// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

while (true)
{
    // Globala variabler
    // En lista för heltal
    List<int> listaSlumptal = [];

    // Be användaren ange antal slumpade tal
    Console.Write("Ange antal tal du vill slumpa:");
    int antal = int.Parse(Console.ReadLine());

    // användaren ange min och max värde
    Console.Write("Ange det minsta slumptalet:");
    int mintal = int.Parse(Console.ReadLine());
    Console.Write("Ange det största slumptalet:");
    int maxtal = int.Parse(Console.ReadLine());

    //loopa koden 5 ggr
    for (int i = 0; i < antal; i++)
    {
        // Ett tal mellan min-max
        int slumptal = 0;
        slumptal = Random.Shared.Next(mintal, maxtal + 1);
        
        // Lägg till slumptalet i listan
        listaSlumptal.Add(slumptal);
        Console.WriteLine($"Slumpat tal: {slumptal}");
    }
    Console.Write("Vill du köra igen eller stänga av? (I/S)");
    string val = Console.ReadLine().ToUpper();
    if (val == "S")
    {
        break;
    }
}


