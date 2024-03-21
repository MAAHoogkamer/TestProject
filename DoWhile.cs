/*
int heroHP = 10;
int monsterHP = 10;
Random attackStr = new Random();
while (monsterHP > 0)
{
    // Hero attacks
    int heroAtk = attackStr.Next(1, 11);
    monsterHP -= heroAtk;
    Console.WriteLine("Monster lost " + heroAtk + " health. " + monsterHP + " health remaining.");

    if (monsterHP > 0)
    {
        // Monster attacks
        int monsterAtk = attackStr.Next(11);
        heroHP -= monsterAtk;
        Console.WriteLine("Hero lost " + monsterAtk + " health. " + heroHP + " health remaining.");
    } else {
        continue;
    }
}

Console.WriteLine((heroHP > 0 ? "Hero wins!" : "Monster wins..."));
*/