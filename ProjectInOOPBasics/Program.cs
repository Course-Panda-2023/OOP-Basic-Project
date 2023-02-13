using ProjectInOOPBasics;
using System.Runtime.InteropServices;

NotHardCodedData notHardCodedData = new NotHardCodedData();
List<string> idolsNamesACopy = new List<string>();
var iterator = CollectionsMarshal.AsSpan(notHardCodedData.idolNames);
foreach (var idolName in iterator)
{
    idolsNamesACopy.Add(idolName);
}
Idol root = new Idol();
Random rand = new Random();

while (idolsNamesACopy.Count >= 2)
{
    int index1 = rand.Next(idolsNamesACopy.Count);
    string competitor1 = idolsNamesACopy[index1];
    idolsNamesACopy.RemoveAt(index1);

    // Randomly select the second competitor
    int index2 = rand.Next(idolsNamesACopy.Count);
    string competitor2 = idolsNamesACopy[index2];
    idolsNamesACopy.RemoveAt(index2);

    IIdol idol1 = new Idol();
    idol1.SetName(competitor1);
    IIdol idol2 = new Idol();
    idol2.SetName(competitor2);

    IIdol newIdol = new Idol(idol1, idol2);
    newIdol.SetName(newIdol.GetIdols()[rand.Next(0, 2)].GetName());
    root.AddOne(newIdol);
    

    // Print out the matchup
    Console.WriteLine("{0} vs. {1}", competitor1, competitor2);
}

IIdol RecursivelyBuildABoard(IIdol idol)
{
    if (idol.Size() <= 2)
    {
        idol.SetName(idol.GetIdols()[rand.Next(0, 2)].GetName());
        return idol;
    }
    IIdol root = new Idol();
    List<IIdol> idols = new List<IIdol>();

    idol.CopyByVal(idols);
    while (idols.Count >= 2)
    {
        
        int index1 = rand.Next(idols.Count);
        IIdol idol1 = idols[index1];
        idol1.SetName(idol1.GetIdols()[rand.Next(0, 2)].GetName());
        idols.RemoveAt(index1);

        // Randomly select the second competitor
        int index2 = rand.Next(idols.Count);
        IIdol idol2 = idols[index2];

        idols.RemoveAt(index2);

        IIdol newIdol = new Idol(idol1, idol2);
        newIdol.SetName(idol1.GetName());
        root.AddOne(newIdol);
    }

    if (idols.Count == 1)
    {
        root.AddOne(idols[0]);
    }

    return RecursivelyBuildABoard(root);
}


IIdol idol = RecursivelyBuildABoard(root);

Console.ReadLine();