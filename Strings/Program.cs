namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello");
            int a = 12;
            //Console.WriteLine(a); //From Visual Studio
            string b = "A";
            string c = "a";
            string d = "Test";
            //Console.WriteLine(b.Substring(2)+" "+c.Substring(0,7)+" "+d);
            Console.WriteLine(string.Concat(b,c));
            Console.WriteLine(b.TrimEnd()+c);
            Console.WriteLine(b.TrimEnd() + c.Trim());
            Console.WriteLine("Comparision of 2 strings");
            Console.WriteLine(string.Compare(b,c,StringComparison.Ordinal));

        }
    }
}
