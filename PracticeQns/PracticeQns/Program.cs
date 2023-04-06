namespace PracticeQns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var run = new AsyncQn();
            // run.runner();

            // var run1 = new PhotoBookTest();

            //var paycalc = new PayCalc();
            //paycalc.runner();

            // var wordConverter = new RunnerConverter();
            // wordConverter.runner();

            // var combinationRunner = new Combination();
            // combinationRunner.CombinationRunner();

            var encoderRunner = new NicoCipherEncoder();
            encoderRunner.EncoderRunner();
        }
    }
}