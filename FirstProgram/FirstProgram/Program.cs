Console.Write("Enter the name of the first Pokemon: ");
string pok1name = Console.ReadLine();
Console.Write("Enter the name of the 2nd Pokemon: ");
string pok2name = Console.ReadLine();

int turncnt = 1;
int pok1Hp = 100;
int pok2Hp = 100;
int pok1AtkDmg = 0;
int pok2AtkDmg = 0;
int i = 0;
int turnPok = 1;

int moveChoice = 0;

Random rand = new Random();
while (true)
{
    Console.Clear();
    Console.WriteLine("-----Turn " + turncnt + "-----");
    // pok1.Speed > pok2.Speed
    turnPok = 1;
    Console.WriteLine(pok1name + " attacks: ");
    Console.WriteLine("1. Tackle");
    Console.WriteLine("2. Double Hit");
    Thread.Sleep(1000);
    Console.Write(Environment.NewLine + "What will " + pok1name + " do? (1/2): ");
    moveChoice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------------------");
    Thread.Sleep(1000);
    switch (moveChoice)
    {
        case 1:
            // Tackle
            Console.WriteLine(pok1name + " used Tackle!");
            Thread.Sleep(1000);
            if (checkTackleMiss())
            {
                break;
            }
            pok1AtkDmg = rand.Next(4, 21);
            if (checkCrit())
            {
                pok1AtkDmg *= 2;
                Thread.Sleep(1000);
            }
            pok2Hp -= pok1AtkDmg;
            Console.WriteLine(pok1name + " attacked " + pok2name + " and deals " + pok1AtkDmg + " damage");
            break;
        case 2:
            // Double Hit
            Console.WriteLine(pok1name + " used Double Hit!");
            Thread.Sleep(1000);
            int hit = rand.Next(2);
            pok1AtkDmg = rand.Next(7, 12);
            if (checkCrit())
            {
                pok1AtkDmg *= 2;
                Thread.Sleep(1000);
            }
            for (i = 0; i <= hit; i++)
            {
                pok2Hp -= pok1AtkDmg;
            }
            Console.WriteLine("Hit " + i + " times.");
            Thread.Sleep(1000);
            Console.WriteLine(pok1name + " attacked " + pok2name + " and deals " + pok1AtkDmg + " damage");
            break;
        default:
            break;
    }
    Console.WriteLine("-------------------------");
    // Pok2 moves
    turnPok = 2;
    Thread.Sleep(1000);
    if (pok2Hp < 0) pok2Hp = 0;
    if (pok2Hp <= 0)
    {
        Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
        Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
        Console.WriteLine("Battle ended.");
        turncnt++;
        break;
    }
    Console.WriteLine(pok2name + " attacks: ");
    Console.WriteLine("1. Tackle");
    Console.WriteLine("2. Double Hit");
    Thread.Sleep(1000);
    Console.Write(Environment.NewLine + "What will " + pok1name + " do? (1/2): ");
    moveChoice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------------------");
    Thread.Sleep(1000);
    switch (moveChoice)
    {
        case 1:
            // Tackle
            Console.WriteLine(pok2name + " used Tackle!");
            Thread.Sleep(1000);
            if (checkTackleMiss())
            {
                break;
            }
            pok2AtkDmg = rand.Next(4, 21);
            if (checkCrit())
            {
                pok2AtkDmg *= 2;
                Thread.Sleep(1000);
            }
            pok1Hp -= pok2AtkDmg;
            Console.WriteLine(pok2name + " attacked " + pok1name + " and deals " + pok2AtkDmg + " damage");
            break;
        case 2:
            // Double Hit
            Thread.Sleep(1000);
            Console.WriteLine(pok2name + " used Double Hit!");
            int hit = rand.Next(2);
            pok2AtkDmg = rand.Next(7, 12);
            if (checkCrit())
            {
                pok2AtkDmg *= 2;
                Thread.Sleep(1000);
            }
            for (i = 0; i <= hit; i++)
            {
                pok1Hp -= pok2AtkDmg;
            }
            Thread.Sleep(1000);
            Console.WriteLine("Hit " + i + " times.");
            Thread.Sleep(1000);
            Console.WriteLine(pok2name + " attacked " + pok1name + " and deals " + (pok2AtkDmg*i) + " damage");
            break;
        default:
            break;
    }
    Thread.Sleep(1000);
    if (pok1Hp < 0) pok1Hp = 0;
    if (pok1Hp <= 0)
    {
        Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
        Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
        Console.WriteLine("Battle ended.");
        turncnt++;
        break;
    }
    Console.WriteLine(pok1name + ": " + pok1Hp + "HP");
    Console.WriteLine(pok2name + ": " + pok2Hp + "HP");
    Thread.Sleep(1000);
    turncnt++;
    Console.WriteLine("Press Enter to continue...");
    while (Console.ReadKey().Key != ConsoleKey.Enter)
    {
        ;
    }
}

bool checkTackleMiss()
{
    int roll = rand.Next(100);
    if (roll - 95 > 0)
    {
        if (turnPok == 1)
        {
            Console.WriteLine(pok1name + " attack missed!");
            return true;
        } else if (turnPok == 2)
        {
            Console.WriteLine(pok2name + " attack missed!");
            return true;
        } 
    }
    return false;
}

bool checkCrit()
{
    int roll = rand.Next(100);
    if (roll - 90 > 0)
    {
        Console.WriteLine("Critical Hit!!");
        return true;
    }
    return false;
}
