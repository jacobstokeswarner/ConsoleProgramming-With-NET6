namespace ClassesAndObjects
{
    static internal class DateUtil
    {
        public static int YearOfBirth(int age)
        {
            return DateTime.Now.Year - age;
        }

        public static int YearOfBirth(DateTime dateOfBirth)
        {
            return dateOfBirth == null ? 0 : dateOfBirth.Year;
        }

        public static int Age(DateTime dateOfBirth)
        {
            return dateOfBirth == null ? 0 : DateTime.Now.Year - dateOfBirth.Year;
        }
    }
}
