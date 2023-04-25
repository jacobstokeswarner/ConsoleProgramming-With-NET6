// See https://aka.ms/new-console-template for more information

var watch = new System.Diagnostics.Stopwatch();

watch.Start();

// For Loop (counter controlled)
for (int i = 1; i <= 1000000000; i++)
{

}
watch.Stop();
Console.WriteLine();
Console.WriteLine("FOR LOOP FINISHED");

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
Console.WriteLine();

// While Loop (condition controlled)

int counter = 0;
while (counter < 5)
{
    Console.WriteLine("Input a number: ");
    counter = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"You entered {counter}");
}
Console.WriteLine();
Console.WriteLine("WHILE LOOP FINISHED");

// Do.. While Loop (condition controlled - Post Check)
int n = 10;
do
{
    Console.WriteLine("Input a number: ");
    n = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
} while (n < 5);

// For Each - Honorable mention
//foreach (var item in args)
//{
    
//}
