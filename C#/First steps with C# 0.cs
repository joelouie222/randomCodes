/*
https://docs.microsoft.com/en-us/learn/modules/csharp-if-elseif-else/4-challenge
Rule 1. If the user's subscription will expire in 10 days or less, output the message:
Rule 2. Rule 2. If the user's subscription will expire in five days or less, output the messages:
Rule 3. If the user's subscription will expire in one day, output the message:
Rule 4. If the user's subscription has expired, output the message:
Rule 5. If the user's subscription doesn't expire in 10 days or less, output nothing.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!\nRenew now and save {discountPercentage}%!");
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}

