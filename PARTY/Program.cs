using PARTY;

Console.WriteLine("Hi !!  Welcome in Party program which shows statistic for Political Party");
Console.WriteLine("****************************************");
Console.WriteLine();

var PoliticalParty = new PoliticalPartyInFile("My Wam Damy");

PoliticalParty.SupportAdded += PoliticalPartySupportAdded;

void PoliticalPartySupportAdded(object sender, EventArgs args)
{
    Console.WriteLine("Support Added");
}

Console.WriteLine($"This program is for My Wam Damy party");

while (true)
{
    Console.WriteLine($"Enter support for {PoliticalParty.Name} party");
    var support = Console.ReadLine();
    if (support == "F" || support == "f")
    {
        break;
    }
    try
    {
        PoliticalParty.AddSupport(support);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Invalid format:{ex.Message}");
    }
    Console.WriteLine();
    Console.WriteLine("Enter next score");
}
Console.WriteLine("Statistic for Party is : ");

var statistics = PoliticalParty.GetStatistics();
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

