using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveningProblems
{
    internal class SpiralMatrix
    {
        // SpiralMatrix
        static void FillMatrix(int[,] matrix, int m, int n)
        {
            int num = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }
        }
        public void SpiralMatrixMain()
        {
            int m;
            int n;
            //Getting m,n values from user
            Console.WriteLine("Enter the number of rows");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            n = Convert.ToInt32(Console.ReadLine());
            //Creating a matrix
            int[,] matrix = new int[m, n];
            //Calling the method to fill the matrix
            FillMatrix(matrix, m, n);
            //Method to print the matrix in normal form
            Console.WriteLine("The matrix in normal form is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Method to print the matrix in spiral form
            Console.WriteLine("The matrix in spiral form is");
            int k = 0, l = 0;
            while (k < m && l < n)
            {
                for (int i = l; i < n; ++i)
                {
                    Console.Write(matrix[k, i] + " ");
                }
                k++;
                for (int i = k; i < m; ++i)
                {
                    Console.Write(matrix[i, n - 1] + " ");
                }
                n--;
                if (k < m)
                {
                    for (int i = n - 1; i >= l; --i)
                    {
                        Console.Write(matrix[m - 1, i] + " ");
                    }
                    m--;
                }
                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                    {
                        Console.Write(matrix[i, l] + " ");
                    }
                    l++;
                }
            }
        }
    }
}
