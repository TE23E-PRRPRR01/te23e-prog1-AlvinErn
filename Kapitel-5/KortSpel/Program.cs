// Ett annat exempel, lista på tre årtal
// List<int> årtal = [1957, 1969, 1989];


// Hur man skapar och använder listor
Console.Clear();
Console.WriteLine("Slumpa kort ur en kortlek!");

// Skapa en lista kort 
//List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];
List<string> kortlek = ["😱", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮"];

int antal = 5;
while (antal > 0)
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    //Console.WriteLine($"Det slumpade index = {index}");

    // Plocka ut det sjunde kortet, index = 6
    string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    // Skriv ut 7:e kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal --;
}