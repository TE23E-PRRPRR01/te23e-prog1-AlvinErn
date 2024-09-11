// Program för att konvertera från Fahrenheit till Celsius
Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celsius");

// Läser in temperaturen i Fahrenheit
Console.WriteLine("Ange temperatur i Fahrenheit:");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Konvertera Fahrenheit till Celsius
double tempCelsius = (tempFahrenheit -32) * 5 / 9;

// Skriva ut resultatet med decimaler
Console.WriteLine($"{tempFahrenheit} Fahrenheit blir {tempCelsius} grader Celsius.");