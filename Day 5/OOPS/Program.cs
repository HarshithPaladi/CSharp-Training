namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var obj = new Oops_test.Priv_Oops();
            //obj.Method2();
            //var Obj2 = new Program();
            //var Obj2 = new AccessSpecifiers();
            //Obj2.Display("Test here");
            //Console.WriteLine(Obj2.name);

            // Inheritance
            var Volvo = new VolvoSports();
            Volvo.MaxSpeed(40);
            Volvo.ABS();
            Volvo.Test();
            Volvo.Sportmethod();

            // Overloading
            var load = new oops2();
            load.OverLoading("Harshith", "Paladi", oops2.days.Tuesday);
            load.OverLoading("Harshith", 21);

            // Aggregration
            AggregrationEx.Marks m = new AggregrationEx.Marks(290, 5);
            AggregrationEx.Student student = new AggregrationEx.Student("cm", 20, 29, 2, m);

            // Sealed
            //Puppy pup = new Puppy();
            //pup.Sound();

            // abstraction
            var obje = new MyClass();
            obje.method(10, 20);
            obje.normal_meth(30, 40);

            // Interfaces
            child c = new child();
            c.show();
            c.calculate(1);
            c.display("Harshith");
        }
    }
}