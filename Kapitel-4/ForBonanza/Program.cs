// ForBonanza
Console.Clear();
// Summa
int summa = 0;
// Ange start-tal och slut-tal
System.Console.Write("Ange start-tal:");
int startTal = int.Parse(Console.ReadLine());
System.Console.Write("Ange slut-tal:");
int slutTal = int.Parse(Console.ReadLine());
while (true)
{
// For loop skriver heltal mellan två tal
for (int i = startTal; i < slutTal + 1; i++)
{
    System.Console.WriteLine($"{i}");
    summa = summa + i;
}
    System.Console.WriteLine($"Summan av sifrorna mellan {startTal} och {slutTal} = {summa}");
}