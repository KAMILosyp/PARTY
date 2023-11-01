
namespace PARTY
{
    public class PoliticalPartyInFile : PoliticalPartyBase
    {
        private const string fileName = "supports.txt";

        public override event SupportAddedDelegate SupportAdded;
        public PoliticalPartyInFile(string name)
            : base(name)
        {
        }
        public override void AddSupport(float support)
        {
            if (support > 0)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(support);
                    if (SupportAdded != null)
                    {
                        SupportAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Value must be more than 0");
            }
        }
        public override statistics GetStatistics()
        {
            var statistics = new statistics();
            var supportFromFile = this.ReadScoreFromFile();
            foreach (var support in supportFromFile)
            {
                statistics.AddSupport(support);
            }
            return statistics;
        }

        private List<float> ReadScoreFromFile()
        {
            var support = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        support.Add(number);
                        line = reader.ReadLine();

                    }
                }
            }
            return support;
        }
    }
}
