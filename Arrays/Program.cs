namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] a = { 1, 2, 3 };
            int[] b = { 10, 20, 30 };
            Console.WriteLine("From for loop");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("From foreach loop");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            PrintAnArray(b);
            // Multi-Dimensional Arrays
            int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] b2 = new int[3, 3];
            b2[0, 1] = 2;
            b2[1, 2] = 3;
            Console.WriteLine("2D-Arrays");
            for (int k = 0; k < a2.GetLength(0); k++) // Getting length of no.of.eles in rows
            {
                for (int l = 0; l < a2.GetLength(1); l++)
                {
                    Console.Write($"({k},{l}): " + a2[k, l] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Inside Foreach loop");
            foreach (int k in a2)
            {
                Console.Write(k);
            }
            Console.WriteLine("Not all values are declared");
            foreach(int k in b2)
            {
                Console.Write(k);
            }
            // Jagged Array
            int[][] jagged_arr = new int[2][];
            jagged_arr[0]= new int[] {1,2};
            jagged_arr[1]= new int[] {3,4};
            Console.WriteLine("\nJagged Arrays");
            for(int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.Write(jagged_arr[i][j] + " "); 
                }
            }

        }

        public static void PrintAnArray(int[] f) 
        {
            Console.WriteLine("From PrintAnArray using array");
            foreach (int j in f)
            {
                Console.WriteLine(j);
            }
        }
    }
}