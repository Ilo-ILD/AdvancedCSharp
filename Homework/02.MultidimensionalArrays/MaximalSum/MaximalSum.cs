namespace MaximalSum
{
    using System;

    internal class MaximalSum
    {
        private static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows,colums];
            int[,] best3x3Matrix = new int[3,3];

            for (int row = 0; row < rows; row++)
            {
                for (int colum = 0; colum < colums; colum++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, colum);
                    string inputNumber = Console.ReadLine();
                    matrix[row, colum] = int.Parse(inputNumber);
                }
            }

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLongLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        best3x3Matrix[0, 0] = matrix[row, col];
                        best3x3Matrix[0, 1] = matrix[row, col + 1];
                        best3x3Matrix[0, 2] = matrix[row, col + 2];
                        best3x3Matrix[1, 0] = matrix[row + 1, col + 0];
                        best3x3Matrix[1, 1] = matrix[row + 1, col + 1];
                        best3x3Matrix[1, 2] = matrix[row + 1, col + 2];
                        best3x3Matrix[2, 0] = matrix[row + 2, col + 0];
                        best3x3Matrix[2, 1] = matrix[row + 2, col + 1];
                        best3x3Matrix[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }
            Console.WriteLine(bestSum);
            for (int i = 0; i < best3x3Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < best3x3Matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", best3x3Matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}