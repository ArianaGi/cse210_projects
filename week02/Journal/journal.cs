
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
        private string[] ParseCsvLine(string line)
        {
            var result = new List<string>();
            bool inQuotes = false;
            string current = "";
    
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
    
            if (c == '\"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                {
                    current += '\"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        result.Add(current);
        return result.ToArray();
    }

    public void AddNewEntry()
    {
        PromptGenerator generator = new PromptGenerator();
        string prompt = generator.GetRandomPrompt();

        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd"),
            _prompt = prompt,
            _entry = response
        };

        AddEntry(entry);
        Console.WriteLine("Entry saved!\n");
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Header row
            writer.WriteLine("Date,Prompt,Response");

            foreach (var entry in _entries)
            {
                // Wrap each field in quotes and escape internal quotes
                string date = entry._date;
                string prompt = entry._prompt.Replace("\"", "\"\"");
                string response = entry._entry.Replace("\"", "\"\"");

                writer.WriteLine($"\"{date}\",\"{prompt}\",\"{response}\"");
            }
        }

        Console.WriteLine($"Journal saved as CSV to '{filename}'\n");
    }
    public void LoadFromFile(string filename)

    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); // Replace current journal

        string[] lines = File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++) // skip header
        {
            string[] parts = ParseCsvLine(lines[i]);

            if (parts.Length == 3)
            {
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];

                _entries.Add(new Entry
                {
                    _date = date.ToString("yyyy-MM-dd"),
                    _prompt = prompt,
                    _entry = response
                });
            }
        }

        Console.WriteLine($"Journal loaded from '{filename}'\n");
    }
}