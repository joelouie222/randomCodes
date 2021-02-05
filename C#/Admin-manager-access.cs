/*
Step 1 - Delete all of the code in the .NET Editor from the earlier exercise.
Step 2: Add code as a starting point
    string permission = "Admin|Manager";
    int level = 55;

Step 3 - Implement business rules
Business Rules
    If the user is an Admin with a level greater than 55, output the message:           Welcome, Super Admin user.
    If the user is an Admin with a level less than or equal to 55, output the message:  Welcome, Admin user.
    If the user is a Manager with a level 20 or greater, output the message:            Contact an Admin for access.
    If the user is a Manager with a level less than 20, output the message:             You do not have sufficient privileges.
    If the user is not an Admin or a Manager, output the message:                       You do not have sufficient privileges.

Step 4 - Make sure you get the output given the sample data:    Welcome, Admin user.
https://docs.microsoft.com/en-us/learn/modules/csharp-evaluate-boolean-expressions/7-solution-2
*/


string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else
    Console.WriteLine("You do not have sufficient privileges.");

