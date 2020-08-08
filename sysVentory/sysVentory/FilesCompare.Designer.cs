namespace sysVentory
{
    partial class FilesCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesCompare));
            this.treFile1 = new System.Windows.Forms.TreeView();
            this.treFile2 = new System.Windows.Forms.TreeView();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treFile1
            // 
            this.treFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.treFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.treFile1.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.treFile1.Location = new System.Drawing.Point(12, 37);
            this.treFile1.Name = "treFile1";
            this.treFile1.Size = new System.Drawing.Size(450, 512);
            this.treFile1.TabIndex = 0;
            // 
            // treFile2
            // 
            this.treFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.treFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.treFile2.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.treFile2.Location = new System.Drawing.Point(522, 37);
            this.treFile2.Name = "treFile2";
            this.treFile2.Size = new System.Drawing.Size(450, 512);
            this.treFile2.TabIndex = 1;
            // 
            // lblFile1
            // 
            this.lblFile1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFile1.AutoSize = true;
            this.lblFile1.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile1.ForeColor = System.Drawing.Color.White;
            this.lblFile1.Location = new System.Drawing.Point(8, 9);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(25, 23);
            this.lblFile1.TabIndex = 3;
            this.lblFile1.Text = "...";
            // 
            // lblFile2
            // 
            this.lblFile2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFile2.AutoSize = true;
            this.lblFile2.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile2.ForeColor = System.Drawing.Color.White;
            this.lblFile2.Location = new System.Drawing.Point(518, 9);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(25, 23);
            this.lblFile2.TabIndex = 4;
            this.lblFile2.Text = "...";
            // 
            // FilesCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.treFile2);
            this.Controls.Add(this.treFile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FilesCompare";
            this.Text = "FilesCompare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treFile1;
        private System.Windows.Forms.TreeView treFile2;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Label lblFile2;
    }
}