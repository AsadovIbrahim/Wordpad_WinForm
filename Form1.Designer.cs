namespace NotePad_Winform
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
            components = new System.ComponentModel.Container();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            openFileDialog1 = new OpenFileDialog();
            fonts = new ComboBox();
            fontLabel = new Label();
            sizes = new ComboBox();
            sizeLabel = new Label();
            bolt_Button = new Button();
            underline_Button = new Button();
            italic_Button = new Button();
            font_Label = new Label();
            colors = new ComboBox();
            color_Label = new Label();
            load_FIleTextBox = new TextBox();
            save_TextBox = new TextBox();
            load_Button = new Button();
            save_Button = new Button();
            alignment_Label = new Label();
            left = new Button();
            center_Button = new Button();
            right_Button = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-1, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1342, 529);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fonts
            // 
            fonts.FormattingEnabled = true;
            fonts.Location = new Point(12, 37);
            fonts.Name = "fonts";
            fonts.Size = new Size(182, 33);
            fonts.TabIndex = 2;
            fonts.SelectedIndexChanged += fonts_SelectedIndexChanged;
            fonts.Click += font_Click;
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Location = new Point(73, 9);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(48, 25);
            fontLabel.TabIndex = 3;
            fontLabel.Text = "Font";
            // 
            // sizes
            // 
            sizes.FormattingEnabled = true;
            sizes.Location = new Point(256, 37);
            sizes.Name = "sizes";
            sizes.Size = new Size(62, 33);
            sizes.TabIndex = 4;
            sizes.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            sizes.Click += size_Click;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(266, 9);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(43, 25);
            sizeLabel.TabIndex = 5;
            sizeLabel.Text = "Size";
            // 
            // bolt_Button
            // 
            bolt_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bolt_Button.Location = new Point(377, 37);
            bolt_Button.Name = "bolt_Button";
            bolt_Button.Size = new Size(36, 36);
            bolt_Button.TabIndex = 6;
            bolt_Button.Text = "B";
            bolt_Button.UseVisualStyleBackColor = true;
            bolt_Button.Click += bolt_Button_Click;
            // 
            // underline_Button
            // 
            underline_Button.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            underline_Button.Location = new Point(419, 37);
            underline_Button.Name = "underline_Button";
            underline_Button.Size = new Size(36, 36);
            underline_Button.TabIndex = 7;
            underline_Button.Text = "U";
            underline_Button.UseVisualStyleBackColor = true;
            underline_Button.Click += underline_Button_Click;
            // 
            // italic_Button
            // 
            italic_Button.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italic_Button.Location = new Point(461, 37);
            italic_Button.Name = "italic_Button";
            italic_Button.Size = new Size(36, 36);
            italic_Button.TabIndex = 8;
            italic_Button.Text = "I";
            italic_Button.UseVisualStyleBackColor = true;
            italic_Button.Click += italic_Button_Click;
            // 
            // font_Label
            // 
            font_Label.AutoSize = true;
            font_Label.Location = new Point(393, 9);
            font_Label.Name = "font_Label";
            font_Label.Size = new Size(90, 25);
            font_Label.TabIndex = 9;
            font_Label.Text = "Font Style";
            // 
            // colors
            // 
            colors.FormattingEnabled = true;
            colors.Location = new Point(546, 40);
            colors.Name = "colors";
            colors.Size = new Size(161, 33);
            colors.TabIndex = 10;
            colors.Click += color_Click;
            // 
            // color_Label
            // 
            color_Label.AutoSize = true;
            color_Label.Location = new Point(610, 9);
            color_Label.Name = "color_Label";
            color_Label.Size = new Size(55, 25);
            color_Label.TabIndex = 11;
            color_Label.Text = "Color";
            // 
            // load_FIleTextBox
            // 
            load_FIleTextBox.Location = new Point(917, 14);
            load_FIleTextBox.Name = "load_FIleTextBox";
            load_FIleTextBox.PlaceholderText = "Enter name and load file";
            load_FIleTextBox.Size = new Size(260, 31);
            load_FIleTextBox.TabIndex = 12;
            // 
            // save_TextBox
            // 
            save_TextBox.Location = new Point(917, 54);
            save_TextBox.Multiline = true;
            save_TextBox.Name = "save_TextBox";
            save_TextBox.PlaceholderText = "Tap to enter name and save";
            save_TextBox.Size = new Size(260, 34);
            save_TextBox.TabIndex = 13;
            // 
            // load_Button
            // 
            load_Button.Location = new Point(1205, 12);
            load_Button.Name = "load_Button";
            load_Button.Size = new Size(136, 34);
            load_Button.TabIndex = 14;
            load_Button.Text = "Load";
            load_Button.UseVisualStyleBackColor = true;
            load_Button.Click += load_Button_Click;
            // 
            // save_Button
            // 
            save_Button.Location = new Point(1205, 52);
            save_Button.Name = "save_Button";
            save_Button.Size = new Size(136, 34);
            save_Button.TabIndex = 15;
            save_Button.Text = "Save";
            save_Button.UseVisualStyleBackColor = true;
            save_Button.Click += save_Button_Click;
            // 
            // alignment_Label
            // 
            alignment_Label.AutoSize = true;
            alignment_Label.Location = new Point(771, 9);
            alignment_Label.Name = "alignment_Label";
            alignment_Label.Size = new Size(94, 25);
            alignment_Label.TabIndex = 16;
            alignment_Label.Text = "Alignment";
            // 
            // left
            // 
            left.Location = new Point(756, 37);
            left.Name = "left";
            left.Size = new Size(36, 36);
            left.TabIndex = 17;
            left.Text = "L";
            left.UseVisualStyleBackColor = true;
            left.Click += left_Click;
            // 
            // center_Button
            // 
            center_Button.Location = new Point(798, 37);
            center_Button.Name = "center_Button";
            center_Button.Size = new Size(36, 36);
            center_Button.TabIndex = 18;
            center_Button.Text = "C";
            center_Button.UseVisualStyleBackColor = true;
            center_Button.Click += center_Button_Click;
            // 
            // right_Button
            // 
            right_Button.Location = new Point(840, 37);
            right_Button.Name = "right_Button";
            right_Button.Size = new Size(36, 36);
            right_Button.TabIndex = 19;
            right_Button.Text = "R";
            right_Button.UseVisualStyleBackColor = true;
            right_Button.Click += right_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 640);
            Controls.Add(right_Button);
            Controls.Add(center_Button);
            Controls.Add(left);
            Controls.Add(alignment_Label);
            Controls.Add(save_Button);
            Controls.Add(load_Button);
            Controls.Add(save_TextBox);
            Controls.Add(load_FIleTextBox);
            Controls.Add(color_Label);
            Controls.Add(colors);
            Controls.Add(font_Label);
            Controls.Add(italic_Button);
            Controls.Add(underline_Button);
            Controls.Add(bolt_Button);
            Controls.Add(sizeLabel);
            Controls.Add(sizes);
            Controls.Add(fontLabel);
            Controls.Add(fonts);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenuStrip2;
        private OpenFileDialog openFileDialog1;
        private ComboBox fonts;
        private Label fontLabel;
        private ComboBox sizes;
        private Label sizeLabel;
        private Button underline_Button;
        private Button italic_Button;
        private Label font_Label;
        private ComboBox colors;
        private Label color_Label;
        private TextBox load_FIleTextBox;
        private TextBox save_TextBox;
        private Button load_Button;
        private Button save_Button;
        private Button bolt_Button;
        private Label alignment_Label;
        private Button left;
        private Button center_Button;
        private Button right_Button;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}