using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Notepad
{
    internal static class View
    {
        public static void StatusBar(StatusBar statusBar, TextBox textBox)
        {
            if (statusBar.Visibility == Visibility.Visible)
            {
                statusBar.Visibility = Visibility.Hidden;
                textBox.SetValue(Grid.RowSpanProperty, Grid.GetRowSpan(textBox) + 1);
            }
            else if (statusBar.Visibility == Visibility.Hidden)
            {
                statusBar.Visibility = Visibility.Visible;
                textBox.SetValue(Grid.RowSpanProperty, Grid.GetRowSpan(textBox) - 1);
            }
        }
    }
}
