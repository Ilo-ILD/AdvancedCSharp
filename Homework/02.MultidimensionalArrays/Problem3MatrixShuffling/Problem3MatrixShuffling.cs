namespace Problem3MatrixShuffling
{
    using System;
    using System.Linq;

    internal class Problem3MatrixShuffling
    {
        private static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, colums];

            for (int row = 0; row < rows; row++)
            {
                for (int colum = 0; colum < colums; colum++)
                {
                    string inputNumber = Console.ReadLine();
                    matrix[row, colum] = inputNumber;
                }
            }

            while (true)
            {
                string[,] tempCordinati = new string[1, 1];
                string[,] tempCordinati2 = new string[1, 1];

                string[] readLineComand = Console.ReadLine().Split(' ').ToArray();

                int x = 0;
                int x1 = 0;
                int y = 0;
                int y1 = 0;

                if (readLineComand[0] == "END" || readLineComand.Length == 0)
                {
                    return;
                }

                for (int i = 1; i < readLineComand.Length; i++)
                {
                    if (i == 1)
                    {
                        x = int.Parse(readLineComand[i]);
                    }
                    else if (i == 2)
                    {
                        x1 = int.Parse(readLineComand[i]);
                    }
                    else if (i == 3)
                    {
                        y = int.Parse(readLineComand[i]);
                    }
                    else if (i == 4)
                    {
                        y1 = int.Parse(readLineComand[i]);
                    }
                }

                if (x <= readLineComand.Length || x1 <= readLineComand.Length || y <= readLineComand.Length
                    || y1 <= readLineComand.Length)
                {
                    if (readLineComand[0] == "swap")
                    {
                        tempCordinati[0, 0] = matrix[x, x1];   
                        tempCordinati2[0, 0] = matrix[y, y1]; 
                        matrix[x, x1] = matrix[y, y1];        
                        matrix[y, y1] = tempCordinati[0, 0];  

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(" {0}", matrix[row, col]);
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}