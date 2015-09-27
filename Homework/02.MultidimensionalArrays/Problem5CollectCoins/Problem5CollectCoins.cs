namespace Problem5CollectCoins
{
    using System;

    internal class Problem5CollectCoins
    {
        private static int rollPostion;

        private static int collPosition;

        private static int coins;

        private static int wallHits;

        private static void WheraAreYouMove(string fromWhere, string[] matrix)
        {
            foreach (char toWhere in fromWhere)
            {
                switch (toWhere)
                {
                    case '>':
                        Moving(rollPostion, collPosition + 1, matrix);
                        break;
                    case '<':
                        Moving(rollPostion, collPosition - 1, matrix);
                        break;
                    case '^':
                        Moving(rollPostion - 1, collPosition, matrix);
                        break;
                    case 'V':
                        Moving(rollPostion + 1, collPosition, matrix);
                        break;
                    case 'v':
                        Moving(rollPostion + 1, collPosition, matrix);
                        break;
                }
            }
        }

        private static void Moving(int row, int col, string[] matrix)
        {
            if (MovingInside(row, col, matrix))
            {
                collPosition = col;
                rollPostion = row;
                if (matrix[rollPostion][collPosition] == '$')
                {
                    coins++;
                }
            }
            else
            {
                wallHits++;
            }
        }

        private static bool MovingInside(int row, int col, string[] matrix)
        {
            if (row >= 0 && row < matrix.Length)
            {
                if (col >= 0 && col < matrix[row].Length)
                {
                    return true;
                }
            }

            return false;
        }

        private static void Main()
        {
            string[] matrixJagged = new string[4];

            for (int i = 0; i < matrixJagged.Length; i++)
            {
                matrixJagged[i] = Console.ReadLine();
            }

            string directions = Console.ReadLine();

            WheraAreYouMove(directions, matrixJagged);

            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", wallHits);
        }
    }
}