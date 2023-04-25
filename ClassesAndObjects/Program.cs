// See https://aka.ms/new-console-template for more information

using ClassesAndObjects; // need this to use the class in another file

// primitive data types
//int, string, char, bool

// Object Oriented Program (OOP) - Creating Your Own DataTypes

// Class - Like a blueprint of what the object is going to be

// Single Responsibility Principle - Let each unit have only one responsibility

string middleName = string.Empty;

Console.WriteLine("Enter your First Name: ");
string firstName1 = Console.ReadLine();

Console.WriteLine("Enter your Last Name: ");
string lastName1 = Console.ReadLine();

Console.WriteLine("Enter your Age: ");
int age1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your middle name: ");
middleName = Console.ReadLine();





Person person1 = new(1, age1, firstName1, lastName1);// Person person1 = new Person(1, age1, firstName1, lastName1);

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine(person1.GetFullName());
}
else
{
    Console.WriteLine(person1.GetFullName(middleName));
}

Person person2 = new(2, 19, "Desiree", "Stokes-Warner");

Console.WriteLine("Enter your First Name: ");
string firstName2 = Console.ReadLine();

Console.WriteLine("Enter your Last Name: ");
string lastName2 = Console.ReadLine();

Console.WriteLine("Enter your Age: ");
int age2 = Int32.Parse(Console.ReadLine());


Person person3 = new();

person3.Id = 3;
person3.FirstName = firstName2;
person3.LastName = lastName2;
person3.Age = age2;

person3.SetSalary();

Console.Write("The salary of person3 is: ");
Console.WriteLine(person3.GetSalary());
Console.WriteLine();

//person1.MyMethod();

person1.PrintInfo();
Console.WriteLine($"Birth Year of Person 1: {person1.GetBirthYear()}");
Console.WriteLine();

person2.PrintInfo();
Console.WriteLine();

person3.PrintInfo();
Console.WriteLine();

Console.WriteLine();

DateTime testAge = new(1999, 8, 23);

DateUtil.Age(testAge);