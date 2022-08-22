using System.Windows;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for Replace.xaml
    /// </summary>
    public partial class Replace : Window
    {
        public Replace()
        {
            InitializeComponent();
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            ReplaceWindow.Close();
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            FindReplace.Replace(TextBoxFind, TextBoxReplace);
        }

        private void ReplaceAllClick(object sender, RoutedEventArgs e)
        {
            FindReplace.ReplaceAll(TextBoxFind, TextBoxReplace);
        }
    }
}
