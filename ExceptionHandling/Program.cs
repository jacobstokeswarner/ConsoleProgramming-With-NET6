// See https://aka.ms/new-console-template for more information

/*
    try - a try block attempts to complete an operation
    catch - tries to catch any fatal errors or exceptions
    finally - whether the try or catch was successful or not, do this no matter what
    throw - end the program execution with the error
 */


Console.WriteLine("Enter first number: ");
int num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = Int32.Parse(Console.ReadLine());
Console.WriteLine();

try
{
    int quotient = num1 / num2;
    Console.WriteLine($"result is:  {quotient}");
}
catch (DivideByZeroException zero)
{
    Console.WriteLine("you cannot divide by Zero: ");
    Console.WriteLine(zero);
}
catch (Exception generic)
{
    Console.WriteLine("there was an error with the application: ");
    Console.WriteLine(generic);
    throw;
}
finally
{
    Console.WriteLine();
    Console.WriteLine("**This is the end of the program**");
}
