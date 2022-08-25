using System;
using System.Text.RegularExpressions;
using System.Text;


namespace HtmlEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.WriteLine("View mode");
            Console.WriteLine("-----------");
            Replace(text);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (i == 1)
                    words[i] = @"\" + words[i];

                Console.Write(words[i]);

                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}