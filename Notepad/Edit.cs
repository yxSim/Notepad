using System;
using System.Windows;
using System.Windows.Controls;

namespace Notepad
{
    internal class Edit
    {
        public static void Back(TextBox textBox) => textBox.Undo();

        public static void Cut(TextBox textBox) => textBox.Cut();

        public static void Copy(TextBox textBox) => textBox.Copy();

        public static void Paste(TextBox textBox) => textBox.Text = textBox.Text.Insert(textBox.SelectionStart, Clipboard.GetText());

        public static void Delete(TextBox textBox) => textBox.SelectedText = string.Empty;

        public static void SelectAll(TextBox textBox) => textBox.SelectAll();

        public static void DateAndTime(TextBox textBox) => textBox.SelectedText = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()}";
    }
}
