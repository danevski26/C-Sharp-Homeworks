//Create a class Dog
//Add properties: Name, breed, color
//The dog needs to have an Eat method that returns message: The dog is now eating.
//A Play method returning a message : The dog is now playing.
//and a ChaseTail method that returns a message: Dog is now chasing its tail.
//The user needs to create a dog object by using inputs and then choose an option to choose one of the methods mentioned above.
//For example, if he enters 1 to call Eat method, if he enters 2 to call Play, if user enters 3 to call Play
bool repeat = true;

    Console.WriteLine("Enter the name of the dog:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter dog's breed:");
    string breed = Console.ReadLine();
    Console.WriteLine("Enter the dog's color:");
    string color = Console.ReadLine();

    Console.WriteLine($"Yor dog's name is {name} and its one beautiful {color} {breed}");

    Dog firstdog = new Dog() { Name = name, Breed = breed, Color = color };
while (repeat)
{
    Console.WriteLine("What do you want your dog to do?\n 1.To Eat \n 2.To Play \n 3.To Chase its tail \n---------------------------\nChoose a number");
    int choice;

    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid input! Please enter a number");
        return;
    }

    switch (choice)
    {
        case 1: Console.WriteLine(firstdog.Eat());
            break;
        case 2: Console.WriteLine(firstdog.Play());
            break;
        case 3: Console.WriteLine(firstdog.ChaseTail());
            break;
        default: Console.WriteLine("Invalid input!");
            break;
    }

    Console.WriteLine($"Press any key if you want to continue hanging out with {name}, if its enough for today press 'X'");
    string toContinue = Console.ReadLine();

    if (toContinue.ToUpper() == "X")
    {
       repeat = false;
    }
}



class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }

    public string Eat()
    {
        return $"{Name} is eating now.";
    }
    public string Play()
    {
        return $"{Name} is playing now";
    }
    public string ChaseTail()
    {
        return $"{Name} is now chasing its tail";
    }
}


