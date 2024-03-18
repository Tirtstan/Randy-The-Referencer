namespace Randy_The_Referencer
{
    partial class ucYouTube
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
            pnlYoutube = new Panel();
            btnFillInformation = new Button();
            spnYear = new NumericUpDown();
            label4 = new Label();
            txtLink = new TextBox();
            label2 = new Label();
            txtChannel = new TextBox();
            label1 = new Label();
            dtpAccessedWhen = new DateTimePicker();
            btnFormat = new Button();
            label6 = new Label();
            label5 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            pnlYoutube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).BeginInit();
            SuspendLayout();
            // 
            // pnlYoutube
            // 
            pnlYoutube.AutoSize = true;
            pnlYoutube.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlYoutube.BackColor = Color.FromArgb(224, 224, 224);
            pnlYoutube.BorderStyle = BorderStyle.FixedSingle;
            pnlYoutube.Controls.Add(btnFillInformation);
            pnlYoutube.Controls.Add(spnYear);
            pnlYoutube.Controls.Add(label4);
            pnlYoutube.Controls.Add(txtLink);
            pnlYoutube.Controls.Add(label2);
            pnlYoutube.Controls.Add(txtChannel);
            pnlYoutube.Controls.Add(label1);
            pnlYoutube.Controls.Add(dtpAccessedWhen);
            pnlYoutube.Controls.Add(btnFormat);
            pnlYoutube.Controls.Add(label6);
            pnlYoutube.Controls.Add(label5);
            pnlYoutube.Controls.Add(txtTitle);
            pnlYoutube.Controls.Add(label3);
            pnlYoutube.Dock = DockStyle.Fill;
            pnlYoutube.Location = new Point(0, 0);
            pnlYoutube.Name = "pnlYoutube";
            pnlYoutube.Size = new Size(321, 319);
            pnlYoutube.TabIndex = 5;
            // 
            // btnFillInformation
            // 
            btnFillInformation.Location = new Point(169, 57);
            btnFillInformation.Name = "btnFillInformation";
            btnFillInformation.Size = new Size(140, 23);
            btnFillInformation.TabIndex = 30;
            btnFillInformation.Text = "Fill Information";
            btnFillInformation.UseVisualStyleBackColor = true;
            btnFillInformation.Click += btnFillInformation_Click;
            // 
            // spnYear
            // 
            spnYear.Location = new Point(11, 285);
            spnYear.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            spnYear.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spnYear.Name = "spnYear";
            spnYear.Size = new Size(140, 23);
            spnYear.TabIndex = 29;
            spnYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label4.Location = new Point(11, 258);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 28;
            label4.Text = "Year Uploaded:";
            // 
            // txtLink
            // 
            txtLink.AccessibleName = "";
            txtLink.Location = new Point(13, 57);
            txtLink.Name = "txtLink";
            txtLink.PlaceholderText = "Link";
            txtLink.Size = new Size(138, 23);
            txtLink.TabIndex = 27;
            txtLink.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label2.Location = new Point(11, 33);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 26;
            label2.Text = "Link:";
            // 
            // txtChannel
            // 
            txtChannel.AccessibleName = "";
            txtChannel.Location = new Point(12, 167);
            txtChannel.Name = "txtChannel";
            txtChannel.PlaceholderText = "Channel";
            txtChannel.Size = new Size(297, 23);
            txtChannel.TabIndex = 25;
            txtChannel.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 24;
            label1.Text = "Channel:";
            // 
            // dtpAccessedWhen
            // 
            dtpAccessedWhen.Location = new Point(11, 224);
            dtpAccessedWhen.Name = "dtpAccessedWhen";
            dtpAccessedWhen.Size = new Size(298, 23);
            dtpAccessedWhen.TabIndex = 23;
            dtpAccessedWhen.Value = new DateTime(2024, 3, 16, 16, 22, 12, 0);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label6.Location = new Point(12, 88);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 14;
            label6.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label5.Location = new Point(11, 200);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 13;
            label5.Text = "Date Accessed:";
            // 
            // txtTitle
            // 
            txtTitle.AccessibleName = "";
            txtTitle.Location = new Point(13, 112);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(296, 23);
            txtTitle.TabIndex = 11;
            txtTitle.WordWrap = false;
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
            // ucYouTube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlYoutube);
            Name = "ucYouTube";
            Size = new Size(321, 319);
            pnlYoutube.ResumeLayout(false);
            pnlYoutube.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlYoutube;
        private Button btnFormat;
        private Label label6;
        private Label label5;
        private TextBox txtTitle;
        private Label label3;
        private DateTimePicker dtpAccessedWhen;
        private Label label1;
        private TextBox txtChannel;
        private Label label2;
        private TextBox txtLink;
        private NumericUpDown spnYear;
        private Label label4;
        private Button btnFillInformation;
    }
}
