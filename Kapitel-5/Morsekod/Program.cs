// En liten morsekod app
Console.Clear();

// För att kunna skriva svenska tecken
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("En liten morsekod app");

// Två listor
List<string> alfabetet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
 "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", ".----", "..---", "...--", "....-", ".....", "-....",
            "--...", "---..", "----.", "-----" ];
// Läs in en text
while (true)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();

    // Gå igenom meddelenadet bokstav för bokstav (loop)
    foreach (char bokstav in meddelande)
    {
        // Uppslag i alfabetet efter index
        int index = alfabetet.IndexOf(bokstav.ToString());

        // Hittar morsetecken?
        if (index >= 0)
        {
            //Console.WriteLine($"{bokstav} finns på index {index}");

            // Plocka ut morsetecknet för detta index
            string morsetecken = morsekod[index];
            //Console.WriteLine($"{bokstav} är {morsetecken}");
            Console.Write($"{morsetecken} ");

            // Spela upp morese som ljud-beep
            // T.ex. D = "-.."
            // Dvs loopa igenom morsetecknet
            foreach (char signal in morsetecken)
            {
                if (signal == '.') // '.'
                {
                    // 1000Hz, 200ms
                    Console.Beep(1000, 100);
                    Thread.Sleep(50);
                }
                else // '-'
                {
                    // 1000Hz, 600ms
                    Console.Beep(1000, 300);
                    Thread.Sleep(50);
                }
            }

            // Paus i koden
            Thread.Sleep(50);

        }
        else
        {
            Console.WriteLine("?");
        }
    }
}
