//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
int num1 = 10;
int num2 = 15;
int operation = '+';
int adding = num1 + num2;
int division = num1 / num2;
int subtraction = num1 - num2;
int multiplication = num1 * num2;
string result = "The result is: ";
switch (operation)
{
    case '+': Console.WriteLine(result + adding); break;
    case '-': Console.WriteLine(result + subtraction); break;
    case '/': Console.WriteLine(result + division); break;
    case '*': Console.WriteLine(result + multiplication); break;
}