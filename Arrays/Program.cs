// See https://aka.ms/new-console-template for more information

// Declare Fixed Size array

int[] grades = new int[5]; // 5 space addresses will be stored in memory

// add values to fixed size array
//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

// or in one line:

//grades = new int[] { 1, 25, 38, 45, 54 };

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Enter the value of grade {i + 1}");
    grades[i] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine();

// print values in fixed size array
foreach (int item in grades)
{
    Console.WriteLine(item);
}

// or 
Console.WriteLine();

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare Variable Sized Array
string[] studentNames = new string[] { "Test", "Student1", "etc..." };

// Add values to Variable Sized Array
Console.WriteLine("Enter All Names");

for (int i = 0; i < studentNames.Length; i++)
{
    studentNames[i] = Console.ReadLine();
}

// Print values in Variable Sized Array
foreach (var name in studentNames)
{
    Console.WriteLine(name);
}