namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {// 1
            Console.WriteLine("Welcome to Magic!!!");
            Console.Write("!! Enter your name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Morning or Night Person?? ");
            string mn = Convert.ToString(Console.ReadLine());
            Console.Write("Introvert or Extrovert?? ");
            string ie = Convert.ToString(Console.ReadLine());
            if( mn == "Morning" && ie == "Introvert")
            {
                Console.WriteLine("Ahh a logical person");
            }
            else if (mn == "Night" && ie == "Extrovert")
            {
                Console.WriteLine("Party Person");
            }
            else if (mn == "Night" && ie == "Introvert")
            {
                Console.WriteLine("Must watch a lot of Series");

            }
            else
            {
                Console.WriteLine("The Person");
            }
            // 2

            Console.Write("Enter your birth month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            /*string Zodiac;
            switch (month)
            {
                case 1:
                    Zodiac = "Capricorn";
                    break;
                    
            }
            */
            // 3

            Console.Write("Enter birth year (YYYY): ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter birth day (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime present = DateTime.Today;
            int age = present.Year - year;
            if(present.Month < month || (present.Month == month && present.Day < day))
            {
                age--;
            }
            Console.WriteLine($"You are {age} years old");

            DateTime NextBirthday = new DateTime(present.Year,month,day);
            if(NextBirthday < present)
            {
                NextBirthday = NextBirthday.AddDays(1);
            }
            int daysTillNext = (NextBirthday - present).Days;
            Console.WriteLine
                ($"Next birthday in {daysTillNext} days");


        }
    }
}