// See https://aka.ms/new-console-template for more information

using System.Globalization;

// -- DateTime is a data type in C#, it is not a primitive data type

// Empty DateTime

DateTime date = new();// DateTime date = new DateTime();

// Create a DateTime from Date and Time
DateTime dateOfBirth = new(1999, 8, 23, 9, 25, 0);
Console.WriteLine(dateOfBirth);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine(now);

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine(dateFromString);

// Add Additional Time

// what is an hour from the current time?

DateTime oneHourFromNow = now.AddHours(1);
Console.WriteLine(oneHourFromNow);

// Ticks From DateTime
// a tick is the number of clock ticks since time was being calculated
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine(dateOnlyOfBirth);

// Time Only
TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(currentTime);

// Day of the year
Console.WriteLine(dateOfBirth.DayOfYear);

// Day of the Week
Console.WriteLine(dateOfBirth.DayOfWeek);
