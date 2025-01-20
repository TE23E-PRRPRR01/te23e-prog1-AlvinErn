/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

using System.Diagnostics;

DisplayIntro();

while (true)
{
    DisplayMenu();

    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHeltal();

        RitaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHeltal();

        RitaTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

static int LäsInHeltal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}
static void DisplayIntro()
{
    Console.Clear();
Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");
}
static void DisplayMenu()
{
     // Skriva ut menyn
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}
static void RitaFyrkant(int tal)
{
     // Skriv ut fyrkanten
        for (int i = 0; i < tal; i++)
        {
            for (int j = 0; j < tal; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}
static void RitaTriangel(int tal)
{
     // Skriv ut triangeln
        for (int i = 0; i < tal; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}