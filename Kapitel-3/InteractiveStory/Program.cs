Console.Clear();

Console.Write($"""
  \_/       .:'    .:'    .:'
-=(_)=-  /\||   /\||   /\||
  / \   //\\|  //\\|  //\\|
       //  \\ //  \\ //  \\
      //    \^/    \^/    \\
      |[]  []|[]  []|[]  []|
     &|  ||  %  ||  |  ||  |%
  &%&--==--&%-==''%&'''%&%''&%&
""");
Console.WriteLine("Where would you like to go? (left/back)");
string answer = Console.ReadLine();

// Kolla om svaret är left
if (answer == "left")
{
Console.WriteLine("ok would you like to go down/left");
answer = Console.ReadLine();
if (answer == "left")
{
  Console.WriteLine("You found a treasure and became the king of the village")
}
if (answer == "down")
{
  Console.WriteLine("You found a knife and went to the dragons denn. Kill/run")
  answer = Console.ReadLine();
  if (answer == "Kill")
  {
    Console.WriteLine ("You tried to kill the dragon but a knife was apperently not enough and the dragen made BBQ out of you")
  }
  if (answer == "run")
  {
    Console.WriteLine ("You ran away but sliped on a banana peel (classic) and the knife sliped out of your hand and took your heart out")
  }
}
}

if (answer == "back")
{
Console.WriteLine("you died")
}