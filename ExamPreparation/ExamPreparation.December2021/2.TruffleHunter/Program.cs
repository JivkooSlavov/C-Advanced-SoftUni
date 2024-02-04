using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            string[,] matrix = new string[rows, cols];
            int blackTruffel = 0;
            int whiteTruffel = 0;
            int summerTruffel = 0;
            int truffelEatenByBoar = 0;
            for (int row = 0; row < rows; row++)
            {
                string[] rowValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }
            string input = "";
            while ((input = Console.ReadLine()) != "Stop the hunt")
            {
                string[] command = input.Split().ToArray();
                string action = command[0];
                int rowPosition = int.Parse(command[1]);
                int colPosition = int.Parse(command[2]);
                if (action == "Collect")
                {
                    if (matrix[rowPosition, colPosition] == "S")
                    {
                        summerTruffel++;
                        matrix[rowPosition, colPosition] = "-";
                    }
                    else if (matrix[rowPosition, colPosition] == "B")
                    {
                        blackTruffel++;
                        matrix[rowPosition, colPosition] = "-";
                    }
                    else if (matrix[rowPosition, colPosition] == "W")
                    {
                        whiteTruffel++;
                        matrix[rowPosition, colPosition] = "-";
                    }
                    else
                    {
                        continue;
                    }
                }
                if (action == "Wild_Boar")
                {
                    string direction = command[3];
                        if (direction == "up")
                        {
                        while (IsValidRow(rowPosition, rows))
                        {
                            if (matrix[rowPosition, colPosition] == "S" || matrix[rowPosition, colPosition] == "B" || matrix[rowPosition, colPosition] == "W")
                            {
                                truffelEatenByBoar++;
                                matrix[rowPosition, colPosition] = "-";
                                rowPosition -= 2;
                            }
                            else
                            {
                                rowPosition -= 2;
                            }
                        }
                        }
                        else if (direction == "down")
                        {
                            while (IsValidRow(rowPosition, rows))
                            {
                            if (matrix[rowPosition, colPosition] == "S" || matrix[rowPosition, colPosition] == "B" || matrix[rowPosition, colPosition] == "W")
                            {
                                truffelEatenByBoar++;
                                matrix[rowPosition, colPosition] = "-";
                                rowPosition += 2;
                            }
                            else
                            {
                                rowPosition += 2;
                            }
                        }
                        }
                        else if (direction == "left")
                        {
                            while (IsValidRow(colPosition, cols))
                            {
                            if (matrix[rowPosition, colPosition] == "S" || matrix[rowPosition, colPosition] == "B" || matrix[rowPosition, colPosition] == "W")
                            {
                                truffelEatenByBoar++;
                                matrix[rowPosition, colPosition] = "-";
                                colPosition -= 2;
                            }
                            else
                            {
                                colPosition -= 2;
                            }
                        }
                        }
                        else if (direction == "right")
                        {
                            while (IsValidRow(colPosition, cols))
                            {
                            if (matrix[rowPosition, colPosition] == "S" || matrix[rowPosition, colPosition] == "B" || matrix[rowPosition, colPosition] == "W")
                            {
                                truffelEatenByBoar++;
                                matrix[rowPosition, colPosition] = "-";
                                colPosition += 2;
                            }
                            else
                            {
                                colPosition += 2;
                            }
                        }
                        }
                }

            }
            Console.WriteLine($"Peter manages to harvest {blackTruffel} black, {summerTruffel} summer, and {whiteTruffel} white truffles.");
            Console.WriteLine($"The wild boar has eaten {truffelEatenByBoar} truffles.");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        public static bool IsValidRow(int row, int rows)
        {
            return row >= 0 && row < rows;
        }
        public static bool IsValidCol(int col, int cols)
        {
            return col >= 0 && col < cols;
        }
    }
}
