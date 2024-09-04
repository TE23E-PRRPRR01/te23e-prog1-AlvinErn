//Lucktext info
Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Vad heter du i förnamn?");
string förnamn = Console.ReadLine();
Console.WriteLine("Vad gillar du att äta till frukost?");
string frukost = Console.ReadLine();
Console.WriteLine("Vilken är din favorit stad?");
string stad = Console.ReadLine();
Console.WriteLine("Vad gillar du att göra?");
string aktivitet = Console.ReadLine();
//Kort historia om din dag
if (förnamn == "Malte") 
{
    Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"En varm juli morgon i {stad} vaknade {förnamn} och jäspade stort. {förnamn} gick upp ur sängen och åt sina ruttna potäter och drack ett stort glas surströmmingsspad. Idag skulle {förnamn} hoppa runt i cirklar utanför sitt gymnasium. Det skulle bli en perfekt dag i {förnamn}s liv!");
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Du kan glömma {frukost} och att {aktivitet}!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"En varm juli morgon i {stad} vaknade {förnamn} och jäspade stort. {förnamn} gick upp ur sängen och åt {frukost}. Idag skulle {förnamn} {aktivitet}. Det skulle bli en perfekt dag i {förnamn}s liv!");
}