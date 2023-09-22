using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GenerateFileOutput()}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] linesFromFile = System.IO.File.ReadAllLines(fileName);
        
        foreach(string currentLine in linesFromFile)
        {
            string[] splitLine = currentLine.Split("|");
            Entry entry = new Entry();
            entry._date = splitLine[0];
            entry._promptText = splitLine[1];
            entry._response = splitLine[2];
            entry._gratitude = splitLine[3];
            _entries.Add(entry);
        }
    }
}