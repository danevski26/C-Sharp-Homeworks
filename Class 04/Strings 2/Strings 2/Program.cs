Console.WriteLine("Enter one sentence!");
string input2 = Console.ReadLine();
string[] words = input2.Split(' ');
Console.WriteLine("The words in your sentence are:");
foreach (string word in words)
{
    Console.WriteLine(word);
}