//Make a new console application called StudentGroup
//using static System.Net.Mime.MediaTypeNames;
//using System.Diagnostics.Metrics;

//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko


string[] studentsG1 = new string[5]{ "Marko", "Petar", "Simon", "Pavle", "Naum" };
string[] studentsG2 = new string[5] { "Pavel", "Zvonko", "Angele", "Bob", "John" };

Console.WriteLine("Choose which group of students you want to see: Type G1 for the first, or type G2 for the second.");
string nameOfArr = Console.ReadLine();
switch (nameOfArr)
{
    case "G1":
        Console.WriteLine("The students in G1 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
        break;
    case "G2":
        Console.WriteLine("The students in G2 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
        break;
    default: Console.WriteLine("Invalid input! Please enter G1 or G2.");break;
}