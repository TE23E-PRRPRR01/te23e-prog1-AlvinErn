// Spelet BlackJack / 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är 
// 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 (eller 11)

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut två kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
// Dela ut två kort till datorn
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;


// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare} poäng");
    Console.WriteLine($"Datorn har {summaDator} poäng");

    // Stanna eller dra ett kort
    Console.Write("Vill du ha ett nytt kort? (j/n)");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {
        if (summaDator < summaSpelare)
        {
            kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
            summaDator += kort;
            Console.WriteLine($"Datorn fick en {kort}a");
            Console.WriteLine($"Datorn har nu {summaDator} poäng");
        }
        else
        {
            if (summaDator <= 15)
            {
                kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
                summaDator += kort;
                Console.WriteLine($"Datorn har {kort} poäng");
            }
        }
        // @todo datorn får ta extra kort

        // Vem har vunnit?
        // Den som har närmast 21 poäng har vunnit
        if (summaSpelare > summaDator)
        {
            // Spelaren vann
            Console.WriteLine("Du har vunnit!");
        }
        else
        {
            // Datorn vann
            Console.WriteLine("Du har förlorat!");
        }
        break;
    }

    // Ta ett extra kort 
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaSpelare += kort;
    // Skriv ut kortet
    Console.WriteLine($"Du fick {kort} poäng");

    // Datorn får också ett nytt kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaDator += kort;
    // Skriv ut kortet
    Console.WriteLine($"Datorn fick {kort} poäng");


    // Stanna om man vill
    //Vem har vunnit?

    // Har datorn fått 21 och vunnit
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har vunnit");
        break;
    }
    // Har spelaren fått 21 har han vunnit
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit");
        break;
    }

    // Är spelaren tjock?
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat, datorn vann.");
        break;
    }
    // Är datorn tjock
    if (summaDator > 21)
    {
        Console.WriteLine("Datorn har förlorat och du vann!");
        break;
    }

}