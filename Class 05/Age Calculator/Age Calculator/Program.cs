//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today
int age;
    Console.WriteLine("Enter your birthday YYYY-MM-DD and I will tell you how old are you :)");
    string input = Console.ReadLine();
    DateTime birthday;
    if (!DateTime.TryParse(input, out birthday))
    {
        Console.WriteLine("Invalid date format. Please enter it like this: YYYY-MM-DD");
        return;
    }
void AgeCalculator()
{
    DateTime today = DateTime.Today; 
    age = today.Year - birthday.Year;
    if (birthday > today.AddYears(-age))
        age--;
    Console.WriteLine($"You are {age} years old :)");
}
AgeCalculator();

