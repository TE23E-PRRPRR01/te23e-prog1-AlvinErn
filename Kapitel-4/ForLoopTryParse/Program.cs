// ForLoopTryParse
using System.ComponentModel;

Console.Clear();
// Nummer int
int tal = 0;
// Repitetioner
int antal;
// Skapa en loop som körs 10 gånger.
// Varje gång loopen körs ska den skriva ut ditt namn
System.Console.WriteLine("Tjenare mannen, vad heter du?");
string namn = Console.ReadLine();
while (true)
{
    System.Console.WriteLine("Hur många gånger vill du repetera ditt namn? (1-10)");
    bool lyckadesantal = int.TryParse(Console.ReadLine(), out antal);
    if (antal > 10 || antal < 0)
    {
       System.Console.WriteLine("Ange ett giltigt tal mellan 1-10"); 
    }
    else
    {
        // Repetarar namnet angivet antal gånger
    if (lyckadesantal = true)
    {
        for (int i = 0; i < antal; i++)
        {
            System.Console.WriteLine($"{i}. {namn}");
        }
        // Fråga efter ett nummer som ska räknas med
        System.Console.Write("Ange ett nummer:");
        double nummer = double.Parse(Console.ReadLine());
        // Räkna ut nya nummer
        double mulnummer = nummer * 2;
        double divnummer = nummer / 2;
        double addnummer = nummer + 2;
        double subnummer = nummer - 2;
        System.Console.WriteLine($"Multiplicerat med 2: {mulnummer}");
        System.Console.WriteLine($"Dividerat med 2: {divnummer}");
        System.Console.WriteLine($"Adderat med 2: {addnummer}");
        System.Console.WriteLine($"Subtraherat med 2: {subnummer}");
        break;

    }
    else
    {
        System.Console.WriteLine("Ange ett giltigt tal mellan 1-10");
        break;
    }
    }
}