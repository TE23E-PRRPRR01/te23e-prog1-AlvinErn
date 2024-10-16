// Använde listor för att skapa / hantera samlingar
using System.Net.WebSockets;

Console.Clear();

// Lista på trevliga frukter. t.ex. "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// SKapa en lista på valfri sak (4st)
//Skriv ut varje sak på samma rad

List<string> boenden = ["villa", "lägenhet", "radhus", "tält"];

foreach (var boende in boenden)
{
    Console.Write($"{boende} ");
}

for (int i = 0; i < boenden.Count; i++)
{
    Console.Write($"{boenden[i]}");
}

// Skapa ett register
Console.Clear();
// En tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
    Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}