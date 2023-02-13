using ProjectInOOPBasics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

AudienceVote audienceVote = new AudienceVote();
NotHardCodedData notHardCodedData = new NotHardCodedData();
List<IIdol> idolsNamesACopy = new List<IIdol>();
var iterator = CollectionsMarshal.AsSpan(notHardCodedData.idolNames);
foreach (var idolName in iterator)
{
    idolsNamesACopy.Add(new Idol(idolName));
}
IIdol boysBand1 = new Idol("Backstreet boys", new Idol("Steve1"), new Idol("Steve2"), new Idol("Steve3"), new Idol("Steve4"), new Idol("Steve5"));
IIdol boysBand2 = new Idol("Westlife", new Idol("Steve6"), new Idol("Steveu"), new Idol("Steven"), new Idol("Stevene"), new Idol("Stevel"));
IIdol boysBand3 = new Idol("Jonas Brothers", new Idol("Bob"), new Idol("Bob1"), new Idol("Roby"), new Idol("PickleMan"), new Idol("Jack"));
IIdol boysBand4 = new Idol("High Five", new Idol("Steve1Boris"), new Idol("Steve2"), new Idol("Steve3"), new Idol("Steve4"), new Idol("Blah"));
List<Hero> heroesBand1 = new()
{
    new GuitarHero("Steven Steve"),
    new BoomTrachHero("Steven the drummer")
};

boysBand1.SetHeroes(heroesBand1);

idolsNamesACopy.Add(boysBand1);

List<Hero> heroesBand2 = new()
{
    new GuitarHero("Steven Steve"),
    new BoomTrachHero("Steven the drummer")
};

boysBand2.SetHeroes(heroesBand2);
idolsNamesACopy.Add(boysBand2);

List<Hero> heroesBand3 = new()
{
    new GuitarHero("Steven Steve"),
    new BoomTrachHero("Steven the drummer")
};

boysBand3.SetHeroes(heroesBand3);
idolsNamesACopy.Add(boysBand3);

List<Hero> heroesBand4 = new()
{
    new GuitarHero("Steven Steve"),
    new BoomTrachHero("Steven the drummer")
};

boysBand4.SetHeroes(heroesBand4);
idolsNamesACopy.Add(boysBand4);
Idol root = new Idol();
Random rand = new Random();

while (idolsNamesACopy.Count >= 2)
{
    int index1 = rand.Next(idolsNamesACopy.Count);
    IIdol competitor1 = idolsNamesACopy[index1];
    idolsNamesACopy.RemoveAt(index1);

    // Randomly select the second competitor
    int index2 = rand.Next(idolsNamesACopy.Count);
    IIdol competitor2 = idolsNamesACopy[index2];
    idolsNamesACopy.RemoveAt(index2);

    IIdol newIdol = new Idol(competitor1, competitor2);
    newIdol.SetName(newIdol.GetIdols()[audienceVote.Match()].GetName());
    root.AddOne(newIdol);
}

IIdol RecursivelyBuildABoard(IIdol idol)
{
    if (idol.Size() <= 2)
    {
        idol.SetName(idol.GetIdols()[audienceVote.Match()].GetName());
        return idol;
    }
    IIdol root = new Idol();
    List<IIdol> idols = new List<IIdol>();

    idol.CopyByVal(idols);
    while (idols.Count >= 2)
    {
        
        int index1 = rand.Next(idols.Count);
        IIdol idol1 = idols[index1];
        idol1.SetName(idol1.GetIdols()[audienceVote.Match()].GetName());
        idols.RemoveAt(index1);

        // Randomly select the second competitor
        int index2 = rand.Next(idols.Count);
        IIdol idol2 = idols[index2];
        idol2.SetName(idol2.GetIdols()[audienceVote.Match()].GetName());
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