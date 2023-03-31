namespace Week2_Assignment
{
    public class FormatNumberPlate
    {
        public void arrangeNumberPlates(string numberPlate, int requiredSpaces)
        {
            string numberWithoutDash;
            while (numberPlate.Contains("-"))
            {
                numberPlate = numberPlate.Replace("-", "");
            }
            numberWithoutDash = numberPlate.ToUpper();
            string finalNumberPlate = addDashesFromRight(numberWithoutDash, requiredSpaces);
            Console.WriteLine($"Correct Order : {finalNumberPlate}");

        }
        public string addDashesFromRight(string S, int count)
        {
            int len = S.Length;
            string result = "";
            int i = len - 1;
            int j = 0;
            while (i >= 0)
            {
                result = S[i] + result;
                j++;
                if (j == count && i != 0)
                {
                    result = "-" + result;
                    j = 0;
                }
                i--;
            }
            return result;
        }
        // public string stringReverse(string S)
        // {
        //     char[] charArray = S.ToCharArray();
        //     string reversedString = "";
        //     for (int i = charArray.Length - 1; i > -1; i--)
        //     {
        //         reversedString += charArray[i];
        //     }
        //     return reversedString;
        // }

        public void runner()
        {
            arrangeNumberPlates("5F3Z-2e-9-w", 4);
            arrangeNumberPlates("2-5g-3-J", 2);
            arrangeNumberPlates("2-4A0r7-4k", 3);
            arrangeNumberPlates("nlj-206-fv", 3);

            // Custom Inputs
            arrangeNumberPlates("hj-2-3-anp-1", 3);
        }
    }
}