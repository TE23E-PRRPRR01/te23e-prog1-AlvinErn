Intro();

Meny();


// Program-loop
while (true)
{
if (condition)
{
UtförEnAddition();
}
else if (condition)
{
    UtförEnSubtraktion();
}
else if (condition)
{
    UtförEnMultiplikation
}
else if (condition)
{
    UtförEnDivision
}
else if (condition)
{
    Avsluta();
}
else
{
    Console.WriteLine("Felaktigt val! Var god försök igen");
}
}



/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */
 static void Intro()
 {
    Console.Clear();
    Console.WriteLine("Välkommen till miniräknaren (<_<)");
    Console.WriteLine();
 }
 static void Meny()
 {
    Console.WriteLine("""
    1. Utför en addition
    2. Utför en subtraktion
    3. Utför en multiplikation
    4. Utför en division
    5. Avsluta
    """);
    Console.Write("Ange ditt val: ");
    string val = Console.ReadLine();
    
 }
 static void UtförEnAddition()
 {
    Console.Clear();
    Console.WriteLine("Utför en addition");
    Console.Write("Ange heltal 1: ");
    int heltal1 = int.Parse(Console.ReadLine());
    Console.Write("Ange heltal 2: ");
    int heltal2 = int.Parse(Console.ReadLine());
    int AdderadeHeltal = heltal1 + heltal2;
    Console.WriteLine($"Det blir {AdderadeHeltal}");
    
 }
 static void UtförEnSubtraktion()
 {
    Console.Clear();
    Console.WriteLine("Utför en subtraktion");
    Console.Write("Ange heltal 1: ");
    int heltal1 = int.Parse(Console.ReadLine());
    Console.Write("Ange heltal 2: ");
    int heltal2 = int.Parse(Console.ReadLine());
    int SubtraheraHeltal = heltal1 - heltal2;
    Console.WriteLine($"Det blir {SubtraheraHeltal}");
 }
 static void UtförEnMultiplikation()
 {
    Console.Clear();
    Console.WriteLine("Utför en multiplikation");
    Console.Write("Ange heltal 1: ");
    int heltal1 = int.Parse(Console.ReadLine());
    Console.Write("Ange heltal 2: ");
    int heltal2 = int.Parse(Console.ReadLine());
    int SubtraheraHeltal = heltal1 - heltal2;
    Console.WriteLine($"Det blir {SubtraheraHeltal}");
    
 }
 static void UtförEnDivision()
 {
    
 }
 static void Avsluta()
 {
    Console.WriteLine("Ha en trevlig dag!");
    break;
 }


