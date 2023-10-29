

namespace PARTY
{
    public interface IPoliticalParty
    {
        string Name { get; }
        void AddSupport(float support);

        void AddSupport(double support);
        void AddSupport(int support);

        void AddSupport(char support);

        void AddSupport(string support);

        statistics GetStatistics();
    }
}
