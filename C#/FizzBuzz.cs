/* FizzBuzz challenge
FizzBuzz is a popular coding challenge and interview question. It exercises your understanding of the for, the if, the % remainder operator, and your command of basic logic.

FizzBuzz rules:
Output values from 1 to 100, one number per line.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

https://docs.microsoft.com/en-us/learn/modules/csharp-for/3-challenge
*/

for (int i = 1; i <= 100; i++)
{
    Console.Write(i);
    if (i % 3 == 0)
    {
        Console.Write(" - Fizz");
        if (i % 5 == 0)
        {
            Console.Write("Buzz");
        }
    }
    else if (i % 5 == 0)
    {
        Console.Write(" - Buzz");
    }
    Console.Write("\n");
}
