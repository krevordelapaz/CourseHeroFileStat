using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileStat
{
    public partial class FileStatForm : Form
    {
        string[] words;
        string fileContent;
        string fileName;

        public FileStatForm()
        {
            InitializeComponent();

            getStatsButton.Enabled = false;
            findButton.Enabled = false;
            exitButton.Enabled = false;
        }

        private void openFileButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.Filter = "Text|*.txt|All|*.*";
                DialogResult result = dialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    fileName = dialog.FileName;
                    OpenFileDialog(fileName);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }

        private void OpenFileDialog(string fileName)
        {
            fileContent = File.ReadAllText(fileName);
            getStatsButton.Enabled = true;
            findButton.Enabled = true;
            exitButton.Enabled = true;
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            words = fileContent.Split(' ');

            int count = words.Count();
            string headerFile = String.Format("File name:{0}\nNumber of words:{1}\n\nFrequency of letters:\n", Path.GetFileName(fileName), count);

            if (words != null && words.Count() > 0)
            {

                // Array to store frequencies.
                int[] characters = new int[(int)char.MaxValue];

                var freqs = fileContent
                    .Where(c => Char.IsLetter(c))
                    .GroupBy(c => char.ToUpper(c))
                    .ToDictionary(g => g.Key, g => g.Count());

                string letters = string.Empty;

                foreach (var letter in freqs.OrderBy(i => i.Key))
                {
                    letters += char.ToLower(letter.Key) + ": " + letter.Value + "\t";
                }

                statRichTextBox.Text += headerFile + letters;
            }
            else
            {
                MessageBox.Show("Text file does not contain any words!");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(findTextBox.Text))
            {
                var count = Regex.Matches(fileContent, findTextBox.Text).Count;

                statRichTextBox.Text += string.Format("\nNo of times {0} appear on the file: {1}", findTextBox.Text, count);
            }
        }
    }
}
