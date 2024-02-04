namespace _2.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrade = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numbers; i++)
            {
                string[] inputInfomations = Console.ReadLine().Split();
                string name = inputInfomations[0];
                decimal grade = decimal.Parse(inputInfomations[1]);
                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, new List<decimal>());
                }
                studentGrade[name].Add(grade);
            }

            foreach (var item in studentGrade)
            {
                string name = item.Key;
                List<decimal> grades = item.Value;
                decimal average = grades.Average();
                Console.WriteLine($"{name} -> {String.Join(" ",grades.Select(grade => $"{grade:f2}"))} (avg: {average:F2})");
            }
        }
    }
}