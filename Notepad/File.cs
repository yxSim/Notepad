using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Application = System.Windows.Application;
using TextBox = System.Windows.Controls.TextBox;

namespace Notepad
{
    internal class File
    {
        private const string Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";

        private static string Path { get; set; } = string.Empty;

        public static void New(TextBox textBox)
        {
            Path = "";
            textBox.Text = $"";
        }

        public static void Open(TextBox textBox)
        {
            var dlg = new OpenFileDialog
            {
                Filter = Filter
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            Path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dlg.FileName) ?? throw new InvalidOperationException(), System.IO.Path.GetFileName(dlg.FileName) ?? throw new InvalidOperationException());
            string readFile;
            using (var streamReader = new StreamReader(Path, Encoding.UTF8))
            {
                readFile = streamReader.ReadToEnd();
            }

            textBox.Text = readFile;
        }

        #region Save
        public static void Save(TextBox textBox)
        {
            if (string.IsNullOrEmpty(Path))
            {
                var dlg = new SaveFileDialog
                {
                    Filter = Filter
                };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dlg.FileName) ?? throw new InvalidOperationException(), System.IO.Path.GetFileName(dlg.FileName) ?? throw new InvalidOperationException());
                }
            }

            Save(textBox.Text);
        }

        public static void SaveAs(TextBox textBox)
        {
            var dlg = new SaveFileDialog
            {
                Filter = Filter
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dlg.FileName) ?? throw new InvalidOperationException(), System.IO.Path.GetFileName(dlg.FileName) ?? throw new InvalidOperationException());
            }
            Save(textBox.Text);
        }

        private static void Save(string str)
        {
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(Path ?? ""));
            try
            {
                if (Path == null) return;
                System.IO.File.WriteAllText(Path, str);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
        #endregion

        public static void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
