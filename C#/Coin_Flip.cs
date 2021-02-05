// Step 1 - Delete all of the code in the .NET Editor from the earlier exercise
// Step 2 - Write code in the .NET Editor to display the result of a coin flip
// https://docs.microsoft.com/en-us/learn/modules/csharp-evaluate-boolean-expressions/4-challenge-1

Random coin = new Random();
Console.WriteLine("Flipping coin.... " + (coin.Next(0, 2) == 1 ? "Heads!" : "Tails!"));
