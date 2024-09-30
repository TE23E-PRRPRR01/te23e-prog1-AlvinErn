// SLumpa 2 stad av 10
Console.Clear();
Console.WriteLine("Slumpa 2 av 10 städer");

// Lista på städer
List<string> Stader = ["Stockholm", "Paris", "Tokyo", "Vancouver", "Berlin", "Oslo", "New York City", "Seoul", "Hong kong", "Bangkok"];

int antal = 2;
while (antal > 0)
{
    int index = Random.Shared.Next(0, 9);
    string stad = Stader[index];
    Console.WriteLine($"Den slumpade staden blev {stad}");
    antal --;
}