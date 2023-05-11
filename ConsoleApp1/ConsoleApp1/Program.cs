//Catdungeon
string line = "Hello User";
Console.ForegroundColor = ConsoleColor.White;

printLetterByLetter(line);
Thread.Sleep(700);
line = "Welcome to";
printLetterByLetter(line);
Thread.Sleep(700);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@" #####     #    #######    ######  #     # #     #  #####  ####### ####### #     # 
#     #   # #      #       #     # #     # ##    # #     # #       #     # ##    # 
#        #   #     #       #     # #     # # #   # #       #       #     # # #   # 
#       #     #    #       #     # #     # #  #  # #  #### #####   #     # #  #  # 
#       #######    #       #     # #     # #   # # #     # #       #     # #   # # 
#     # #     #    #       #     # #     #git  #    ## #     # #       #     # #    ## 
 #####  #     #    #       ######   #####  #     #  #####  ####### ####### #     # 
");
Thread.Sleep(1000);

Console.WriteLine(@" ._       __          ____
;  `\--,-' /`)    _.-'    `-._
 \_/    ' | /`--,'            `-.     .--....____
  /                              `._.'           `---...
  |-.   _      ;                        .-----..._______)
,,\q/ (q_>'_...                      .-'
===/ ; _.-'~~-             /       ,'
`""""`-'_,;  `""""         ___(       |
         \         ; /'/   \      \
          `.      //' (    ;`\    `\
          / \    ;     `-  /  `-.  /
         (  (;   ;     (__/    /  /
          \,_)\  ;           ,'  /
  .-.          |  |           `--'
 (""_.)-._     (__,>  ");
Thread.Sleep(2400);
Console.Clear();
Thread.Sleep(4000);
Console.ForegroundColor = ConsoleColor.White;
line = "Enter your name: ";
printLetterByLetterWithoutEndline(line);
string username = Console.ReadLine();
Thread.Sleep(1000);
line = "Hello ";
foreach (char letter in line)
{
    Console.Write($"{letter}");
    Thread.Sleep(50);
}
foreach (char letter in username)
{
    Console.Write($"{letter}");
    Thread.Sleep(50);
}
Console.Write("!" + Environment.NewLine);

Thread.Sleep(2000);
Console.Clear();
Thread.Sleep(1400);

line = @"You find yourself in a damp cellar, the ground beneath you is cold and moist.
Beneath the flickering light of a lamp you can see a wooden chest and a wooden door.

a) Try to open the door
b) Try to open the chest";
printLetterByLetterFast(line);

Thread.Sleep(2700);
line = "Your choice?: ";
printLetterByLetterWithoutEndline(line);

string input  = Console.ReadLine();

if (input == "a")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red; 
    line = @"As you try to open the door you break your wrist and die.";
    printLetterByLetter(line);
    Thread.Sleep(1000);
    line = "YOU DIED.";
    printLetterByLetterWithoutEndline(line);
    Console.ForegroundColor = ConsoleColor.White;
}
else if (input == "b")
{
    Console.Clear();
    Thread.Sleep(1500);
    line = @"You open the chest and a sweet little kitten jumps out of it.
It has a key hanging around its neck and jumps into your lap.

a) Pet the sweet kitten
b) Take the key from its necklace";
    printLetterByLetterFast(line);
    Console.ForegroundColor = ConsoleColor.Blue;
    Thread.Sleep(1000);
    Console.WriteLine(@"                   .-.
                  / /
                 / |
   |\     ._ ,-""  `.
   | |,,_/  7        ;
 `;=     ,=(     ,  /
  |`q  q  ` |    \_,|
 .=; <> _ ; /  ,/'/ |
';|\,j_ \;=\ ,/   `-'
    `--'_|\  )
   ,' | /  ;'
  (,,/ (,,/" + Environment.NewLine);
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(2700);
    line = "Your choice?: ";
    printLetterByLetterWithoutEndline(line);
    input = Console.ReadLine(); 

    if (input == "a")
    {
        Console.Clear();
        Thread.Sleep(1700);
        Console.ForegroundColor = ConsoleColor.Green;
        line = @"You pet the sweet kitten and it starts to purr. 
You feel happy inside. Everything is fine.";
        printLetterByLetter(line);
        Thread.Sleep(2400);
        printLetterByLetter("THE END.");
    }
    else if (input == "b")
    {
        Console.Clear();
        Thread.Sleep(1700);
        Console.ForegroundColor= ConsoleColor.Red;
        line = @"You try to take the necklace from the kitten.
It scratches you and you die.";
        printLetterByLetter(line);
        Thread.Sleep(1000);
        line = "YOU DIED.";
        printLetterByLetter(line);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void printLetterByLetter(string input)
{
    foreach (char letter in input)
    {
        Console.Write($"{letter}");
        Thread.Sleep(40); 
    }
    Console.Write('\n');
}
void printLetterByLetterFast(string input)
{
    foreach (char letter in input)
    {
        Console.Write($"{letter}");
        Thread.Sleep(10);
    }
    Console.Write('\n');
}
void printLetterByLetterWithoutEndline(string input)
{
    foreach (char letter in input)
    {
        Console.Write($"{letter}");
        Thread.Sleep(50);
    }
}