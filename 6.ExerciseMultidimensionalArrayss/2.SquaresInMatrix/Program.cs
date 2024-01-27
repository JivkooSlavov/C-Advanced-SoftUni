namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] rowValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValue[col];
                }
            }
            int counterOfequal = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int element = matrix[row, col];
                    bool isRight = matrix[row, col] == matrix[row, col+1];
                    bool isUnder = matrix[row,col] == matrix[row+1, col];
                    bool isDiagonal = matrix[row, col] == matrix[row + 1, col + 1];
                    if (isRight && isDiagonal && isUnder)
                    {
                        counterOfequal++;
                    }
                }
            }
            Console.WriteLine(counterOfequal);
        }
    }
}