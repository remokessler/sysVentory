namespace sysVentory.Views
{
    partial class ScanedComputers
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
            this.LstComputerNames = new System.Windows.Forms.ListBox();
            this.LblComputernames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstComputerNames
            // 
            this.LstComputerNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LstComputerNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstComputerNames.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstComputerNames.ForeColor = System.Drawing.Color.White;
            this.LstComputerNames.FormattingEnabled = true;
            this.LstComputerNames.ItemHeight = 19;
            this.LstComputerNames.Location = new System.Drawing.Point(20, 40);
            this.LstComputerNames.Margin = new System.Windows.Forms.Padding(2);
            this.LstComputerNames.Name = "LstComputerNames";
            this.LstComputerNames.Size = new System.Drawing.Size(210, 475);
            this.LstComputerNames.TabIndex = 0;
            this.LstComputerNames.SelectedIndexChanged += new System.EventHandler(this.LstComputerNames_SelectedIndexChanged);
            // 
            // LblComputernames
            // 
            this.LblComputernames.AutoSize = true;
            this.LblComputernames.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputernames.ForeColor = System.Drawing.Color.White;
            this.LblComputernames.Location = new System.Drawing.Point(10, 10);
            this.LblComputernames.Name = "LblComputernames";
            this.LblComputernames.Size = new System.Drawing.Size(155, 23);
            this.LblComputernames.TabIndex = 1;
            this.LblComputernames.Text = "Select Computer";
            // 
            // ScanedComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(230, 515);
            this.ControlBox = false;
            this.Controls.Add(this.LblComputernames);
            this.Controls.Add(this.LstComputerNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScanedComputers";
            this.Text = "ScanOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstComputerNames;
        private System.Windows.Forms.Label LblComputernames;
    }
}