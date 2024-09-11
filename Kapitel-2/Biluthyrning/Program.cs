// Biluthyrning
Console.Clear();
Console.WriteLine("Biluthyrning");

// Ange antal mil och hur många dagar bilen ska lånas
Console.WriteLine("Hur många mil ska du köra?");
double sträcka = double.Parse(Console.ReadLine());

Console.WriteLine("Hur många dagar vill du låna bilen?");
double dagar = double.Parse(Console.ReadLine());

// Räkna ut och berätta kostnaden
double kostnad = 500 + (100 * dagar + 5 * sträcka);
Console.WriteLine($"Det kommer att kosta {kostnad}");