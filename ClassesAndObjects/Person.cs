namespace ClassesAndObjects
{
    public class Person
    {

        // access modifier, data type, property name, getters and setters

        // Properties when public
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Fields when private
        private double _salary { get; set; }


        public Person()
        {

        }
        public Person(int id, int age, string firstName, string lastName)
        {
            Id = id;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public void SetSalary()
        {
            Console.Write("Please enter your salary: ");
            _salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public double GetSalary()
        {
            return _salary;
        }



        public void MyMethod()
        {
            Console.WriteLine("this is a method inside of a class");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
        }

        public string GetBirthYear()
        {
            Console.Write("Have you already had your birthday this year? (y or n)");
            string response = Console.ReadLine();
            Console.WriteLine();
            if (response == "y")
            {
                DateTime birthday = DateTime.Now.AddYears(Age * -1);
                int birthYear = birthday.Year;
                return birthYear.ToString();
            }
            else if (response == "n")
            {
                DateTime birthday = DateTime.Now.AddYears(Age * -1);
                int birthYear = birthday.Year - 1;
                return birthYear.ToString();
            }
            else
            {
                return "\nYou have chosen an invalid response.You were only supposed to enter y or n.\nRun the program again and press y or n to get correct results";
            }

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}
