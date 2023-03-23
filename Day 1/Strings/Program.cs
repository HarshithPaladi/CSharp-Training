namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello");
            int a1 = 12;
            //Console.WriteLine(a); //From Visual Studio
            string b1 = "A";
            string c1 = "a";
            string d1 = "Test";
            //Console.WriteLine(b.Substring(2)+" "+c.Substring(0,7)+" "+d);
            Console.WriteLine(string.Concat(b1,c1));
            Console.WriteLine(b1.TrimEnd()+c1);
            Console.WriteLine(b1.TrimEnd() + c1.Trim());
            Console.WriteLine("Comparision of 2 strings");
            Console.WriteLine(string.Compare(b1,c1,StringComparison.Ordinal));

            // 
            string a = "Hello world";
            string[] c = a.Split("l");
            foreach (string s in c)
            {
                Console.WriteLine(s);
            }
           
           String day = "Tuesday";
           String name = Console.ReadLine();
           String exp = $"Today is {day} and welcome {name}";
           Console.WriteLine(exp);
           
           string a = "hello";
           String b = "Hello";
           bool result = a.Equals(b,StringComparison.OrdinalIgnoreCase);
           Console.WriteLine(result);
           Console.WriteLine(a+" "+b);
           Console.WriteLine(a.Substring(2));
           Console.WriteLine(b.Substring(0, 3));
           Console.WriteLine(a.Substring(3));
           b = "Hello";
           Console.WriteLine(String.Concat(a,b));
           Console.WriteLine(String.Compare(a,b));
           Console.WriteLine(String.Compare(a,b,true));
           a = "a";
           b = "";
           Console.WriteLine(String.Compare(a,b,StringComparison.Ordinal));
           Console.WriteLine(String.Compare(a,b,StringComparison.OrdinalIgnoreCase));
           


static void passbyvalue(int x)
{
    x = 1;
    Console.WriteLine("in value fun", x);
}
static void passbyrefrence(ref int x)
{
    x = 1;
    Console.WriteLine("in ref function", x);
}

int a = 10;
passbyvalue(a);
Console.WriteLine("after by value ",a);
passbyrefrence(ref a);
Console.WriteLine("after by ref",a);
String name = Console.ReadLine();

for(int i = 0; i <name.Length; i++)
{
    Console.WriteLine(name[i]);
}
Console.WriteLine("Hello, World!");




String val;
int a, b, choice;
bool repeat;
do
{
    Console.WriteLine("enter the operands\n");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    //val = Console.ReadLine();
    //a = Console.ToInt32()
    //a = 1;
    //b = 2;
    Console.WriteLine("SELECT RESPECTIVE OPTION:\n");
    Console.WriteLine("1.TO ADD \n2.SUBTRACT \n3.MULTIPY\n4.DIVIDE");
    choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1: 
            Console.WriteLine("RESULT: ",a + b);
            break;
        case 2: 
            Console.WriteLine("RESULT: ", a - b);
            break;
        case 3: Console.WriteLine("RESULT: ", a * b);
            break;
        case 4:
            Console.WriteLine("RESULT: ", a / b);
            break;
        default: Console.WriteLine("choose between 1-4");
            break;
        }
    Console.WriteLine("perform another operation y/n?");
    val = Console.ReadLine();
    repeat = (val == "y")  ? true : false;
} while (repeat);

*/

/*
int a = 2;
if(a==1)
{
    goto print;
}
else
{
    goto jump;
}
print:
{
    Console.WriteLine("a is 1");
    Console.ReadLine();
}
jump:
{
    Console.WriteLine("a is not 1");
    Console.ReadLine();
}


}
}
}
