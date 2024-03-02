using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }

        public int GetCount =>Species.Count;

        public void AddShark(Shark shark)
        {
            if (Capacity > Species.Count)
            {
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }
            }
        }
        public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(x => x.Kind == kind));

        public string GetLargestShark() => Species.OrderByDescending(y => y.Length).FirstOrDefault().ToString();

        public double GetAverageLength() => Species.Average(z => z.Length);

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Species.Count} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
