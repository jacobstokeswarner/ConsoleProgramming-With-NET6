// See https://aka.ms/new-console-template for more information

// DRY principle - Don't Repeat Yourself.
// YAGNI - You Ain't Gonna Need It.


// Prototype - Defines the function (type, name and parameters)
// Definition - Has the code. It contains the code block.
// Function Call - Makes the function
Console.WriteLine("this is a function call");

// Void Functions - Completes task and then moves along

void MyMethod()
{
    Console.WriteLine("**This is written using a method!**");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

MyMethod();
Console.WriteLine("This is the end of the void method 'MyMethod'");
Console.WriteLine();

Console.Write("Enter Number 1: ");
int number1 = Int32.Parse(Console.ReadLine());

Console.Write("Enter Number 2: ");
int number2 = Int32.Parse(Console.ReadLine());

Console.Write("Enter Number 3: ");
int number3 = Int32.Parse(Console.ReadLine());


Addition(number1, number2);
Console.WriteLine("This is the end of the void method 'Addition'");
Console.WriteLine();

// Value Returning Functions - Completes a task, returns a result.

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if (largest < num2 )
    {
        largest = num2;
    }

    if(largest < num3)
    {
        largest = num3;
    }

    return largest;
}

int result = LargestNumber(number1, number2, number3);

Console.WriteLine($"The largest number out of the three numbers is: {result}");
Console.WriteLine("This is the end of the returned method");

