public class RandomScriptureGenerator
{
    private Random rnd = new();

    private List<List<string>> scriptures = new()
    {
        new List<string> {"I, the Lord, am bound when ye do whaht I say; but when ye do not what I say, ye have no promise.", "Doctrine and Covenants", "82", "10"},
        new List<string> {"And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.", "Ether", "12", "6"},
        new List<string> {"Any by the power of the Holy Ghost ye may know the truth of all things. And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.", "Moroni", "10", "5", "6"}
    };

    public Scripture GetRandomScripture()
    {
        int index = rnd.Next(scriptures.Count);
        Reference reference;
        if (scriptures[index].Count == 4)
        {
            reference = new Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3]);
        }
        else
        {
            reference = new Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3], scriptures[index][4]);
        }
        Scripture script = new Scripture(reference, scriptures[index][0]);

        return script;
    }
    //  use random.next to get a random index
    //  if the scriptures[index].count == 4
    //      Reference ref = Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3])
    //  else
    //      Reference ref = Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3], scriptures[index][4])
    //
    //  Scripture script = Scripture(reference, scriptures[index][0])
    //  return script
}