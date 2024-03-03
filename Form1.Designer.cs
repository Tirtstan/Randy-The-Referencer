namespace Randy_The_Referencer
{
    partial class frmRandy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandy));
            panel1 = new Panel();
            cmbMediaTypes = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            redOutput = new RichTextBox();
            label2 = new Label();
            panel3 = new Panel();
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
            btnCopy = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEdition).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbMediaTypes);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 38);
            panel1.TabIndex = 1;
            // 
            // cmbMediaTypes
            // 
            cmbMediaTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMediaTypes.FormattingEnabled = true;
            cmbMediaTypes.Location = new Point(130, 7);
            cmbMediaTypes.Name = "cmbMediaTypes";
            cmbMediaTypes.Size = new Size(180, 23);
            cmbMediaTypes.TabIndex = 1;
            cmbMediaTypes.SelectedIndexChanged += cmbMediaTypes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Select A Media Type:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCopy);
            panel2.Controls.Add(redOutput);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(339, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 138);
            panel2.TabIndex = 2;
            // 
            // redOutput
            // 
            redOutput.BackColor = SystemColors.Window;
            redOutput.BorderStyle = BorderStyle.None;
            redOutput.Location = new Point(11, 32);
            redOutput.Name = "redOutput";
            redOutput.ReadOnly = true;
            redOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            redOutput.Size = new Size(299, 89);
            redOutput.TabIndex = 1;
            redOutput.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Output:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnFormat);
            panel3.Controls.Add(spnYear);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtPubName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPubPlace);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(spnEdition);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtBookName);
            panel3.Controls.Add(redAuthors);
            panel3.Controls.Add(btnClearAuthors);
            panel3.Controls.Add(btnAddAuthor);
            panel3.Controls.Add(txtAuthors);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 323);
            panel3.TabIndex = 3;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(169, 285);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(140, 23);
            btnFormat.TabIndex = 22;
            btnFormat.Text = "Format";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
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
            btnClearAuthors.Click += btnClearAuthors_Click;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(156, 61);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(75, 23);
            btnAddAuthor.TabIndex = 3;
            btnAddAuthor.Text = "Add";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
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
            // btnCopy
            // 
            btnCopy.Location = new Point(235, 4);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // frmRandy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 391);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRandy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randy The Referencer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEdition).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ComboBox cmbMediaTypes;
        private Panel panel2;
        private Label label2;
        private RichTextBox redOutput;
        private Panel panel3;
        private Label label3;
        private TextBox txtAuthors;
        private Button btnAddAuthor;
        private Button btnClearAuthors;
        private RichTextBox redAuthors;
        private TextBox txtYear;
        private TextBox txtBookName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown spnEdition;
        private Label label8;
        private TextBox txtPubPlace;
        private Label label9;
        private TextBox txtPubName;
        private NumericUpDown spnYear;
        private Button btnFormat;
        private Button btnCopy;
    }
}
