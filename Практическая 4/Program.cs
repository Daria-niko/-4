using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;

namespace Практическая_4
{
    internal class Program
    {
        static void Main()
        {
            List<Заметки> notes = new List<Заметки>();

            Заметки note = new Заметки();

            DateTime dateTime = DateTime.Today;

            note.title = "Сходить погулять";
            note.content = "В 14.00 в парке";
            note.date = dateTime;
            note.position = 1;
            notes.Add(note);

            Заметки note2 = new Заметки();

            note2.title = "Сходить в тех";
            note2.content = "По расисанию у нас 4 пары";
            note2.date = dateTime.AddDays(+1);
            note2.position = 2;
            notes.Add(note2);

            Заметки note3 = new Заметки();

            note3.title = "Поспать с котиком";
            note3.content = "Котики - милые существа";
            note3.date = dateTime.AddDays(+1);
            note3.position = 3;
            notes.Add(note3);

            Заметки note4 = new Заметки();

            note4.title = "что-то грустное";
            note4.content = "Что-то интерсесное";
            note4.date = dateTime.AddDays(+3);
            note4.position = 4;
            notes.Add(note4);

            Заметки note5 = new Заметки();

            note5.title = "Поехать на дачу";
            note5.content = "Там водится много котиков";
            note5.date = dateTime.AddDays(+3);
            note5.position = 3;
            notes.Add(note5);

            DateTime date = DateTime.Now;
            int position = 1;

            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                else if (Key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                Console.Clear();
                Console.WriteLine(date.ToString("dd.MM.yyyy"));
                foreach (Заметки zam in notes)
                {
                    if (zam.date.Date == date.Date)
                    {
                        Console.WriteLine("  " + zam.title);
                    }
                }
                if (Key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (Key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position < 2)
                {
                    position = 1;
                }
                else if (position > 2)
                {
                    position = 1;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (Key.Key == ConsoleKey.Enter)
                {
                    foreach (Заметки pos in notes)
                    {
                        if (note.position == position)
                        {
                            Console.Clear();
                            Console.WriteLine("Информация о заметке: ");
                            Console.WriteLine("Название: ");
                            Console.WriteLine(note.title);
                            Console.WriteLine("Содержание: ");
                            Console.WriteLine(note.content);
                        }
                    }

                }
            }
        }
    }
}

