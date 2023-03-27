using OOPS;
namespace OOPS1
{
    internal class MainClass : AccessSpecifiers
    {
        static void Main(string[] args)
        {
            var Obj2 = new MainClass();
            Obj2.Display("Test here");
            Console.WriteLine(Obj2.name);
        }
    }
}