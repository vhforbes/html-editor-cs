using System;
using System.Text;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Editor mode");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            };

            Console.Clear();
            Console.Write("-----------");
            Console.Write("Wish to save the file?");
            Viewer.Show(file.ToString());

        }
    }
}