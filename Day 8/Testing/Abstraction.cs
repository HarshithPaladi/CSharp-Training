using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Abstraction_LuckyNumberPredictor
    {
        public void luckyNumberPredictor(int dob)
        {
            var secret = new NumberPredictor();
            int luckyNumber = secret.luckyNumberPredictor(dob);
            Console.WriteLine($"Your lucky number is {luckyNumber}");
        }

    }
    public class NumberPredictor
    {
        public int luckyNumberPredictor(int number)
        {
            int predictedNumber = nearestFibonacciNumber(number);
            return predictedNumber;
        }
        public int unluckyNumberPredictor(int number)
        {
            return -1;
        }
        public int nearestFibonacciNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            int first = 0;
            int second = 1;
            int third = first + second;
            while (third <= number)
            {
                first = second;
                second = third;
                third = first + second;
            }
            int N = (Math.Abs(third - number) >= Math.Abs(second - number)) ? second : third;
            return N;
        }
    }
}
