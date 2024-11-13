// Ett Dungeon-spel med massa rum, saker, fiender, skatter ...
Console.Clear();
Console.WriteLine("Ett Dungeon-spel");

// Programvariabler (state variables)
string rum = "hallen";
List<string> inventory = [];

// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        System.Console.WriteLine("Du är i hallen");
        System.Console.WriteLine("1. Titta runt");
        System.Console.WriteLine("2. Gå till nästa rum");
        System.Console.WriteLine("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            System.Console.WriteLine("Du tittar runt i rummet och ser några gammla tavlor");
            System.Console.WriteLine("En av de hänger lite snett");
            System.Console.WriteLine("1. Titta bakom den");
            System.Console.WriteLine("2. Strunta i tavlan (Det är säkert inget) och gå till nästa rum");
            string inspektera = Console.ReadLine();
            if (inspektera == "1")
            {
                System.Console.WriteLine("Du tittar bakom tavlan och det trillar ner en dolk");
                System.Console.WriteLine("1. Lägg den i ditt inventory");
                System.Console.WriteLine("2. Sparka iväg den (knivar är farliga och vad ska du göra med den)");
                string dolk = Console.ReadLine();
                if (dolk == "1")
                {
                    System.Console.WriteLine("Du plockade up dolken");
                    System.Console.WriteLine("Du är i hallen");
                    System.Console.WriteLine("1. Titta runt");
                    System.Console.WriteLine("2. Gå till nästa rum");
                    System.Console.WriteLine("Vad vill du göra?");
                    string svar = Console.ReadLine();
                    if (svar == "1")
                    {
                        // Tittar runt igen
                        System.Console.WriteLine("Det en stor jätte kommer in genom dörren");
                        // Göm dig för jätten eller dö
                        System.Console.WriteLine("");
                    }
                    else
                    {
                        rum = "köket";
                        System.Console.WriteLine("Du går in i nästa köket");
                        System.Console.WriteLine("Det står en vårtfylld jätte med förkläde och hugger på en tom skärbräda med en stor köttkniv");
                        System.Console.WriteLine("1. Gå fram till honom och fråga vad fan han gör");
                        System.Console.WriteLine("2. Gå tillbaka till hallen");
                        System.Console.WriteLine("3. Hugg honom i benet med dolken");
                        System.Console.WriteLine("4. Försök att hitta ett sätt att komma up så att du når att hugga honom i halsen (han blir nog rätt arg om du bara hugger honom i benet)");
                        string köket = Console.ReadLine();
                        if (köket == "1")
                        {
                            System.Console.WriteLine("Du går fram till jätten och säger: 'Ursäkta vad hål...'");
                            System.Console.WriteLine("Längre hinner du inte");
                            System.Console.WriteLine("Jätten vänder sig klumpigt om och grymtar innan han hugger dig med köttkniven mitt itu.");
                            System.Console.WriteLine("Vill du börja om? (J/N)");
                            string börjaOm = Console.ReadLine().ToUpper();
                            if (börjaOm == "N")
                            {
                                break;
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Du är i hallen");
                    System.Console.WriteLine("1. Titta runt");
                    System.Console.WriteLine("2. Gå till nästa rum");
                    System.Console.WriteLine("Vad vill du göra?");
                    string svar = Console.ReadLine();
                }
            }
            else
            {

            }
        }
        else if (val == "2")
        {
            rum = "köket";
            System.Console.WriteLine("Du går in i nästa köket");
        }
    }
    else if (rum == "rum 1")
    {
        System.Console.WriteLine("Du är i hallen");
        System.Console.WriteLine("1. Titta runt");
        System.Console.WriteLine("2. Gå till nästa rum");
        System.Console.WriteLine("Vad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            System.Console.WriteLine("Du tittar runt i rummet och ser några gammla tavlor");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            System.Console.WriteLine("Du går in i nästa rum");
        }
    }
    else if (rum == "rum 2")
    {

    }
}