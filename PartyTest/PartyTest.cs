using PARTY;

namespace PartyTest
{
    public class Tests
    {
        [Test]
        public void CheckingMaxStat()
        {
            var PoliticalParty = new PoliticalPartyInMemory("POPIS");
            PoliticalParty.AddSupport(44);
            PoliticalParty.AddSupport(23);
            PoliticalParty.AddSupport(11);
            PoliticalParty.AddSupport(42);

            var statistics = PoliticalParty.GetStatistics();

            Assert.AreEqual(44, statistics.Max);
        }
        [Test]
        public void CheckingMinStat()
        {
            var PoliticalParty = new PoliticalPartyInMemory("POPIS");
            PoliticalParty.AddSupport(44);
            PoliticalParty.AddSupport(23);
            PoliticalParty.AddSupport(11);
            PoliticalParty.AddSupport(42);

            var statistics = PoliticalParty.GetStatistics();

            Assert.AreEqual(11, statistics.Min);
        }
        [Test]
        public void CheckingAverageStat()
        {
            var PoliticalParty = new PoliticalPartyInMemory("POPIS");
            PoliticalParty.AddSupport(44);
            PoliticalParty.AddSupport(23);
            PoliticalParty.AddSupport(11);
            PoliticalParty.AddSupport(42);

            var statistics = PoliticalParty.GetStatistics();

            Assert.AreEqual(30, statistics.Average);
        }
    }
}