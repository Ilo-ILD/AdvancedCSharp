namespace Problem4SequenceMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    internal class Problem4SequenceMatrix
    {
        private static void Main()
        {
            string[,] matrix = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
            string[,] matrix2 = { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };

            List<string> result = new List<string>();
            List<string> temp = new List<string>();

            for (int coll = 0; coll < matrix.GetLength(1); coll++)
            {
                for (int col = 1, roww = 1; col < matrix.GetLength(0); col++, roww++)
                {
                    if (matrix[col, roww] == matrix[col - 1, roww - 1])
                    {
                        temp.Add(matrix[col, roww]);
                        if (col == matrix.GetLength(0) - 1)
                        {
                            if (temp.Count > result.Count)
                            {
                                result.Clear();
                                result.AddRange(temp);
                                temp.Clear();
                                temp.Add(matrix[col, roww]);
                            }
                            else
                            {
                                temp.Clear();
                                temp.Add(matrix[col, roww]);
                            }
                        }
                    }
                    else
                    {
                        if (temp.Count > result.Count)
                        {
                            result.Clear();
                            result.AddRange(temp);
                            temp.Clear();
                        }
                        else
                        {
                            temp.Clear();
                        }
                    }
                }
            }
            Console.WriteLine((String.Join(", ", result)));

            ////for (int row = 1; row < matrix2.GetLength(0); row++)
            ////{
            ////    for (int col = 1; col < matrix2.GetLength(1); col++)
            ////    {
            ////        temp.Add(matrix2[0, 0]);
            ////        if (matrix2[row, col] == matrix2[row - 1, col])
            ////        {
            ////            temp.Add(matrix2[row, col]);
            ////            if (row == matrix2.GetLength(0) - 1)
            ////            {
            ////                if (temp.Count > result.Count)
            ////                {
            ////                    result.Clear();
            ////                    result.AddRange(temp);
            ////                    temp.Clear();
            ////                    temp.Add(matrix2[row, col]);
            ////                }
            ////                else
            ////                {
            ////                    temp.Clear();
            ////                    temp.Add(matrix2[row, col]);
            ////                }
            ////            }
            ////        }
            ////        else
            ////        {
            ////            if (temp.Count > result.Count)
            ////            {
            ////                result.Clear();
            ////                result.AddRange(temp);
            ////                temp.Clear();
            ////            }
            ////            else
            ////            {
            ////                temp.Clear();
            ////            }
            ////        }
            ////    }
            ////}
            ////Console.WriteLine((String.Join(", ", result)));
        }
    }
}