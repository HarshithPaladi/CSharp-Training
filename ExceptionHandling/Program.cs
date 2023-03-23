namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1  c1 = new Class1();
            int a = 10;
            int b = 0;
            int[] d = {a, b};
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine()); 
            try
            {
                CheckAge(age);
                Console.WriteLine("You are eligible to vote\n");
            }
            catch(MyException me)
            {
                Console.WriteLine(me.Message);
            }
            try
            {
                int c = a / b;
                Console.WriteLine(d[5]);
            }
            catch (DivideByZeroException dz) 
            {
                Console.WriteLine(dz.Message);
                Console.WriteLine("Do not try to divide by 0\n");
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
                Console.WriteLine("You are trying to access a index which is not present");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception - "+e.Message);
                Console.WriteLine("Catching Exceptions since some time");
            }
            finally 
            { 
                Console.WriteLine("Finally finished"); 
            }
            
        }
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new MyException("You should be above 18 to be eligible for voting");
            }
        }
        // Custom Exceptions
        public class MyException : Exception
        {
            public MyException(string msg) : base(msg) 
            {

            }
        }
    }
}