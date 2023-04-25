// See https://aka.ms/new-console-template for more information

// If Statements (==,<,>,>=,<=,!=)
Console.WriteLine("If Statements");
Console.WriteLine("--------------------");


Console.WriteLine("Enter First Number: ");
int num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter First Number: ");
int num2 = Int32.Parse(Console.ReadLine());

if (num1 > num2 )
{
    Console.WriteLine($"Number 1 ({num1}) is greater than Number 2 ({num2})");
}
else if (num1 < num2)
{
    Console.WriteLine($"Number 1 ({num1}) is less than Number 2 ({num2})");
}
else if (num1 == num2)
{
    Console.WriteLine($"The two numbers are equal");
}
else
{
    Console.WriteLine("Invalid Input");
}
Console.WriteLine();
Console.WriteLine("Switch Statement:");
Console.WriteLine("--------------------");

// Switch Statements
Console.WriteLine("Enter Grade: ");
char grade = char.Parse(Console.ReadLine().ToLower());

switch (grade)
{
    case 'a':
        Console.WriteLine("A");
        break;

    case 'b':
        Console.WriteLine("B");
        break;
    case 'c':
        Console.WriteLine("C");
        break;
    case 'd':
        Console.WriteLine("E");
        break;
    case 'f':
        Console.WriteLine("F");
        break;
    default:
        Console.WriteLine("Invalid Input, or error processing");
        break;
}

switch (grade)
{
    case char x when x == 'a' || x == 'b' || x== 'c':
        Console.WriteLine("You received a decent grade");
        break;
    case char x when x == 'd':
        Console.WriteLine("You are very close to failing...");
        break;
    case 'f':
        Console.WriteLine("You received a failing grade.");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

Console.WriteLine();
Console.WriteLine("Ternary Operator:");
Console.WriteLine("--------------------");

// Ternary Operators

string message = num1 > num2 ? "greater than" : num1 < num2 ? "less than" : "equal to";

Console.WriteLine($"Number 1 ({num1}) is {message} Number 2 ({num2})");
