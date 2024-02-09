namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int lineNumber = 0;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        lineNumber++;
                        if (lineNumber % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}



