// Skapa lista med slumpade tal

/* **************************************************
**                       Main                      **
************************************************** */

// Validera användarens inmatning
Console.Clear();
Console.WriteLine("Hello, World!");
// Deklarera variabler
// Skapa en tom lista för att spara des slumpade talen
List<int> listaSlumptal = [];

int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal");

int mintal = LäsInHeltal();
Console.WriteLine($"Du vill ha {mintal} som minsta möjliga slumptal");

int maxtal = LäsInHeltal();
Console.WriteLine($"Du vill ha {maxtal} som största möjliga slumptal");
for (var i = 0; i < antal; i++)
{
int slumptal = 0;
slumptal = Random.Shared.Next(mintal, maxtal + 1);
Console.WriteLine($"Slumptalet {i + 1}: {slumptal}");
listaSlumptal.Add(slumptal);
}

/* **************************************************
**                Mine egna metoder                **
************************************************** */

static int LäsInHeltal()
{
    int heltal = 0;
while (true)
{
    // Fråga användaren hur många slumptal som ska skapas
    Console.Write("Ange heltal: ");

    // Fråga igen tills användaren anger ett giltigt svar
    bool lyckades = int.TryParse(Console.ReadLine(), out heltal);

    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste ange ett heltal");
    }
}
return heltal;
}