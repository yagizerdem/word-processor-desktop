using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace word_processor
{
    public partial class Form1 : Form
    {
        private bool isDarkMode = false;

        // Define Font class as a private nested class

        public Form1()
        {
            InitializeComponent();

        }
        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.InitialDirectory = desktopPath;
                openFileDialog.Filter = "supported file mime types (txt and rtf) |*.txt;*.rtf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;


                    string extension = Path.GetExtension(filePath);
                    if (extension == ".rtf")
                    {
                        // load rtf file
                        richTextBox1.LoadFile(openFileDialog.FileName);
                    }
                    else if (extension == ".txt")
                    {
                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();

                            // print to rtf box 
                            richTextBox1.Text = fileContent;
                        }
                    }


                }
            }
        }

        private void savefilebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "text and rtf file only|*.txt;*.rtf";
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }

        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            int lineCount = GetLineCount();
            int wordCount = GetWordCount();

            this.lineCountlabel.Text = $"Line Count : {lineCount.ToString()}";
            this.wordCountlabel.Text = $"Word Count : {wordCount.ToString()}";
        }

        // utility functions
        private int GetLineCount()
        {
            int count = richTextBox1.Text.Split('\n').Length;
            return count;
        }
        private int GetWordCount()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int count = this.richTextBox1.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }


        private void ChangeFont(int delta)
        {

            richTextBox1.Focus();

            var ss = richTextBox1.SelectionStart;
            var sl = richTextBox1.SelectionLength;

            richTextBox1.SelectedRtf =
             Regex.Replace(richTextBox1.SelectedRtf, @"(?<!\\+)\\fs(?<s>\d+([.]\d+)?)",
             m => $@"\fs{decimal.Parse(m.Groups["s"].Value) + delta}");

            richTextBox1.Select(ss, sl);
        }

        private void increaseFontButton_Click(object sender, EventArgs e)
        {
            ChangeFont(4);
        }

        private void decreaseFontButton_Click(object sender, EventArgs e)
        {
            ChangeFont(-4);
        }

        private void mode_Click(object sender, EventArgs e)
        {
            this.isDarkMode = !this.isDarkMode;

            if(this.isDarkMode){
                this.BackColor = Color.FromArgb(48, 25, 52);
                this.wordCountlabel.ForeColor = Color.FromArgb(255, 255, 255);
                this.lineCountlabel.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else {
                this.BackColor = Color.FromArgb(255, 255, 255);
                this.wordCountlabel.ForeColor = Color.FromArgb(0,0, 0);
                this.lineCountlabel.ForeColor = Color.FromArgb(0,0, 0);
            }
        }
    }
}
