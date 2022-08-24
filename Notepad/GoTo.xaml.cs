using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for GoTo.xaml
    /// </summary>
    public partial class GoTo : Window
    {

        public GoTo()
        {
            InitializeComponent();
        }

        private void BtnOkOnClick(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(TextBoxLine.Text, out var row))
                Edit.GoTo(row);
        }

        private void BtnCancelOnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
