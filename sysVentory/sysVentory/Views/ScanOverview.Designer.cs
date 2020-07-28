namespace sysVentory.Views
{
    partial class ScanOverview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LsbTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LsbTest
            // 
            this.LsbTest.FormattingEnabled = true;
            this.LsbTest.ItemHeight = 16;
            this.LsbTest.Location = new System.Drawing.Point(240, 100);
            this.LsbTest.Name = "LsbTest";
            this.LsbTest.Size = new System.Drawing.Size(120, 84);
            this.LsbTest.TabIndex = 0;
            // 
            // ScanOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LsbTest);
            this.Name = "ScanOverview";
            this.Text = "ScanOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbTest;
    }
}