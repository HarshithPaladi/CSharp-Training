namespace DelegatesCont
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             var calculation = new System.Diagnostics.Stopwatch();
            // //var test = new prediAcnFnc();
            // //test.prediAcnFncRun();
            // //Console.WriteLine("---------------------");
            calculation.Start();

            var test1 = new AsyncProg();
            AsyncProg.AsyncProgRunAsync();
            // test1.Method1();
            // Console.WriteLine("Method3 is starting...");
            // int ans = test1.Method3().Result;
            // Console.WriteLine("Ans is " + ans);
             calculation.Stop();
             Console.WriteLine("Elaspsed Time: " + calculation.ElapsedMilliseconds);
            // Console.ReadLine();


            //var test2 = new Async2();
            //await test2.Main();

        }

    }
}