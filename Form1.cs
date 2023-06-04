namespace NotePad_Winform
{
    public partial class Form1 : Form
    {
        FontStyle font = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
        }
        private void font_Click(object sender, EventArgs e)
        {
            FontFamily[] fontFamily = FontFamily.Families;
            foreach (FontFamily family in fontFamily)
            {
                fonts.Items.Add(family.Name);
            }
            fonts.SelectedItem = richTextBox1.SelectionFont.FontFamily.Name;
        }
        private void fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentfont = richTextBox1.SelectionFont;
                Font newfont = new Font(fonts.SelectedItem.ToString(), currentfont.Size, currentfont.Style);
                richTextBox1.SelectionFont = newfont;
            }
        }
        private void size_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 72; i++)
            {
                sizes.Items.Add(i.ToString());
            }
            sizes.SelectedItem = richTextBox1.SelectionFont.Size;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                float newSize;
                if (float.TryParse(sizes.SelectedItem.ToString(), out newSize))
                {
                    Font currentFont = richTextBox1.SelectionFont;
                    Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
        }

        private void bolt_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFont = FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont, newFont);
            }
        }
        private void underline_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFont = FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(currentFont, newFont);
            }
        }
        private void italic_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFont = FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont, newFont);
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        private void left_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
        private void center_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
        private void right_Button_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
        private void save_Button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = save_TextBox.Text;
            saveFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text);
                MessageBox.Show("File Saved Succesfully!", "File");
            }
        }
        private void load_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = load_FIleTextBox.Text;
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text=File.ReadAllText(openFileDialog1.FileName);
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}