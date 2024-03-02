using System.Reflection;
using System.Threading;

int rows = int.Parse(Console.ReadLine());
int cols = rows;



string[,] airspace = new string[rows, cols];

int jetRow = 0;
int jetCol = 0;
int enemyCounter = 0;
int armorValueOfJet = 300;
for (int row = 0; row < rows; row++)
{
    string rowValue = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        airspace[row, col] = rowValue[col].ToString();
        if (airspace[row, col] == "J")
        {
            jetRow = row;
            jetCol = col;
            airspace[row, col] = "-";
        }
        else if (airspace[row, col] == "E")
        {
            enemyCounter++;
        }
    }
}
while (true)
{
    string command = Console.ReadLine();
    if ((command == "left" && jetCol == 0) ||
                   (command == "right" && jetCol == airspace.GetLength(1) - 1) ||
                   (command == "up" && jetRow == 0) ||
                   (command == "down" && jetRow == airspace.GetLength(0) - 1))
    {
        continue;
    }
    else
    {
        if (command == "left")
        {
            jetCol--;
        }
        else if (command == "right")
        {
            jetCol++;
        }
        else if (command == "up")
        {
            jetRow--;
        }
        else if (command == "down")
        {
            jetRow++;
        }
        if (airspace[jetRow,jetCol] == "-")
        {
            continue;
        }
        else if (airspace[jetRow, jetCol] == "E")
        {
            airspace[jetRow, jetCol] = "-";
            enemyCounter--;
            if (enemyCounter==0)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                break;
            }
            else
            {
                armorValueOfJet -= 100;
                if (armorValueOfJet==0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                    break;
                }
            }
        }
        else if (airspace[jetRow, jetCol] == "R")
        {
            armorValueOfJet = 300;
            airspace[jetRow, jetCol] = "-";
        }
    }
}
airspace[jetRow, jetCol] = "J";
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(airspace[row, col]);
    }
    Console.WriteLine();
}
