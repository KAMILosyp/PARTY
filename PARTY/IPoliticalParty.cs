

namespace PARTY
{
    public interface IPoliticalParty
    {
        string Name { get; }
        void AddScore(float score);
        void AddScore(int score);

        void AddScore(double score);

        void AddScore(string score);

        Statistics GetStatistics();
    }
}
