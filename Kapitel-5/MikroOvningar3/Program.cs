// Mikro Övningar 3
using System.Threading.Tasks.Dataflow;

Console.Clear();
Console.WriteLine("Mikro Övningar 3");

// Lista med maträtter
List<string> maträtter = ["Sushi", "Grillat krokodil kött", "Wookade eggnudlar med kyckling"];

// Listan på maträtter börjar här:
Console.WriteLine("Olika maträtter:");

// Skriv ut varje maträtt på en enskild rad
foreach (var maträtt in maträtter)
{
    Console.WriteLine(maträtt);
}

// Mellanrum mellan maträtter och årtal
Console.WriteLine();

// Lista med årtal
List<int> årtal = [1978, 1980, 2007, 2008, 2013];

// Lista på olika årtal börjar här:
Console.WriteLine("Olika årtal:");

// Skriv ut varje årtal på en enskild rad
foreach (var år in årtal)
{
    Console.WriteLine(år);
}

// Mellanrum mellan olika årtal och alla olika årtal
Console.WriteLine();

// Rad med alla olika årtal
Console.Write($"Alla olika årtal: {string.Join(", ", årtal)}");

// Mellanrum mellan årtal och namn
Console.WriteLine();

// To lista för namn
List<string> lisNamn = [];

// Ange namn eller exit
while (true)
{
    Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta):");
    string addNamn = Console.ReadLine();
    if (addNamn == "exit")
    {
        break;
    }
    else
    {
        lisNamn.Add(addNamn);
    }
}

Console.WriteLine($"Alla namn: {string.Join(", ", lisNamn)}");

// Lista för årtal
List<int> lisÅrtal = [];

// Ange årtal eller exit
while (true)
{
    Console.Write("Ange ett årtal att lägga till (eller '0' för att avsluta):");
    int addÅrtal = int.Parse(Console.ReadLine());
    if (addÅrtal == 0)
    {
        break;
    }
    else
    {
        lisÅrtal.Add(addÅrtal);
    }
}

Console.WriteLine($"Alla årtal: {string.Join(", ", lisÅrtal)}");