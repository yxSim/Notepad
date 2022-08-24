using System;
using System.Windows;
using System.Windows.Controls;

namespace Notepad
{
    internal class Edit
    {
        private static TextBox textBox = ((MainWindow)Application.Current.MainWindow).TextBox;
        public static void Back() => textBox.Undo();

        public static void Cut() => textBox.Cut();

        public static void Copy() => textBox.Copy();

        public static void Paste() => textBox.Text = textBox.Text.Insert(textBox.SelectionStart, Clipboard.GetText());

        public static void Delete() => textBox.SelectedText = string.Empty;

        public static void SelectAll() => textBox.SelectAll();

        public static void DateAndTime() => textBox.SelectedText = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()}";

        public static void GoToWindow()
        {
            var window = new GoTo();
            window.ShowDialog();
        }

        public static void GoTo(int row)
        {
            if (row > textBox.LineCount || row < 1)
            {
                return;
            }
            textBox.SelectionStart = textBox.GetCharacterIndexFromLineIndex(row - 1);
        }
    }
}
