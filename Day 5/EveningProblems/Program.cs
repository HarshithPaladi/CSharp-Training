namespace EveningProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[] price = { 7, 1, 5, 3, 6, 4 };
            
            MaxProfit maxProfit = new MaxProfit();
            maxProfit.MaxProfitAttainable(price);

            SpiralMatrix spiralMatrix = new SpiralMatrix();
            spiralMatrix.SpiralMatrixMain();
        }
    }
}