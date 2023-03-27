using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveningProblems
{
    public class MaxProfit
    {
        public void MaxProfitAttainable(int []Prices)
        {
            int MaxProfit = 0;
            int BuyingDay = -1;
            int SellingDay = -1;

            for(int i = 0; i < Prices.Length; i++)
            {
                for(int j = i; j < Prices.Length; j++)
                {
                    if ((Prices[j] - Prices[i]) > MaxProfit)
                    {
                        MaxProfit = Prices[j] - Prices[i];
                        BuyingDay = i;
                        SellingDay = j;
                    }
                }
            }
            Console.WriteLine($"Buy on {BuyingDay} and Sell on {SellingDay} to get a Max profit of {MaxProfit}");
            
        }
        


    }
}
