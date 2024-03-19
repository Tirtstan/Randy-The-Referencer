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
            btnCopy = new Button();
            redOutput = new RichTextBox();
            label2 = new Label();
            ucBook = new ucBook();
            ucYouTube = new ucYouTube();
            panel3 = new Panel();
            label3 = new Label();
            redInfo = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(321, 42);
            panel1.TabIndex = 1;
            // 
            // cmbMediaTypes
            // 
            cmbMediaTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMediaTypes.FormattingEnabled = true;
            cmbMediaTypes.Location = new Point(130, 9);
            cmbMediaTypes.Name = "cmbMediaTypes";
            cmbMediaTypes.Size = new Size(180, 23);
            cmbMediaTypes.TabIndex = 1;
            cmbMediaTypes.SelectedIndexChanged += cmbMediaTypes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label1.Location = new Point(9, 12);
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
            // ucBook
            // 
            ucBook.Location = new Point(12, 60);
            ucBook.Name = "ucBook";
            ucBook.Size = new Size(321, 319);
            ucBook.TabIndex = 3;
            // 
            // ucYouTube
            // 
            ucYouTube.Location = new Point(12, 60);
            ucYouTube.Name = "ucYouTube";
            ucYouTube.Size = new Size(321, 319);
            ucYouTube.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(redInfo);
            panel3.Location = new Point(339, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 223);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Information:";
            // 
            // redInfo
            // 
            redInfo.BackColor = SystemColors.Window;
            redInfo.BorderStyle = BorderStyle.None;
            redInfo.Location = new Point(11, 35);
            redInfo.Name = "redInfo";
            redInfo.ReadOnly = true;
            redInfo.ScrollBars = RichTextBoxScrollBars.Vertical;
            redInfo.Size = new Size(299, 174);
            redInfo.TabIndex = 0;
            redInfo.Text = "";
            // 
            // frmRandy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 391);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ucBook);
            Controls.Add(ucYouTube);
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ComboBox cmbMediaTypes;
        private Panel panel2;
        private Label label2;
        private RichTextBox redOutput;
        private Button btnCopy;
        private ucBook ucBook;
        private ucYouTube ucYouTube;
        private Panel panel3;
        private Label label3;
        private RichTextBox redInfo;
    }
}
