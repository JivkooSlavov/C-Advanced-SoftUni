namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[rows, cols];
            int currentRow = 0;
            int currentCol = 0;
            int coals = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = symbols[col];
                    if (symbols[col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (symbols[col] == 'c')
                    {
                        coals++;
                    }
                }
            }

            foreach (string direction in directions)
            {
                if (direction == "left")
                {
                    if (currentCol - 1 >= 0 && currentCol - 1 < cols)
                    {
                        currentCol--;
                        char currentElement = matrix[currentRow, currentCol];
                        if (currentElement == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                        else if (currentElement == 'c')
                        {
                            coals--;
                            matrix[currentRow, currentCol] = '*';
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }

                    }
                }
                else if (direction == "right")
                {
                    if (currentCol + 1 >= 0 && currentCol + 1 < cols)
                    {
                        currentCol++;
                        char currentElement = matrix[currentRow, currentCol];
                        if (currentElement == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                        else if (currentElement == 'c')
                        {
                            coals--;
                            matrix[currentRow, currentCol] = '*';
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }

                    }

                }
                else if (direction == "up")
                {
                    if (currentRow - 1 >= 0 && currentRow - 1 < rows)
                    {
                        currentRow--;
                        char currentElement = matrix[currentRow, currentCol];
                        if (currentElement == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                        else if (currentElement == 'c')
                        {
                            coals--;
                            matrix[currentRow, currentCol] = '*';
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }

                    }

                }
                else if (direction == "down")
                {
                    if (currentRow + 1 >= 0 && currentRow + 1 < rows)
                    {
                        currentRow++;
                        char currentElement = matrix[currentRow, currentCol];
                        if (currentElement == 'e')
                        {
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                        else if (currentElement == 'c')
                        {
                            coals--;
                            matrix[currentRow, currentCol] = '*';
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{coals} coals left. ({currentRow}, {currentCol})");
        }
    }
}