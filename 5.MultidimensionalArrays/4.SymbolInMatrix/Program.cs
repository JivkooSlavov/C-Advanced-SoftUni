namespace _4.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            char[,] matrix = new char[cols, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] rowValues = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isTrue = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isTrue = true;
                        return;
                    }
                }
            }
            if (isTrue!=true)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}