namespace Generics;
class Generic<T>
{
    public Generic(T message)
    {
        Console.WriteLine(message);
    }
}
// We cannot write main method in Generic class
class Test
{
    public static void Main(string[] args)
    {
        Generic<string> cp = new Generic<string>("Working");
        Generic<int> cp1 = new Generic<int>(12);
        Generic<float> cp2 = new Generic<float>(66.8f);
        GenericMethod gm = new GenericMethod();
        //gm.Test("String");
        //gm.Test(24);
    }
}
