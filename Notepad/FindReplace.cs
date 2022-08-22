using System.Windows;
using System.Windows.Controls;

namespace Notepad
{
    internal class FindReplace
    {
        private static string text = string.Empty;
        private static TextBox mainTextBox;

        public static void FindWindow(TextBox textBox)
        {
            mainTextBox = textBox;
            var window = new Find();
            window.ShowDialog();
        }

        public static void Find(string str)
        {
            for (var i = 0; i <= mainTextBox.Text.Length - text.Length; i++)
            {
                if (mainTextBox.Text[i] != str[0]) continue;
                var found = mainTextBox.Text.Substring(i, str.Length);
                if (found != str) continue;
                mainTextBox.SelectionStart = i;
                mainTextBox.SelectionLength = str.Length;
                text = found;
                break;
            }
        }

        public static void FindNext()
        {
            if (text.Equals(string.Empty)) return;
            for (var i = mainTextBox.SelectionStart + 1; i <= mainTextBox.Text.Length - text.Length; i++)
            {
                if (!mainTextBox.Text[i].Equals(text[0])) continue;
                var found = mainTextBox.Text.Substring(i, text.Length);
                if (!found.Equals(text)) continue;
                mainTextBox.SelectionStart = i;
                mainTextBox.SelectionLength = text.Length;
                break;
            }
        }

        public static int FindAll(string str)
        {
            var count = 0;
            for (var i = 0; i <= mainTextBox.Text.Length - str.Length; i++)
            {
                if (mainTextBox.Text[i] != str[0]) continue;
                var found = mainTextBox.Text.Substring(i, str.Length);
                if (found != str) continue;
                mainTextBox.SelectionStart = i;
                mainTextBox.SelectionLength = str.Length;
                text = found;
                count++;
            }

            return count;
        }

        public static void ReplaceWindow(TextBox textBox)
        {
            mainTextBox = textBox;
            var window = new Replace();
            window.ShowDialog();
        }

        public static void Replace(TextBox findTextBox, TextBox replaceTextBox)
        {
            text = findTextBox.Text;
            FindNext();
            mainTextBox.SelectedText = replaceTextBox.Text;
        }
        public static void ReplaceAll(TextBox findTextBox, TextBox replaceTextBox)
        {
            if (findTextBox.Text.Equals(string.Empty)) return;
            text = findTextBox.Text;
            var count = FindAll(text);
            mainTextBox.SelectionStart = 0;
            mainTextBox.SelectionLength = 0;
            mainTextBox.Focus();
            for (var i = 0; i < count; i++)
            {
                FindNext();
                mainTextBox.SelectedText = replaceTextBox.Text;
            }

            MessageBox.Show($"Replaced {count} occurrences.");
        }
    }
}
