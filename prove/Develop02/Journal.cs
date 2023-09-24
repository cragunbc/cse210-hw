using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> _newEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry userEntry in _entries)
        {
            userEntry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry userData in _entries)
            {
                outputFile.WriteLine($"Date: {userData._date} -- Prompt: {userData._promptText}-- User Entry: {userData._entryText}\n");
                
            }
        }
    }
    public void LoadFromFile(string file)
    {
        List<Entry> newEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        //return newEntries; 

    }

}