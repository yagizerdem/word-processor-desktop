namespace word_processor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            LoadFileButton = new Button();
            savefilebutton = new Button();
            lineCountlabel = new Label();
            wordCountlabel = new Label();
            increaseFontButton = new Button();
            decreaseFontButton = new Button();
            mode = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 324);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += rtb_TextChanged;
            // 
            // LoadFileButton
            // 
            LoadFileButton.Location = new Point(571, 26);
            LoadFileButton.Name = "LoadFileButton";
            LoadFileButton.Size = new Size(104, 45);
            LoadFileButton.TabIndex = 3;
            LoadFileButton.Text = "Load File";
            LoadFileButton.UseVisualStyleBackColor = true;
            LoadFileButton.Click += LoadFileButton_Click;
            // 
            // savefilebutton
            // 
            savefilebutton.Location = new Point(681, 26);
            savefilebutton.Name = "savefilebutton";
            savefilebutton.Size = new Size(94, 45);
            savefilebutton.TabIndex = 4;
            savefilebutton.Text = "Save File";
            savefilebutton.UseVisualStyleBackColor = true;
            savefilebutton.Click += savefilebutton_Click;
            // 
            // lineCountlabel
            // 
            lineCountlabel.AutoSize = true;
            lineCountlabel.Location = new Point(26, 30);
            lineCountlabel.Name = "lineCountlabel";
            lineCountlabel.Size = new Size(68, 15);
            lineCountlabel.TabIndex = 5;
            lineCountlabel.Text = "LineCount :";
            // 
            // wordCountlabel
            // 
            wordCountlabel.AutoSize = true;
            wordCountlabel.Location = new Point(26, 56);
            wordCountlabel.Name = "wordCountlabel";
            wordCountlabel.Size = new Size(78, 15);
            wordCountlabel.TabIndex = 6;
            wordCountlabel.Text = "WordCount  :";
            // 
            // increaseFontButton
            // 
            increaseFontButton.Location = new Point(445, 26);
            increaseFontButton.Name = "increaseFontButton";
            increaseFontButton.Size = new Size(120, 45);
            increaseFontButton.TabIndex = 7;
            increaseFontButton.Text = "increase font";
            increaseFontButton.UseVisualStyleBackColor = true;
            increaseFontButton.Click += increaseFontButton_Click;
            // 
            // decreaseFontButton
            // 
            decreaseFontButton.Location = new Point(317, 26);
            decreaseFontButton.Name = "decreaseFontButton";
            decreaseFontButton.Size = new Size(122, 45);
            decreaseFontButton.TabIndex = 8;
            decreaseFontButton.Text = "decrease font";
            decreaseFontButton.UseVisualStyleBackColor = true;
            decreaseFontButton.Click += decreaseFontButton_Click;
            // 
            // mode
            // 
            mode.Location = new Point(187, 30);
            mode.Name = "mode";
            mode.Size = new Size(113, 41);
            mode.TabIndex = 9;
            mode.Text = "mode";
            mode.UseVisualStyleBackColor = true;
            mode.Click += mode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mode);
            Controls.Add(decreaseFontButton);
            Controls.Add(increaseFontButton);
            Controls.Add(wordCountlabel);
            Controls.Add(lineCountlabel);
            Controls.Add(savefilebutton);
            Controls.Add(LoadFileButton);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private Button LoadFileButton;
        private Button savefilebutton;
        private Label lineCountlabel;
        private Label wordCountlabel;
        private Button increaseFontButton;
        private Button decreaseFontButton;
        private Button mode;
    }
}
