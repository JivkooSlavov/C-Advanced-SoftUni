namespace _3.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }
            int maxSquareRow = 0;
            int maxSquareCol = 0;
            int maxSquareSum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSquare = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col+1]
                        + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSquare > maxSquareSum)
                    {
                        maxSquareSum = currentSquare;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSquareSum}");
            Console.WriteLine($"{matrix[maxSquareRow, maxSquareCol]} {matrix[maxSquareRow, maxSquareCol + 1]} {matrix[maxSquareRow, maxSquareCol + 2]}");
            Console.WriteLine($"{matrix[maxSquareRow+1, maxSquareCol]} {matrix[maxSquareRow+1, maxSquareCol+1]} {matrix[maxSquareRow+1, maxSquareCol + 2]}");
            Console.WriteLine($"{matrix[maxSquareRow+2, maxSquareCol]} {matrix[maxSquareRow+2, maxSquareCol + 1]} {matrix[maxSquareRow + 2, maxSquareCol + 2]}");
        }
    }
}