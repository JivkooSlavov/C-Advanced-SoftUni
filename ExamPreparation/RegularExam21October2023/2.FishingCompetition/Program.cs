using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

int size = int.Parse(Console.ReadLine());

string[,] matrix = new string[size, size];

int currRow = 0;
int currCol = 0;
int fishQuantity = 0;
for (int row = 0; row < size; row++)
{
    string newRow = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        if (newRow[col].ToString() == "S")
        {
            currRow = row;
            currCol = col;
            matrix[row, col] = "-";
            continue;
        }

        matrix[row, col] = newRow[col].ToString();
    }
}

string command = "";
while ((command=Console.ReadLine())!= "collect the nets")
{
    if (MoveIsOutOfArea(size, currRow, currCol, command))
    {
        if (command=="up" || command =="down")
        {
            currRow = ResetRow(size, command);
        }
        if (command == "left" || command == "right")
        {
            currCol = ResetCol(size, command);
        }
    }
    else
    {
        if (command == "left")
        {
            currCol--;
        }
        else if (command == "right")
        {
            currCol++;
        }
        else if (command == "up")
        {
            currRow--;
        }
        else if (command == "down")
        {
            currRow++;
        }
    }
    if (Char.IsDigit(matrix[currRow, currCol][0]))
    {
        fishQuantity += int.Parse(matrix[currRow, currCol]);
        matrix[currRow, currCol] = "-";
        continue;
    }
    if (matrix[currRow,currCol] =="W")
    {
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currRow},{currCol}]");
        Environment.Exit(0);
    }
}

static int ResetCol(int size, string command)
{
    if (command=="left")
    {
        return size - 1;
    }
    return 0;
}
static int ResetRow (int size , string command)
{
    if (command == "up")
    {
        return size - 1;
    }
    return 0;
}

if (fishQuantity>=20)
{
    Console.WriteLine($"Success! You managed to reach the quota!");
}
else
{

    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishQuantity} tons of fish more.");
}
if (fishQuantity>0)
{
    Console.WriteLine($"Amount of fish caught: {fishQuantity} tons.");
}

matrix[currRow, currCol] = "S";
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}
static bool MoveIsOutOfArea(int size, int posRow, int posCol, string command)
{
    if (command == "up" && posRow == 0 ||
       command == "down" && posRow == size - 1 ||
       command == "left" && posCol == 0 ||
       command == "right" && posCol == size - 1)
    {
        return true;
    }
    return false;
}
