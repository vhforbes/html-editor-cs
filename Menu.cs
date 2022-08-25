using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            var width = 30;
            var height = 10;

            void makeRow()
            {
                Console.Write("+");
                for (int i = 0; i <= width; i++)
                    Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            }

            void makeColumn()
            {
                for (int lines = 0; lines <= height; lines++)
                {
                    Console.Write("|");

                    for (int i = 0; i <= width; i++)
                        Console.Write(" ");

                    Console.Write("|");
                    Console.Write("\n");
                }
            }

            makeRow();
            makeColumn();
            makeRow();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("HTML Editor");
            Console.SetCursorPosition(3, 3);
            Console.Write("===========");
            Console.SetCursorPosition(3, 4);
            Console.Write("Select a option: ");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Create new file");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Open existing file");
            Console.SetCursorPosition(3, 9);
            Console.Write("0 - Exit");

            Console.SetCursorPosition(0, 13);
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;


            }
        }

    }
}