using System.Numerics;

namespace _7.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            if (rows<3)
            {
                Console.WriteLine(0);
                return;
            }

            int countRemoved = 0;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] chars = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            while (true)
            {
                int maxAttack = 0;
                int rowMaxAttack = 0;
                int colMaxAttack = 0;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        char currentElement = matrix[row, col];
                        if (currentElement == 'K')
                        {
                            int counterAttackedKnight = CalculateAttackedKnight(row, col, rows, cols, matrix);
                            if (counterAttackedKnight >maxAttack)
                            {
                                maxAttack = counterAttackedKnight;
                                rowMaxAttack = row;
                                colMaxAttack = col;
                            }
                        }
                    }
                }
                if (maxAttack==0)
                {
                    break;
                }
                else
                {
                    matrix[rowMaxAttack, colMaxAttack] = '0';
                    countRemoved++;
                }
            }
            Console.WriteLine(countRemoved);

        }
        static int CalculateAttackedKnight(int row, int col, int rows, int cols, char[,] matrix)
        {
            int count = 0;
            if (IsValid(row - 2, col + 1, rows, cols))
            {
                if (matrix[row-2, col+1] =='K')
                {
                    count++;
                }
            }
            if (IsValid(row - 2, col - 1, rows, cols))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row + 2, col - 1, rows, cols))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row + 2, col + 1, rows, cols))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row -1 , col + 2, rows, cols))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row - 1, col - 2, rows, cols))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row + 1, col + 2, rows, cols))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    count++;
                }
            }
            if (IsValid(row + 1, col - 2, rows, cols))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    count++;
                }
            }

            return count;

        }
        static bool IsValid(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }

    }
}