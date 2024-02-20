using System;
using System.Text;

namespace EvenLines;

public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder sb = new StringBuilder();
        using StreamReader reader = new(inputFilePath);

        string line = string.Empty;
        int count = 0;

        while (line != null)
        {
            line = reader.ReadLine();
            if (count %2 ==0)
            {
                string replacedSymbols = ReplaceSymbols(line);
                string reversedWords = ReverseWord(replacedSymbols);
                sb.AppendLine(reversedWords);
            }
            count++;

        }

        return sb.ToString().TrimEnd();
    }

    private static string ReplaceSymbols(string line)
    {
        StringBuilder sb = new(line);

        char [] symbolsToReplace = { '-', ',', '.', '!', '?' };
        foreach (char ch in symbolsToReplace)
        {
            sb = sb.Replace(ch, '@');
        }
        return sb.ToString();
    }
    private static string ReverseWord(string words)
    {
        string[] reversedWords = words.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
        
        return string.Join(" ", reversedWords);
    }

}
