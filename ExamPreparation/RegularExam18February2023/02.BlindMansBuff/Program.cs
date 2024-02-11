using System.Threading.Channels;

int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];
int manRow = 0;
int manCol = 0;
int touchedPlayers = 0;
int countOfMoves = 0;
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] rowValue = Console.ReadLine().Split().ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValue[col];
        if (matrix[row, col] == "B")
        {
            manRow = row;
            manCol = col;
            matrix[row, col] = "-";
        }

    }
}
string command = "";
while ((command=Console.ReadLine())!="Finish")
{
    if ((command == "left" && manCol == 0) ||
                   (command == "right" && manCol == matrix.GetLength(1) - 1) ||
                   (command == "up" && manRow == 0) ||
                   (command == "down" && manRow == matrix.GetLength(0) - 1))
    {
        continue;
    }
    else
    {
        if (command == "left")
        {
            manCol--;
            if (matrix[manRow, manCol] == "-")
            {
                countOfMoves++;
            }
            else if (matrix[manRow, manCol] == "P")
            {
                matrix[manRow, manCol] = "-";
                touchedPlayers++;
                countOfMoves++;
                if (touchedPlayers==3)
                {
                    break;
                }
            }
            else if (matrix[manRow, manCol] == "O")
            {
                manCol++;
                continue;
            }
        }
        else if (command == "right")
        {
            manCol++;
            if (matrix[manRow, manCol] == "-")
            {
                countOfMoves++;
            }
            else if (matrix[manRow, manCol] == "P")
            {
                matrix[manRow, manCol] = "-";
                touchedPlayers++;
                countOfMoves++;
                if (touchedPlayers == 3)
                {
                    break;
                }
            }
            else if (matrix[manRow, manCol] == "O")
            {
                manCol--;
                continue;
            }
        }
        else if (command == "up")
        {
            manRow--;
            if (matrix[manRow, manCol] == "-")
            {
                countOfMoves++;
            }
            else if (matrix[manRow, manCol] == "P")
            {
                matrix[manRow, manCol] = "-";
                touchedPlayers++;
                countOfMoves++;
                if (touchedPlayers == 3)
                {
                    break;
                }
            }
            else if (matrix[manRow, manCol] == "O")
            {
                manRow++;
                continue;
            }
        }
        else if (command == "down")
        {
            manRow++;
            if (matrix[manRow, manCol] == "-")
            {
                countOfMoves++;
            }
            else if (matrix[manRow, manCol] == "P")
            {
                matrix[manRow, manCol] = "-";
                touchedPlayers++;
                countOfMoves++;
                if (touchedPlayers == 3)
                {
                    break;
                }
            }
            else if (matrix[manRow, manCol] == "O")
            {
                manRow--;
                continue;
            }
        }
    }
}
matrix[manRow, manCol] = "B";

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedPlayers} Moves made: {countOfMoves}");
