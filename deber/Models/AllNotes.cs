using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Notes.Models
{
    internal class AllNotes
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public AllNotes() => LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();
            string appDataPath = FileSystem.AppDataDirectory;

            IEnumerable<Note> notes = Directory
                .EnumerateFiles(appDataPath, "*.notes.txt")
                .Select(filename => new Note
                {
                    Title = Path.GetFileNameWithoutExtension(filename),
                    Content = File.ReadAllText(filename)
                });

            foreach (var note in notes)
            {
                Notes.Add(note);
            }
        }
    }

    internal class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
