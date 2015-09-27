namespace FilltheMatrix
{
    using System;

    internal class FilltheMatrix
    {
        private static void Main()
        {
            int[,] intMatrix = new int[4, 4];

            Console.Write("Please select A or B: ");
            var input = Console.ReadLine().ToLower();

            if (input == "a")
            {
                PatternA(intMatrix);
            }
            else
            {
                PatternB(intMatrix);
            }

            for (int row = 0; row < intMatrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLongLength(1); col++)
                {
                    Console.Write(" {0} ", intMatrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void PatternA(int[,] intMatrix)
        {
            for (int row = 0, count = 1; row < intMatrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLongLength(1); col++)
                {
                    intMatrix[col, row] = count;
                    count++;
                }
            }
        }

        private static void PatternB(int[,] intMatrix)
        {
            for (int row = 0, count = 0; row < intMatrix.GetLongLength(0); row++)
            {
                if (row % 2 != 0)
                {
                    count = 5 + (4 * row);
                    count--;
                }
                else
                {
                    count++;
                }

                for (int col = 0; col < intMatrix.GetLongLength(1); col++)
                {
                    if (row % 2 != 0)
                    {
                        intMatrix[col, row] = count - (1 * col);
                    }
                    else
                    {
                        intMatrix[col, row] = count + (1 * col);
                    }
                }
            }
        }
    }
}