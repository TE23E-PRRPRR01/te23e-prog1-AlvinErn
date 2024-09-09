Console.Clear();
Console.WriteLine("Hut gammal är du?");
string setAge = Console.ReadLine();

int age = int.Parse(setAge);

if (age < 2)
{
    Console.WriteLine("Du får inte ens leka med lego");
}
else 
{
   if (age <= 99)
   {
     Console.WriteLine("Du får bygga lego.");
   }
   
   if (age > 99)
   {
    Console.WriteLine("Du får inte bygga lego längre, tyvärr.");
   }
}

if (age >= 12)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Du får spela Fortnite!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Du får inte spela Fortnite!");
}

if (age >= 18)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Du får spela GTA V!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Du får inte spela GTA V.");
}

if (age >= 21)
{
    Console.WriteLine("Du får handla på systemet.");
}
else
{
    Console.WriteLine("Du får inte handla på systemet.");
}