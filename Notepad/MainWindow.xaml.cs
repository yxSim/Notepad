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
            File.New(TextBox);
        }

        private void OpenClick(object sender, RoutedEventArgs e)
        {
            File.Open(TextBox);
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            File.Save(TextBox);
        }

        private void SaveAsClick(object sender, RoutedEventArgs e)
        {
            File.SaveAs(TextBox);
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            File.Exit();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Edit.Back();
        }

        private void CutClick(object sender, RoutedEventArgs e)
        {
            Edit.Cut();
        }

        private void CopyClick(object sender, RoutedEventArgs e)
        {
            Edit.Copy();
        }

        private void PasteClick(object sender, RoutedEventArgs e)
        {
            Edit.Paste();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Edit.Delete();
        }

        private void FindClick(object sender, RoutedEventArgs e)
        {
            FindReplace.FindWindow(TextBox);
        }

        private void FindNextClick(object sender, RoutedEventArgs e)
        {
            FindReplace.FindNext();
        }

        private void ReplaceClick(object sender, RoutedEventArgs e)
        {
            FindReplace.ReplaceWindow(TextBox);
        }

        private void SelectAllClick(object sender, RoutedEventArgs e)
        {
            Edit.SelectAll();
        }

        private void TimeClick(object sender, RoutedEventArgs e)
        {
            Edit.DateAndTime();
        }

        private void FontClick(object sender, RoutedEventArgs e)
        {
            Format.ChangeFont(TextBox);
        }

        private void ColorClick(object sender, RoutedEventArgs e)
        {
            Format.ChangeColor(TextBox);
        }

        private void WordWrappedClick(object sender, RoutedEventArgs e)
        {
            Format.WordWrap(TextBox);
        }

        private void StatusBar_Click(object sender, RoutedEventArgs e)
        {
            View.StatusBar(Bar, TextBox);
        }

        private void GotoClick(object sender, RoutedEventArgs e)
        {
            Edit.GoToWindow();
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
            Edit.DateAndTime();
        }

        private void TextBoxSelectionChanged(object sender, RoutedEventArgs e)
        {
            var row = TextBox.GetLineIndexFromCharacterIndex(TextBox.CaretIndex) ;
            var c = TextBox.CaretIndex - TextBox.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = $"Line: {row + 1}, character: {c}";
        }
    }
    #endregion
}