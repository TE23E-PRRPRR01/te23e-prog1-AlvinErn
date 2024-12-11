// Filmregister
Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmerna
List<string> listFilmer = [];

while (true)
{
    // Fråga använderan mata in antal
    Console.WriteLine("Ange antal filmer per sida (3-5):");
    int antalFilmer = int.Parse(Console.ReadLine());


    if (antalFilmer <= 5 && antalFilmer >= 3)
    {
        // Loopa tillbaks till menyn
        while (true)
        {
            // Visa en meny
            Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ: 
""");
            int alternativ = int.Parse(Console.ReadLine());

            // Hanterar val

            if (alternativ == 1)
            {
                // Lägg till filmer i listan
                Console.Clear();
                for (int i = 0; i < antalFilmer;)
                {
                    i++;
                    Console.Write($"Ange film {i}:");
                    listFilmer.Add(Console.ReadLine());
                }
            }
            else if (alternativ == 2)
            {
                Console.Clear();
                Console.WriteLine($"Alla filmer: {string.Join(", ", listFilmer)}");
            }
            else if (alternativ == 3)
            {
                Console.Write("Ange första bokstaven i filmer:");
                string firstLetter = Console.ReadLine();

                foreach (var film in listFilmer)
                {
                    if (film.StartsWith(firstLetter))
                    {
                        Console.WriteLine($"Filmer som börjar med {firstLetter}: {film}");
                    }
                }

            }
            else if (alternativ == 4)
            {
                Console.WriteLine("Tack för idag!");
                break;
            }
            else
            {
                Console.WriteLine("Ogiltigt alternativ, var god försök igen!");
            }
        }
    }
    else
    {
        Console.WriteLine("Antalet filmer du anget är ogiltigt, var god försök igen!");
    }
}