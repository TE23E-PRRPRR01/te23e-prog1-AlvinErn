/* ************************************************
 * **************** M A I N ***********************
 ************************************************* */
VisaPresentation();

// Variabler
string filnamn = "meddelande.txt";

//Program-loop
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaMedelande(filnamn);
    }
    else if (val == "2")
    {
        LäsaMedelande(filnamn);
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag");
        break;
    }
    else
    {
        Console.WriteLine("Fel val! Var god försök igen!");
    }
}









 /* ************************************************
 * **************** Metoder ***********************
 ************************************************* */
 /// <summary>
 /// Presentation av programet
 /// </summary>
static void VisaPresentation()

{
    Console.Clear();
    Console.WriteLine("""
    Program för att spara meddelande på disken
    Av Bertil Karlsson 1987
    """);
    Console.WriteLine();
}
/// <summary>
/// Visar programets meny med alla funktioner
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Spara meddelande
    2. Läsa meddelande
    3. Avsluta
    """);
    Console.Write("Ange ditt val: ");
}
/// <summary>
/// Sparar meddelanden på textfilen
/// </summary>
static void SparaMedelande(string filen)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText(filen, meddelande);
    Console.WriteLine("Ditt meddelande har sparats!");
}
/// <summary>
/// Läser upp meddelande från textfilen och skriver ut meddelandet
/// </summary>
static void LäsaMedelande(string filen)
{
    string meddelande = File.ReadAllText(filen);
    Console.WriteLine("Ditt senaste meddelande:");
    Console.WriteLine(meddelande);
}
