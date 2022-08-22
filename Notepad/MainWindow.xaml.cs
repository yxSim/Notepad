using System;
using System.Windows;
using System.Windows.Input;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand New = new();
        public static RoutedCommand Open = new();
        public static RoutedCommand Save = new();
        public static RoutedCommand SaveAs = new();
        public static RoutedCommand _Find = new();
        public static RoutedCommand FindN = new();
        public static RoutedCommand _Replace = new();
        public static RoutedCommand Refresh = new();

        public MainWindow()
        {
            New.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            Open.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            Save.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            SaveAs.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Shift));
            _Find.InputGestures.Add(new KeyGesture(Key.F, ModifierKeys.Control));
            FindN.InputGestures.Add(new KeyGesture(Key.F3));
            _Replace.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            Refresh.InputGestures.Add(new KeyGesture(Key.F5));
            InitializeComponent();
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
        }

        private void OpenClick(object sender, RoutedEventArgs e)
        {
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
        }

        private void SaveAsClick(object sender, RoutedEventArgs e)
        {
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
        }

        private void CutClick(object sender, RoutedEventArgs e)
        {
        }

        private void CopyClick(object sender, RoutedEventArgs e)
        {
        }

        private void PasteClick(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
        }

        private void FindClick(object sender, RoutedEventArgs e)
        {
        }

        private void FindNextClick(object sender, RoutedEventArgs e)
        {
        }

        private void ReplaceClick(object sender, RoutedEventArgs e)
        {
        }

        private void SelectAllClick(object sender, RoutedEventArgs e)
        {
        }

        private void TimeClick(object sender, RoutedEventArgs e)
        {
        }

        private void FontClick(object sender, RoutedEventArgs e)
        {
        }

        private void ColorClick(object sender, RoutedEventArgs e)
        {
        }

        private void WordWrappedClick(object sender, RoutedEventArgs e)
        {
        }

        private void StatusBar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void GotoClick(object sender, RoutedEventArgs e)
        {
        }

        private void TextBoxSelectionChanged(object sender, RoutedEventArgs e)
        {
        }

        #region SHORTCUTS
        public void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            File.New(TextBox);
        }

        public void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            File.Open(TextBox);
        }

        public void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            File.Save(TextBox);
        }

        public void SaveAsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            File.SaveAs(TextBox);
        }

        public void FindExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            FindReplace.FindWindow(TextBox);
        }

        public void FindNextExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            FindReplace.FindNext();
        }

        public void ReplaceExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            FindReplace.ReplaceWindow(TextBox);
        }

        public void RefreshExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Edit.DateAndTime(TextBox);
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var row = TextBox.GetLineIndexFromCharacterIndex(TextBox.CaretIndex);
            var c = TextBox.CaretIndex - TextBox.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = $"Line: {row}, character: {c}";
        }
    }
    #endregion
}