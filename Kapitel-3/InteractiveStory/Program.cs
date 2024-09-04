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

// Kolla om svaret är left eller back
if (answer == "left")
{
Console.WriteLine("ok");
}