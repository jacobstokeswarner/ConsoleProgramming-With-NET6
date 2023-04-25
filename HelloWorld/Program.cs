namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string number = Convert.ToString(5);
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Hello {number}");

        }
    }
}