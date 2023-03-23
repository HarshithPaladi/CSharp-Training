namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int[] d = {a, b};
            try
            {
                //int c = a / b;
                Console.WriteLine(d[5]);
            }
            catch (DivideByZeroException dz) 
            {
                Console.WriteLine(dz.Message);
                Console.WriteLine("Do not try to divide by 0");
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
    }
}