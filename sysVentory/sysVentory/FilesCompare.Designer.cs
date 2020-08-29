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
            this.TreLeft = new System.Windows.Forms.TreeView();
            this.TreRight = new System.Windows.Forms.TreeView();
            this.LblFile1 = new System.Windows.Forms.Label();
            this.LblFile2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreFile1
            // 
            this.TreLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TreLeft.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.TreLeft.Location = new System.Drawing.Point(0, 26);
            this.TreLeft.Name = "TreFile1";
            this.TreLeft.Size = new System.Drawing.Size(467, 488);
            this.TreLeft.TabIndex = 0;
            // 
            // TreFile2
            // 
            this.TreRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TreRight.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.TreRight.Location = new System.Drawing.Point(3, 26);
            this.TreRight.Name = "TreFile2";
            this.TreRight.Size = new System.Drawing.Size(483, 488);
            this.TreRight.TabIndex = 1;
            // 
            // LblFile1
            // 
            this.LblFile1.AutoSize = true;
            this.LblFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFile1.ForeColor = System.Drawing.Color.White;
            this.LblFile1.Location = new System.Drawing.Point(3, 0);
            this.LblFile1.Name = "LblFile1";
            this.LblFile1.Size = new System.Drawing.Size(25, 24);
            this.LblFile1.TabIndex = 3;
            this.LblFile1.Text = "...";
            // 
            // LblFile2
            // 
            this.LblFile2.AutoSize = true;
            this.LblFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFile2.ForeColor = System.Drawing.Color.White;
            this.LblFile2.Location = new System.Drawing.Point(3, 0);
            this.LblFile2.Name = "LblFile2";
            this.LblFile2.Size = new System.Drawing.Size(25, 24);
            this.LblFile2.TabIndex = 4;
            this.LblFile2.Text = "...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreLeft);
            this.splitContainer1.Panel1.Controls.Add(this.LblFile1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TreRight);
            this.splitContainer1.Panel2.Controls.Add(this.LblFile2);
            this.splitContainer1.Size = new System.Drawing.Size(960, 514);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 5;
            // 
            // FilesCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilesCompare";
            this.Text = "FilesCompare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreLeft;
        private System.Windows.Forms.TreeView TreRight;
        private System.Windows.Forms.Label LblFile1;
        private System.Windows.Forms.Label LblFile2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}