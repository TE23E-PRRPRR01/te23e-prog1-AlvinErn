// Mikro Övningar 2
using System.Threading.Tasks.Dataflow;

Console.Clear();
Console.WriteLine("MÖ2");

// Lista med fem namn
Console.WriteLine("Fem namn:");
List<string> listNamn = ["Alvin", "Carl", "Christoffer", "Gabriel", "Mikael"];
Console.WriteLine(string.Join(", ", listNamn));

// Lista på fem orter
Console.WriteLine("Fem orter:");
List<string> listOrter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];
Console.WriteLine(string.Join(", ", listOrter));

// Lista på fem årtal
Console.WriteLine("Fem årtal:");
List<int> listÅrtal = [1978, 1980, 2007, 2008, 2013];
Console.WriteLine($"'{string.Join(",' '", listÅrtal)}'");

// Sista och först talet i årtals listan
Console.WriteLine("Första talet i årtals listan är:" + listÅrtal[0]);
Console.WriteLine("Sista talet i årtals listan är:" + listÅrtal[4]);

// Lista på drycker
Console.WriteLine("Mina favorit drycker:");
List<string> listDrycker = ["Vatten", "Mjölk", "Mango juice", "Fanta exotic", "Ramlösa mango och grapefruit"];
Console.WriteLine(string.Join(", ", listDrycker));

// Lista på åldrar
List<int> listÅldrar = [45, 11, 7, 64, 76];
Console.WriteLine(string.Join(", ", listÅldrar));

// Räkna ut när de är födda
List<int> listFödelse = [1, 1, 1, 1, 1];
int i = 0;
foreach (var ålder in listÅldrar)
{
listFödelse[i] = 2024 - listÅldrar[i];
i ++ ;
}
listFödelse.Sort();
Console.Write($"'{string.Join(",' '", listFödelse)}'");
