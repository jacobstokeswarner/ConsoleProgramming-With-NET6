// See https://aka.ms/new-console-template for more information

string firstName = "Jacob";
string lastName = "Stokes-Warner";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine("--------------------");
Console.WriteLine("Simply printing a variable to the screen:");
Console.Write(firstName);
Console.Write(" ");
Console.Write(lastName);

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();


// Concatenation
Console.WriteLine("--------------------");
Console.WriteLine("String Concatenation: ");
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("--------------------");
Console.WriteLine();

// Interpolation
Console.WriteLine("--------------------");
Console.WriteLine("String Interpolation: ");
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine("--------------------");
Console.WriteLine();


// String length
Console.WriteLine("--------------------");
Console.WriteLine("Finding the length of a string: ");
Console.WriteLine(firstName.Length);
Console.WriteLine(lastName.Length);
Console.WriteLine("--------------------");
Console.WriteLine();

// Replace string parts
Console.WriteLine("--------------------");
Console.WriteLine("Replacing String Parts: ");
// replacing letter
string newName = firstName.Replace('b','v');
Console.WriteLine(newName);
// removing letter
string newName1 = newName.Replace("o", string.Empty);
Console.WriteLine(newName1);
Console.WriteLine("--------------------");
Console.WriteLine();

// Append to other string variable
Console.WriteLine("--------------------");
Console.WriteLine("Appending To Other String Variable: ");
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);
Console.WriteLine("--------------------");
Console.WriteLine();


// Split String
Console.WriteLine("--------------------");
Console.WriteLine("Split String: ");
string[] splitName = fullName.Split(' ');
foreach (var item in splitName)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

// Compare Strings
Console.WriteLine("--------------------");
Console.WriteLine("Compare Strings: ");
string nullString = null;
string emptyString = ""; // same as string.Empty
string emtpyString2 = string.Empty;
string spaceString = " ";// whitespace
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine($"nullString variable is either null or empty");
}
if (firstName == lastName)
{
    Console.WriteLine("first name and last name is equal");
}

if (lastName != firstName)
{
    Console.WriteLine("first name and last name are not equal");
}

int comparisonResult = string.Compare(firstName, lastName); // value that is not zero shows that the two values are different
if (comparisonResult == 0)
{
    Console.WriteLine("the names are equal");
}
else
{
    Console.WriteLine("the names are not equal");
}
Console.WriteLine("--------------------");
Console.WriteLine();

// Convert to String
Console.WriteLine("--------------------");
Console.WriteLine("Converting to String: ");
string convertedString = string.Empty;
int numbers = 123456789;
convertedString = numbers.ToString();
Console.WriteLine(convertedString);
Console.WriteLine(convertedString.GetType());

Console.WriteLine("--------------------");
Console.WriteLine();
