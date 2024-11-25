// Micro övningar 1 
Console.Clear();
Console.WriteLine("Micro övningar 1");

// Skapa en lista med namn
List<string> lisNamn = ["Anna", "Björn", "Cecilia"];

// Skriv ut namn listan
System.Console.WriteLine($"Lista på namn: {string.Join(", ", lisNamn)}");

// Be användaren lägga till ett namn
System.Console.Write("Ange in ett namn som du vill lägga till:");
string addNamn = Console.ReadLine();

// Lägg in namnet i listan
lisNamn.Add(addNamn);

// Skriv ut den nya listan på namn
System.Console.WriteLine($"Nu är listan: {string.Join(", ", lisNamn)}");

// Kolla så att namnet användaren vill ta bort finns i listan
while (true)
{
    // Be användaren ta bort ett namn
    System.Console.Write("Ange ett namn från listan som du vill ta bort:");
    string subNamn = Console.ReadLine();
    if (lisNamn.Contains(subNamn))
    {
        // Ta bort namnet från listan
        lisNamn.Remove(subNamn);
        break;
    }
    else
    {
        System.Console.WriteLine("Du angav ett felaktigt namn, var god försök igen");
    }

}
// Skriv ut den nya listan på namn
System.Console.WriteLine($"Nu är listan: {string.Join(", ", lisNamn)}");
