// See https://aka.ms/new-console-template for more information

// Variable Declarations and Types
string fullName = string.Empty;
int age = 0;
double salary = 0.0;
float floatSalary = 0.0f;
decimal decimalSalary = 0.0M;
char gender = char.MinValue;
bool working = false; // if booleans aren't given a value, they automatically default to false

// getting user to give us all the answers to these varables

Console.ForegroundColor = ConsoleColor.Green;


Console.Write("Please enter your name: ");
Console.ForegroundColor= ConsoleColor.Cyan;
fullName = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Please enter your age: ");
Console.ForegroundColor = ConsoleColor.Cyan;
age = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Please enter your salary (double): ");
Console.ForegroundColor = ConsoleColor.Cyan;
salary = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Please enter your salary (float): ");
Console.ForegroundColor = ConsoleColor.Cyan;
floatSalary = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Please enter your salary (decimal): ");
Console.ForegroundColor = ConsoleColor.Cyan;
decimalSalary = decimal.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Please enter your gender (m or f): ");
Console.ForegroundColor = ConsoleColor.Cyan;
gender = char.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Are you currently working? (enter true or false): ");
Console.ForegroundColor = ConsoleColor.Cyan;
working = bool.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("These are the answers that you have provided for us:");
Console.WriteLine($"Full name: {fullName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary in double form: {salary}");
Console.WriteLine($"Salary in float form: {floatSalary}");
Console.WriteLine($"Salary in decimal form: {decimalSalary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Currently working: {working}");

Console.ForegroundColor = ConsoleColor.DarkGray;

