// See https://aka.ms/new-console-template for more information
// program written in dotnet 6

// this line prints hello world
Console.WriteLine("Hello, World!");

/*
 This is a block comment
*/

// statements:
/*Sequence*/
Console.WriteLine("this is a statement"); // ends with a semicolon;

// variables
var name = "Jacob";

/*Decisions*/
// this is a block of code.
if (name == "Jacob")
{
    Console.WriteLine(name);
}
else
{
    Console.WriteLine("The name is not Jacob");
}

// indentation is good so that everything works correctly

/*Repitition*/

// loops

for(int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}

static string NewMethod()
{
    return "This is a method";
}

Console.WriteLine(NewMethod());