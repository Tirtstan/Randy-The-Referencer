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
            redOutput = new RichTextBox();
            SuspendLayout();
            // 
            // redOutput
            // 
            redOutput.BackColor = Color.FromArgb(224, 224, 224);
            redOutput.BorderStyle = BorderStyle.None;
            redOutput.Location = new Point(12, 201);
            redOutput.Name = "redOutput";
            redOutput.ReadOnly = true;
            redOutput.Size = new Size(321, 123);
            redOutput.TabIndex = 0;
            redOutput.Text = "";
            // 
            // frmRandy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 336);
            Controls.Add(redOutput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRandy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randy The Referencer";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox redOutput;
    }
}
