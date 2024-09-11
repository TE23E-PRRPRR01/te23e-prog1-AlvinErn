// BMI räknare
using System.Reflection;

Console.Clear();
Console.WriteLine("Räkna ut din BMI");

// Ange vikt
Console.WriteLine("Ange din vikt i kg:");
double vikt = double.Parse(Console.ReadLine());

// Ange längd
Console.WriteLine("Ange din läng i meter:");
double längd = double.Parse(Console.ReadLine());

// Räkna ut BMI
double BMI = vikt / (längd * längd);
Console.WriteLine($"Din BMI är: {BMI}");

// Beräkna om användaren är överviktig, underviktig eller i normalvikt
if (BMI > 18.5)
{
   if (BMI > 25)
   {
    Console.WriteLine("Du är överviktig");
   }

   if (BMI < 25)
   {
    Console.WriteLine("Du är normalvikt");
   }
}
else 
{
    Console.WriteLine("Du är underviktig");
}

