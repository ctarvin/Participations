using System;

namespace Classes_TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox text1 = new TextBox();

            text1.Padding = 3;
            text1.BackColor = Console.BackgroundColor = ConsoleColor.Yellow;
            text1.ForeColor = Console.ForegroundColor = ConsoleColor.Black;
            text1.Text = "I completely forgot how to code over the break. I hope this works!";
            text1.DisplayText();

            TextBox text2 = new TextBox();

            text2.Padding = 5;
            text2.BackColor = Console.BackgroundColor = ConsoleColor.White;
            text2.ForeColor = Console.ForegroundColor = ConsoleColor.Blue;
            text2.Text = "I think I about got it, other than padding.";
            text2.DisplayText();
        }
    }
}
