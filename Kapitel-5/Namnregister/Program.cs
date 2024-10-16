// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");

List<string> namnlista = [];

// Programloopen
while (true)
{
// Visa en meny
Console.Write("""
1. Registrera namn
2. Skriv ut alla namn
3. Avsluta
Ange ditt val: 
""");
string val = Console.ReadLine();
if (val == "1")
{
    while (true)
    {
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);
    Console.Write("Gå tillbaks (J/N), Radera listan(R): ");
    string svar = Console.ReadLine().ToUpper();
    if (svar == "J")
    {
        Console.Clear();
        break;
    }
    else if (svar == "R")
    {
        // Lägg till så att man kan redare listan och göra en ny
    }
    }
}
else if (val == "2")
{
     // Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
    Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}
else if (val == "3")
   
{
    break;
}
else
{
}
}
