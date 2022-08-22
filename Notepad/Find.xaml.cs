using System.Windows;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for Find.xaml
    /// </summary>
    public partial class Find : Window
    {
        public Find()
        {
            InitializeComponent();
        }

        private void BtnOkOnClick(object sender, RoutedEventArgs e)
        {
            FindReplace.Find(TextBoxFind.Text);
            FindWindow.Close();
        }

        private void BtnCancelOnClick(object sender, RoutedEventArgs e)
        {
            FindWindow.Close();
        }
    }
}
