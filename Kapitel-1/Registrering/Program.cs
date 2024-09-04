// Program för att ange för- och efternamn
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hej vad heter du?");
Console.Write("Ange förnamn:");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn:");
string efternamn = Console.ReadLine();
Console.WriteLine($"Hej! {förnamn} {efternamn}");
//Alvin får en hälsning, Erngren får en komplimang och Alvin Erngren får både och
if (förnamn == "Alvin")
{
    Console.WriteLine("Tjenare Alvin!");
}
if (efternamn == "Erngren")
{
    Console.WriteLine ("Vilket underbart efternamn!");
}