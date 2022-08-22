using System.Windows;
using System.Windows.Media;
using System.Windows.Forms;

using TextBox = System.Windows.Controls.TextBox;

namespace Notepad
{
    internal class Format
    {
        public static void ChangeFont(TextBox textBox)
        {
            var fd = new FontDialog();
            var result = fd.ShowDialog();
            if (result != DialogResult.OK) return;
            var selectedFont = fd.Font;

            textBox.FontFamily = new FontFamily(selectedFont.FontFamily.Name);
            textBox.FontSize = selectedFont.Size;
            textBox.FontStyle = selectedFont.Italic ? FontStyles.Italic : FontStyles.Normal;
            textBox.FontWeight = selectedFont.Bold ? FontWeights.Bold : FontWeights.Normal;
        }

        public static void ChangeColor(TextBox textBox)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.OK) return;
            textBox.Foreground = new SolidColorBrush(Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B));
        }

        public static void WordWrap(TextBox textBox) => textBox.TextWrapping = textBox.TextWrapping == TextWrapping.Wrap ? TextWrapping.NoWrap : TextWrapping.Wrap;
    }
}
