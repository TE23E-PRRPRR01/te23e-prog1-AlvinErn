// Ett program för kryptering med Caesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Caesar-chiffer");

// Alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRTSUVWXYZÅÄÖ";
while (true)
{
    Console.WriteLine("");
    // Ange ett meddelande
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    // Ange nyckel (1-9)
    System.Console.Write("Ange nyckel (1-9): ");
    int nyckel = int.Parse(Console.ReadLine());

    // Loopa igenom meddelandet bokstav för bokstav
    foreach (char bokstav in meddelande)
    {
        // Hitta bokstavens position (index)
        int index = alfabetet.IndexOf(bokstav);

        // Om bokstaven finns i alfabetet
        if (index >= 0)
        {
            // Caesar-kryptering, addera en nyckel (t.ex. 2)
            int nyIndex = index + nyckel;

            // Börja om från början efter 29
            if (nyIndex >= alfabetet.Length)
            {
                nyIndex = nyIndex - alfabetet.Length;
            }

            // Plocka ut bokstaven för nyIndex
            char krypteradBokstav = alfabetet[nyIndex];
            Console.Write($"{krypteradBokstav}");
        }
        else
        {
            Console.Write(bokstav);
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Vill du kryptera ett nytt meddelande? (j/N)");
    string val = Console.ReadLine().ToUpper();
    if (val == "N")
    {
        break;
    }

}

