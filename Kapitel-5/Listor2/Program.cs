// Listor 2
Console.Clear();
Console.WriteLine("Listor 2");

// Skapa en tom lista
List<string> listFrukter = [];

// Lägg till två saker i listan
listFrukter.Add("Päron");
listFrukter.Add("Äpple");

// Skapa en tom lista igen
List<string> listGrönsaker = [];

// Fråga användaren om två till frukter
Console.WriteLine("Nu ska du ange två frukter i listan:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange en frukt: ");
    listFrukter.Add(Console.ReadLine());
}

// Fråga användaren om tre grönsaker
Console.WriteLine("Nu ska du fylla i tre grönsaker:");
for (int i = 0; i < 3; i++)
{
    Console.Write("Ange en grönsak: ");
    listGrönsaker.Add(Console.ReadLine());
}
// Fråga användaren om två till frukter
Console.WriteLine("Nu ska du ange två frukter i listan:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange en frukt: ");
    listFrukter.Add(Console.ReadLine());
}
// Skriv ut de två första frukterna i listan
Console.WriteLine(" Här är de två första frukterna i listan:");
Console.WriteLine($"- Spel 1:{listFrukter[0]}");
Console.WriteLine($"- Spel 2:{listFrukter[1]}");
// Skriv ut hela fruktlistan
int a = 0;
Console.WriteLine("Listan med frukt");
foreach (var frukt in listFrukter)
{
    Console.WriteLine($"Frukt {a + 1}: {listFrukter[a]}");
    a ++;
}
// Skriv ut hela grönsakslistan