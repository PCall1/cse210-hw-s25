using System.Security.Cryptography.X509Certificates;

public class Journal {

    List<Entry> _entries = new List<Entry>();
    private string _fileName; // 

    public void DisplayJournal() {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in _entries) {
            entry.DisplayEntry();
        }
    }

    public void AddEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void SaveJournalToFile() { // write string to file
        Console.WriteLine("Enter the filename to save (myFile.txt):");
        _fileName = Console.ReadLine();

        if (!Directory.Exists("JournalFolder")) {
            Directory.CreateDirectory("JournalFolder");
        }

        using (StreamWriter writer = new StreamWriter("JournalFolder/"+_fileName)) {
            foreach (Entry entry in _entries) {
                List <string> entryData = entry.SaveEntry();
                writer.WriteLine(string.Join("=|", entryData)); // change separator as needed
            }
        }
        Console.WriteLine("Journal saved successfully.");

    }
    
    public void LoadJournalFromFile() {
        Console.WriteLine("Enter the filename to load:");
        _fileName = Console.ReadLine();
        if (File.Exists("JournalFolder/"+_fileName)) {
            string[] lines = File.ReadAllLines("JournalFolder/"+_fileName);
            foreach (string line in lines) {
                string[] entryData = line.Split("=|"); // change separator as needed
                Entry entry = new Entry();
                entry.LoadEntryAccess(entryData);
                _entries.Add(entry);
            }
        } else {
            Console.WriteLine("***File not found.\n");
        }
    }

    public void DeleteFile() {
        Console.WriteLine("Enter file name to delete: ");
        _fileName = Console.ReadLine();
        if (File.Exists("JournalFolder/"+_fileName)) {
            Console.WriteLine($"Are you sure you want to delete [{_fileName}] ? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y") {
                File.Delete("JournalFolder/"+_fileName);
                Console.WriteLine("File deleted successfully.");
            } 
            else {
                Console.WriteLine("***File not deleted.\n");
                return;
            }
            
        } 
        else {
            Console.WriteLine("***File not found.\n");
        }
    }
}