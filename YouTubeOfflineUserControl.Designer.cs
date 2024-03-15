namespace Randy_The_Referencer
{
    partial class YouTubeOfflineUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlBook = new Panel();
            btnFormat = new Button();
            spnYear = new NumericUpDown();
            label9 = new Label();
            txtPubName = new TextBox();
            label8 = new Label();
            txtPubPlace = new TextBox();
            label7 = new Label();
            spnEdition = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtBookName = new TextBox();
            redAuthors = new RichTextBox();
            btnClearAuthors = new Button();
            btnAddAuthor = new Button();
            txtAuthors = new TextBox();
            label3 = new Label();
            pnlBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEdition).BeginInit();
            SuspendLayout();
            // 
            // pnlBook
            // 
            pnlBook.AutoSize = true;
            pnlBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlBook.BackColor = Color.FromArgb(224, 224, 224);
            pnlBook.BorderStyle = BorderStyle.FixedSingle;
            pnlBook.Controls.Add(btnFormat);
            pnlBook.Controls.Add(spnYear);
            pnlBook.Controls.Add(label9);
            pnlBook.Controls.Add(txtPubName);
            pnlBook.Controls.Add(label8);
            pnlBook.Controls.Add(txtPubPlace);
            pnlBook.Controls.Add(label7);
            pnlBook.Controls.Add(spnEdition);
            pnlBook.Controls.Add(label6);
            pnlBook.Controls.Add(label5);
            pnlBook.Controls.Add(label4);
            pnlBook.Controls.Add(txtBookName);
            pnlBook.Controls.Add(redAuthors);
            pnlBook.Controls.Add(btnClearAuthors);
            pnlBook.Controls.Add(btnAddAuthor);
            pnlBook.Controls.Add(txtAuthors);
            pnlBook.Controls.Add(label3);
            pnlBook.Dock = DockStyle.Fill;
            pnlBook.Location = new Point(0, 0);
            pnlBook.Name = "pnlBook";
            pnlBook.Size = new Size(321, 319);
            pnlBook.TabIndex = 5;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(169, 285);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(140, 23);
            btnFormat.TabIndex = 22;
            btnFormat.Text = "Format";
            btnFormat.UseVisualStyleBackColor = true;
            // 
            // spnYear
            // 
            spnYear.Location = new Point(11, 162);
            spnYear.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            spnYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spnYear.Name = "spnYear";
            spnYear.Size = new Size(140, 23);
            spnYear.TabIndex = 21;
            spnYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label9.Location = new Point(169, 202);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 20;
            label9.Text = "Publication Name:";
            // 
            // txtPubName
            // 
            txtPubName.AccessibleName = "";
            txtPubName.Location = new Point(169, 225);
            txtPubName.Name = "txtPubName";
            txtPubName.PlaceholderText = "Publication Name";
            txtPubName.Size = new Size(140, 23);
            txtPubName.TabIndex = 19;
            txtPubName.WordWrap = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label8.Location = new Point(169, 139);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 18;
            label8.Text = "Publication Place:";
            // 
            // txtPubPlace
            // 
            txtPubPlace.AccessibleName = "";
            txtPubPlace.Location = new Point(169, 162);
            txtPubPlace.Name = "txtPubPlace";
            txtPubPlace.PlaceholderText = "Publication Place";
            txtPubPlace.Size = new Size(140, 23);
            txtPubPlace.TabIndex = 17;
            txtPubPlace.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label7.Location = new Point(11, 261);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 16;
            label7.Text = "Edition Number:";
            // 
            // spnEdition
            // 
            spnEdition.Location = new Point(11, 285);
            spnEdition.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spnEdition.Name = "spnEdition";
            spnEdition.Size = new Size(140, 23);
            spnEdition.TabIndex = 15;
            spnEdition.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label6.Location = new Point(11, 197);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 14;
            label6.Text = "Book Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label5.Location = new Point(11, 139);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 13;
            label5.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label4.Location = new Point(11, 38);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Authors:";
            // 
            // txtBookName
            // 
            txtBookName.AccessibleName = "";
            txtBookName.Location = new Point(10, 225);
            txtBookName.Name = "txtBookName";
            txtBookName.PlaceholderText = "Book Name";
            txtBookName.Size = new Size(140, 23);
            txtBookName.TabIndex = 11;
            txtBookName.WordWrap = false;
            // 
            // redAuthors
            // 
            redAuthors.BackColor = SystemColors.Window;
            redAuthors.BorderStyle = BorderStyle.None;
            redAuthors.Location = new Point(10, 90);
            redAuthors.Name = "redAuthors";
            redAuthors.ReadOnly = true;
            redAuthors.ScrollBars = RichTextBoxScrollBars.Vertical;
            redAuthors.Size = new Size(299, 41);
            redAuthors.TabIndex = 7;
            redAuthors.Text = "";
            // 
            // btnClearAuthors
            // 
            btnClearAuthors.Location = new Point(234, 61);
            btnClearAuthors.Name = "btnClearAuthors";
            btnClearAuthors.Size = new Size(75, 23);
            btnClearAuthors.TabIndex = 4;
            btnClearAuthors.Text = "Clear";
            btnClearAuthors.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(156, 61);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(75, 23);
            btnAddAuthor.TabIndex = 3;
            btnAddAuthor.Text = "Add";
            btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // txtAuthors
            // 
            txtAuthors.AccessibleName = "";
            txtAuthors.Location = new Point(10, 61);
            txtAuthors.Name = "txtAuthors";
            txtAuthors.PlaceholderText = "Author";
            txtAuthors.Size = new Size(140, 23);
            txtAuthors.TabIndex = 2;
            txtAuthors.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label3.Location = new Point(11, 12);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 1;
            label3.Text = "Reference Information:";
            // 
            // YouTubeOfflineUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBook);
            Name = "YouTubeOfflineUserControl";
            Size = new Size(321, 319);
            pnlBook.ResumeLayout(false);
            pnlBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEdition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBook;
        private Button btnFormat;
        private NumericUpDown spnYear;
        private Label label9;
        private TextBox txtPubName;
        private Label label8;
        private TextBox txtPubPlace;
        private Label label7;
        private NumericUpDown spnEdition;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtBookName;
        private RichTextBox redAuthors;
        private Button btnClearAuthors;
        private Button btnAddAuthor;
        private TextBox txtAuthors;
        private Label label3;
    }
}
