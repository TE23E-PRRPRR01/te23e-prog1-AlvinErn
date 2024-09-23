// Skriv och läs till och från fil
Console.Clear();
Console.WriteLine("Skriv och läs till och från fil");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som slutar när användaren säger avsluta
while (true)
{
     // Visar en meny och läser in användarens val
    Console.Write("""
    1. Skriv text i filen
    2. Läs in text ur filen
    3. Avsluta
    Välj ett av alternativen åvan:
    """);
    val = Console.ReadLine();

    // Variabler för text och filen
    string text = "";
    string filen = "";

    // Hantera användarens val
     if (val == "1")
    {
        Console.WriteLine("Vad vill du att filen ska heta?");
        filen = Console.ReadLine();
        Console.WriteLine("Skriv in text som du vill lada up i filen");
        text = Console.ReadLine();
        File.WriteAllText($"{filen}.txt", text);
    }
    else if (val == "2")
    {
        Console.Write("Ange filnamn:");
        filen = Console.ReadLine();
          if (File.Exists($"{filen}.txt"))
        {
            text = File.ReadAllText($"{filen}.txt");
            Console.WriteLine($"{text}");
        }
        else
        {
            Console.WriteLine("Filen finns inte!");
        }

    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, var god ange ett nytt alternativ.");
    }
}