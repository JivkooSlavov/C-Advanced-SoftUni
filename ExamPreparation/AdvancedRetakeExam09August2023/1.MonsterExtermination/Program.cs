using Microsoft.VisualBasic;

Queue<int> armorsOfMonster = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());
Stack<int> strikesOfSoldier = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());

int killedMonster = 0;

while (armorsOfMonster.Count > 0 && strikesOfSoldier.Count > 0)
{
    int armor = armorsOfMonster.Peek();
    int strike = strikesOfSoldier.Peek();
    if (strike >= armor)
    {
        killedMonster++;
        strike -= armor;
        if (strike == 0)
        {
            strikesOfSoldier.Pop();
            armorsOfMonster.Dequeue();
        }
        else
        {
            armorsOfMonster.Dequeue();
            if (strikesOfSoldier.Count == 1)
            {
                strikesOfSoldier.Pop();
                strikesOfSoldier.Push(strike);
                continue;
            }
            else
            {
                strikesOfSoldier.Pop();
                int tempStrike = strike;
                strikesOfSoldier.Push(strikesOfSoldier.Pop() + tempStrike);
            }
        }
    }
    else
    {
        int leftArmor = armor - strike;
        strikesOfSoldier.Pop();
        armorsOfMonster.Dequeue();
        armorsOfMonster.Enqueue(leftArmor);
    }
}
if (armorsOfMonster.Count == 0)
{
    Console.WriteLine("All monsters have been killed!");
}
if (strikesOfSoldier.Count == 0)
{
    Console.WriteLine("The soldier has been defeated.");
}
Console.WriteLine($"Total monsters killed: {killedMonster}");