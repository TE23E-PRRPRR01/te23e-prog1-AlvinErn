// Program som simulerar kända Engeering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa en ASCii art
Console.WriteLine($"""
        `'::.
    _________H ,%%&%,
   /\     _   \%&&%%&%
  /  \___/^\___\%&%%&&
  |  | []   [] |%\Y&%'
  |  |   .-.   | ||  
~~@._|@@_|||_@@|~||~~~~~~~~~~~~~
     `'"'") )"'"'"`
""");

Console.Write("Does it move? (y/n)");
String answer = Console.ReadLine();

// Kolla om svaret är ja eller nej
if (answer == "y")
{ // y = yes
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine("PLz use Duct Tape!");
    }
}
else
{ // n = no
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if ( answer == "y")
    {
        Console.WriteLine("Plz use WD-40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}