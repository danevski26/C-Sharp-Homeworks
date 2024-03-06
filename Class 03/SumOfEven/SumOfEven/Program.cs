

//Make a console application called SumOfEven. Inside it create an array of 6 integers.
//Find and print the sum of the even numbers from the array:

int[] arr = new int[6];
int sumOfEven = 0;

Console.WriteLine("Enter 6 integers");
for (int i =  0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter integer {i + 1}:");
    if (!int.TryParse(Console.ReadLine(), out arr[i]))
    {
        Console.WriteLine("Invalid input! Please enter an integer.");
    }
}


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        sumOfEven += arr[i];
    }
}

Console.WriteLine("The sum of even numbers in this array is: " + sumOfEven);

