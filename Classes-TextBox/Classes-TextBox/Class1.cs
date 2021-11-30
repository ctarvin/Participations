using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = Console.BackgroundColor = ConsoleColor.Yellow;
            ForeColor = Console.ForegroundColor = ConsoleColor.Black;
            Text = string.Empty;

        }
        public void DisplayText()
        {
            string padding = " ";
            string output = " ";

            for (int i = 0; i < Padding; i++)
            {
                padding += " ";
            }

            output = padding + Text + padding;
            Console.WriteLine(output);
        }
    }
}
