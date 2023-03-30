using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Polymorphism
    {
        public int subCalc(List<int> nums)
        {
            int temp = 2 * nums[0];
            foreach (int i in nums)
            {
                temp -= i;
            }
            return temp;
        }
        public void printer(string opnChoice,int val){
            Console.WriteLine("--------------------------");
            Console.WriteLine($"{opnChoice}: {val}");
            Console.WriteLine("--------------------------");
        }
        public void runner()
        {
            Console.WriteLine("Enter numbers: ");
            List<int> nums = Array.ConvertAll(Console.ReadLine().Trim().Split(" ").ToArray(), int.Parse).ToList();
            int sum = nums.Sum();
            int sub = subCalc(nums);
            Console.WriteLine("Enter mode (normal/opposite): ");
            string modeChoice = Console.ReadLine();
            Console.WriteLine("Enter Operation (add/sub): ");
            string opnChoice = Console.ReadLine();
            if (modeChoice == "normal")
            {
                if (opnChoice == "add") printer("Addition",sum);
                else printer("Subtraction",sub);
            }
            else{
                if(opnChoice=="add") printer("Subtraction",sub);
                else printer("Addition",sum);
            }


        }
    }
}
