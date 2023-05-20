Console.Write("Enter the name of the first Pokemon: ");
string pok1name = Console.ReadLine();
Console.Write("Enter the name of the 2nd Pokemon: ");
string pok2name = Console.ReadLine();

int turncnt = 1;
int pok1Hp = 100;
int pok2Hp = 100;
int pok1AtkDmg = 0;
int pok2AtkDmg = 0;

int moveChoice = 0;

Random rand = new Random();
while (true)
{
    Console.Clear();
    Console.WriteLine("-----Turn " + turncnt + "-----");
    pok1AtkDmg = rand.Next(4, 21);
    pok2AtkDmg = rand.Next(4, 21);
    // pok1.Speed > pok2.Speed
    Console.WriteLine(pok1name + " attacks: ");
    Console.WriteLine("1. Tackle");
    moveChoice = Convert.ToInt32(Console.ReadLine());
    Thread.Sleep(1000);
    switch (moveChoice)
    {
        case 1:
            Console.WriteLine(pok1name + " used Tackle!");
            break;
        default:
            break;
    }
    // pok1 attacks
    pok2Hp -= pok1AtkDmg;
    Console.WriteLine(pok1name + " attacked " + pok2name + " and deals " + pok1AtkDmg + " damage");
    if (pok2Hp < 0) pok2Hp = 0;
    if (pok2Hp <= 0)
    {
        Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
        Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
        Console.WriteLine("Battle ended.");
        turncnt++;
        break;
    }
    Thread.Sleep(1000);
    Console.WriteLine(pok2name + " attacks: ");
    Console.WriteLine("1. Tackle");
    moveChoice = Convert.ToInt32(Console.ReadLine());
    Thread.Sleep(1000);
    switch (moveChoice)
    {
        case 1:
            Console.WriteLine(pok2name + " used Tackle!");
            break;
        default:
            break;
    }
    // pok2 attacks
    pok1Hp -= pok2AtkDmg;
    if (pok1Hp < 0) pok1Hp = 0;
    Console.WriteLine(pok2name + " attacked " + pok1name + " and deals " + pok2AtkDmg + " damage");
    if (pok1Hp <= 0)
    {
        Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
        Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
        Console.WriteLine("Battle ended.");
        turncnt++;
        break;
    }
    Thread.Sleep(1000);
    Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
    Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
    Thread.Sleep(1000);
    turncnt++;
}

