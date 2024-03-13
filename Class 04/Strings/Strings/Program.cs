Console.WriteLine("Enter any word!");
string input = Console.ReadLine();
Console.WriteLine("The last 5 characters of your word are:");
for (int i = input.Length - 1; i >= input.Length - 5; i--)
{
    Console.WriteLine(input[i]);
}


