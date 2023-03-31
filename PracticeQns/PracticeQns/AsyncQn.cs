namespace PracticeQns
{
    public class AsyncQn
    {
        public async Task guestPickup()
        {
            Console.WriteLine("guest arivved at airport");
            await Task.Delay(3000);
            Console.WriteLine("guest at event !!");
        }
        public async Task stageDecoration(){
            await secureArea();
            Console.WriteLine("Stage Decoration started");
            await Task.Delay(5500);
            Console.WriteLine("Stage Decorated !!");
        }
        public async Task cateringFood()
        {
            await transportFood();
            Console.WriteLine("Food preparation started");
            await Task.Delay(2500);
            Console.WriteLine("Food Prepared !!");
        }
        public async Task transportFood()
        {
            Console.WriteLine("Raw materials picked up..");
            await Task.Delay(1000);
            Console.WriteLine("Raw materials delivered !!");
        }
        public async Task speechReview()
        {
            await guestPickup();
            Console.WriteLine("speech papers received..");
            await Task.Delay(1000);
            Console.WriteLine("speech papers reviewed !!");
        }
        public async Task secureArea()
        {
            Console.WriteLine("Security check started..");
            await Task.Delay(3200);
            Console.WriteLine("Security check ended !!");
        }
        public async Task prizesGet(){
            Console.WriteLine("Picked up prizes from shop");
            await Task.Delay(3000);
            Console.WriteLine("Prizes at stage..");
        }
        public void food(){
            Console.WriteLine("Lunch started ");
            Console.WriteLine("Lunch ended ");

        }
        public void prizesDst()
        {
            Console.WriteLine("prizes distributed");
        }
        public async Task speech()
        {
            // await guestPickup();
            // await stageDecoration();
            // await speechReview();
            // await cateringFood();
            // await secureArea();
            // Task t1 = guestPickup();
            // Task t2 = secureArea();
            Task t3 = stageDecoration();
            Task t4 = speechReview();
            Task t5 = cateringFood();
            Task t6 = prizesGet();
            Task.WaitAll(t3,t6,t4,t5);

            Console.WriteLine("Reviewed Chief guest received papers..");
            await Task.Delay(800);
            Console.WriteLine("speech Delivered !!");
            prizesDst();
            food();
            Console.WriteLine("............ END OF PROGRAM ............");
        }
        public async Task runner(){
            var runner = new AsyncQn();
            // runner.guestPickup();
            // runner.stageDecoration();
            // runner.cateringFood();
            // runner.secureArea();
            Task main = runner.speech();
            Task.WaitAll(main);
            // Console.ReadLine();
        }
    }
}