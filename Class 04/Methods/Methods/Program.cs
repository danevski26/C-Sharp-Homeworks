public class Program
{
    public static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number with two or more digits!");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = SumOfDigits(number);
        Console.WriteLine($"The sum of the digits in {number} is: {result}");
    }
}
