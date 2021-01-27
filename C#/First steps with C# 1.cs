/*
https://docs.microsoft.com/en-us/learn/modules/csharp-arrays/4-challenge
1. Declare and initialize a new array to hold fake Order IDs
        B123, C234, A345, C15, B177, G3003, C235, B179
2. Use a foreach statement to iterate through each element of the array you just declared and initialized.
3. If the fake Order ID starts with "B", then print the Order ID to the output.
*/

string[] orderID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string id in orderID)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}
