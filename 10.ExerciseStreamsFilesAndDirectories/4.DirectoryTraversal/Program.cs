namespace DirectoryTraversal
{
    using System;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = @"C:\Users\Jivko\Downloads\SU";
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new();
            string [] files = Directory.GetFiles(inputFolderPath);
            foreach (var fileName in files)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new();
            foreach (var extensionFiles in extensionsFiles.OrderByDescending(ef=>ef.Value.Count))
            {
                sb.AppendLine(extensionFiles.Key);
                foreach (var file in extensionFiles.Value.OrderBy(f=>f.Length))
                {
                    sb.AppendLine($"-{file.Name} - {(double)file.Length / 1024:f3}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
           
            File.WriteAllText(filePath, textContent);
        }
    }
}
