// See https://aka.ms/new-console-template for more information

// Declaring a List
List<string> names = new(); // List<string> names = new List<string>();
string name = string.Empty;

// Adding values to a List
names.Add("Jacob");
// removing values
names.Remove("Jacob");

// LISTS ARE FAR MORE DYNAMIC THAN ARRAYS

// adding values more dynamically

Console.WriteLine("Enter Names: ");

while (name != "-1")
{
    Console.WriteLine("Enter a name. If you are done, enter -1");
    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was inserted successfully");
    }


}

// writing our dynamic values
Console.WriteLine("Printing items in list using foreach Loop");
foreach (string s in names)
{
    Console.WriteLine(s);
}

// or 
Console.WriteLine("Printing items in list using for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}