/*
Role playing game battle challenge
Game Rules

The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
https://docs.microsoft.com/en-us/learn/modules/csharp-do-while/3-challenge
*/

int hero = 10;
int monster = 10;
Random attack = new Random();

while (hero > 0 && monster > 0)
{
    int damage = attack.Next(1, 11);
    monster -= damage;
    Console.WriteLine($"Hero attacks! Monster was damaged and lost {damage} health and now has {monster} health.");

    if (monster <= 0) break;

    damage = attack.Next(0, 11);
    hero -= damage;
    Console.WriteLine($"Monster attacks! Hero was damaged and lost {damage} health and now has {hero} health.");
}


if (monster <= 0)
{
    Console.WriteLine("Hero wins!");
}
else
    Console.WriteLine("Monster wins!");
