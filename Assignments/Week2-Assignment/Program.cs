namespace Week2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            Console.WriteLine("-------------------------");

            var run1 = new FormatNumberPlate();
            run1.runner();

            Console.WriteLine("-------------------------");

            Console.WriteLine("Question 2");
            var run2 = new DriverLicense();
            run2.runner();
            Console.WriteLine("-------------------------");

        }
    }
}