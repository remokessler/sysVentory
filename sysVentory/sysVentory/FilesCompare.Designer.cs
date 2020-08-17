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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treFile1
            // 
            this.treFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.treFile1.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.treFile1.Location = new System.Drawing.Point(0, 26);
            this.treFile1.Name = "treFile1";
            this.treFile1.Size = new System.Drawing.Size(467, 488);
            this.treFile1.TabIndex = 0;
            // 
            // treFile2
            // 
            this.treFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.treFile2.Font = new System.Drawing.Font("Leelawadee", 9.75F);
            this.treFile2.Location = new System.Drawing.Point(3, 26);
            this.treFile2.Name = "treFile2";
            this.treFile2.Size = new System.Drawing.Size(483, 488);
            this.treFile2.TabIndex = 1;
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile1.ForeColor = System.Drawing.Color.White;
            this.lblFile1.Location = new System.Drawing.Point(3, 0);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(25, 24);
            this.lblFile1.TabIndex = 3;
            this.lblFile1.Text = "...";
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile2.ForeColor = System.Drawing.Color.White;
            this.lblFile2.Location = new System.Drawing.Point(3, 0);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(25, 24);
            this.lblFile2.TabIndex = 4;
            this.lblFile2.Text = "...";
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
            this.splitContainer1.Panel1.Controls.Add(this.treFile1);
            this.splitContainer1.Panel1.Controls.Add(this.lblFile1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treFile2);
            this.splitContainer1.Panel2.Controls.Add(this.lblFile2);
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

        private System.Windows.Forms.TreeView treFile1;
        private System.Windows.Forms.TreeView treFile2;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}