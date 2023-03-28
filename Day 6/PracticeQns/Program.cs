namespace PracticeQns
{
    class Program
    {
        public int[,] RotateMatrix(int[,] oldMatrix)
        {
            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newRow=0;
            int newCol;
            for (int oldCol = 0; oldCol < oldMatrix.GetLength(1); oldCol++)
            {
                newCol = 0;
                for(int oldRow = oldMatrix.GetLength(0)-1;oldRow>=0; oldRow--)
                {
                    newMatrix[newRow,newCol] = oldMatrix[oldRow,oldCol];
                    newCol++;
                }
                newRow++;
            }
            return newMatrix;
        }
        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var rot = new Program();
            int[,] mat = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] rotmat = rot.RotateMatrix(mat);
            rot.PrintMatrix(rotmat);
        }
    }
}