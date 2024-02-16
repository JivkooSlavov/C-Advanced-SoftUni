int rows = int.Parse(Console.ReadLine());
int cols = rows;

string[,] matrix = new string[rows, cols];

int submarineRow = 0;
int submarineCol = 0;
int mines = 0;
int cruisers = 0;
for (int row = 0; row < rows; row++)
{
    string rowValue = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValue[col].ToString();
        if (matrix[row, col] == "S")
        {
            submarineRow = row;
            submarineCol = col;
            matrix[row, col] = "-";
        }
    }
}

while (true)
{
    string command = Console.ReadLine();
    if (command=="up")
    {
        submarineRow--;
        if (matrix[submarineRow, submarineCol] == "-")
        {
            continue;
        }
        else if (matrix[submarineRow, submarineCol] == "*")
        {
            matrix[submarineRow, submarineCol] = "-";
            mines++;
            if (mines==3)
            {
                break;
            }
        }
        else if (matrix[submarineRow, submarineCol] == "C")
        {
            matrix[submarineRow, submarineCol] = "-";
            cruisers++;
            if (cruisers==3)
            {
                break;
            }
        }
    }
    else if (command=="down")
    {
        submarineRow++;
        if (matrix[submarineRow, submarineCol] == "-")
        {
            continue;
        }
        else if (matrix[submarineRow, submarineCol] == "*")
        {
            matrix[submarineRow, submarineCol] = "-";
            mines++;
            if (mines == 3)
            {
                break;
            }
        }
        else if (matrix[submarineRow, submarineCol] == "C")
        {
            matrix[submarineRow, submarineCol] = "-";
            cruisers++;
            if (cruisers == 3)
            {
                break;
            }
        }
    }
    else if (command=="left")
    {
        submarineCol--;
        if (matrix[submarineRow, submarineCol] == "-")
        {
            continue;
        }
        else if (matrix[submarineRow, submarineCol] == "*")
        {
            matrix[submarineRow, submarineCol] = "-";
            mines++;
            if (mines == 3)
            {
                break;
            }
        }
        else if (matrix[submarineRow, submarineCol] == "C")
        {
            matrix[submarineRow, submarineCol] = "-";
            cruisers++;
            if (cruisers == 3)
            {
                break;
            }
        }
    }
    else if (command=="right")
    {
        submarineCol++;
        if (matrix[submarineRow, submarineCol] == "-")
        {
            continue;
        }
        else if (matrix[submarineRow, submarineCol] == "*")
        {
            matrix[submarineRow, submarineCol] = "-";
            mines++;
            if (mines == 3)
            {
                break;
            }
        }
        else if (matrix[submarineRow, submarineCol] == "C")
        {
            matrix[submarineRow, submarineCol] = "-";
            cruisers++;
            if (cruisers == 3)
            {
                break;
            }
        }
    }
}
matrix[submarineRow, submarineCol] = "S";
if (mines==3)
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
}
if (cruisers == 3)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}