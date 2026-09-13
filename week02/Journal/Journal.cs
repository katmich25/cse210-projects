using System;
using System.IO; 
public class Journal
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

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);  
                outputFile.WriteLine(entry._promptText); 
                outputFile.WriteLine(entry._entryText);
            }
        }

    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 3)
        {
            string date = lines[i];
            string prompt = lines[i + 1];
            string entryText = lines[i + 2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = entryText;

            _entries.Add(entry);

        }

    }
}