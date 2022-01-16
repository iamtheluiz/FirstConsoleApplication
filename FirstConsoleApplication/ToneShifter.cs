using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    internal class ToneShifter
    {
        public static void Run()
        {
            /**
             * Tone Shifter
             * -> User insert a musical note: "A", "A#", "B", "C", ...
             * -> User insert a value of semitones to shift (allows negative or positive)
             * -> Return the new note
             */
            string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

            Console.Clear();
            Console.WriteLine("|================================|");
            Console.WriteLine("|=       Musical Shifter        =|");
            Console.WriteLine("|================================|");

            Console.Write("| - Insert a musical note: ");
            string note = Console.ReadLine();

            Console.Write("| - Insert a shift value: ");
            int shift = Convert.ToInt32(Console.ReadLine());

            int newNoteIndex;
            string newNote;

            if (Array.IndexOf(notes, note) + shift >= 0)
            {
                newNoteIndex = (Array.IndexOf(notes, note) + shift) % notes.Length;
                newNote = notes[newNoteIndex];
            }
            else
            {
                newNoteIndex = Math.Abs((Array.IndexOf(notes, note) + shift + 1) % notes.Length);
                Array.Reverse(notes);
                newNote = notes[newNoteIndex];
            }

            Console.WriteLine("|================================|");
            Console.WriteLine("| New Note: " + newNote);
            Console.WriteLine("|================================|");

            Console.Write("\nPress ENTER to exit...");
            Console.ReadLine();
        }
    }
}
