namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = words[col];
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                string[] splitCommand = command.Split();
                string operations = splitCommand[0];
                if (operations == "swap" && splitCommand.Length == 5)
                {
                    int row1 = int.Parse(splitCommand[1]);
                    int col1 = int.Parse(splitCommand[2]);
                    int rowReplace = int.Parse(splitCommand[3]);
                    int colReplace = int.Parse(splitCommand[4]);

                    if (row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols && rowReplace >= 0 && rowReplace < rows && colReplace >= 0 && colReplace < cols)
                    {
                        string element1 = matrix[row1, col1];
                        string element2 = matrix[rowReplace, colReplace];

                        matrix[row1, col1] = element2;
                        matrix[rowReplace, colReplace] = element1;
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
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