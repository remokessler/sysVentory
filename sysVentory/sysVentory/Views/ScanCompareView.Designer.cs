namespace sysVentory
{
    partial class ScanCompareView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanCompareView));
            this.TreLeft = new System.Windows.Forms.TreeView();
            this.TreRight = new System.Windows.Forms.TreeView();
            this.LblScanTitleLeft = new System.Windows.Forms.Label();
            this.LblScanTitleRight = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PnlGreen = new System.Windows.Forms.Panel();
            this.LblGreen = new System.Windows.Forms.Label();
            this.LblOrange = new System.Windows.Forms.Label();
            this.PnlOrange = new System.Windows.Forms.Panel();
            this.LblRed = new System.Windows.Forms.Label();
            this.PnlRed = new System.Windows.Forms.Panel();
            this.CmdClose = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreLeft
            // 
            this.TreLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TreLeft.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreLeft.Location = new System.Drawing.Point(0, 26);
            this.TreLeft.Name = "TreLeft";
            this.TreLeft.Size = new System.Drawing.Size(467, 450);
            this.TreLeft.TabIndex = 0;
            // 
            // TreRight
            // 
            this.TreRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TreRight.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreRight.Location = new System.Drawing.Point(3, 26);
            this.TreRight.Name = "TreRight";
            this.TreRight.Size = new System.Drawing.Size(483, 450);
            this.TreRight.TabIndex = 1;
            // 
            // LblScanTitleLeft
            // 
            this.LblScanTitleLeft.AutoSize = true;
            this.LblScanTitleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScanTitleLeft.ForeColor = System.Drawing.Color.White;
            this.LblScanTitleLeft.Location = new System.Drawing.Point(-5, -6);
            this.LblScanTitleLeft.Name = "LblScanTitleLeft";
            this.LblScanTitleLeft.Size = new System.Drawing.Size(31, 29);
            this.LblScanTitleLeft.TabIndex = 3;
            this.LblScanTitleLeft.Text = "...";
            // 
            // LblScanTitleRight
            // 
            this.LblScanTitleRight.AutoSize = true;
            this.LblScanTitleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScanTitleRight.ForeColor = System.Drawing.Color.White;
            this.LblScanTitleRight.Location = new System.Drawing.Point(-2, -6);
            this.LblScanTitleRight.Name = "LblScanTitleRight";
            this.LblScanTitleRight.Size = new System.Drawing.Size(31, 29);
            this.LblScanTitleRight.TabIndex = 4;
            this.LblScanTitleRight.Text = "...";
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
            this.splitContainer1.Panel1.Controls.Add(this.LblScanTitleLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TreRight);
            this.splitContainer1.Panel2.Controls.Add(this.LblScanTitleRight);
            this.splitContainer1.Size = new System.Drawing.Size(960, 476);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 5;
            // 
            // PnlGreen
            // 
            this.PnlGreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlGreen.BackColor = System.Drawing.Color.Lime;
            this.PnlGreen.Location = new System.Drawing.Point(188, 524);
            this.PnlGreen.Name = "PnlGreen";
            this.PnlGreen.Size = new System.Drawing.Size(15, 15);
            this.PnlGreen.TabIndex = 6;
            // 
            // LblGreen
            // 
            this.LblGreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblGreen.AutoSize = true;
            this.LblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreen.ForeColor = System.Drawing.SystemColors.Window;
            this.LblGreen.Location = new System.Drawing.Point(209, 519);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(145, 20);
            this.LblGreen.TabIndex = 7;
            this.LblGreen.Text = "Green: Added Item";
            // 
            // LblOrange
            // 
            this.LblOrange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblOrange.AutoSize = true;
            this.LblOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrange.ForeColor = System.Drawing.SystemColors.Window;
            this.LblOrange.Location = new System.Drawing.Point(442, 519);
            this.LblOrange.Name = "LblOrange";
            this.LblOrange.Size = new System.Drawing.Size(171, 20);
            this.LblOrange.TabIndex = 9;
            this.LblOrange.Text = "Orange: Changed Item";
            // 
            // PnlOrange
            // 
            this.PnlOrange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PnlOrange.Location = new System.Drawing.Point(421, 524);
            this.PnlOrange.Name = "PnlOrange";
            this.PnlOrange.Size = new System.Drawing.Size(15, 15);
            this.PnlOrange.TabIndex = 8;
            // 
            // LblRed
            // 
            this.LblRed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblRed.AutoSize = true;
            this.LblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRed.ForeColor = System.Drawing.SystemColors.Window;
            this.LblRed.Location = new System.Drawing.Point(694, 519);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(139, 20);
            this.LblRed.TabIndex = 11;
            this.LblRed.Text = "Red: Deleted Item";
            // 
            // PnlRed
            // 
            this.PnlRed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlRed.BackColor = System.Drawing.Color.Red;
            this.PnlRed.Location = new System.Drawing.Point(673, 524);
            this.PnlRed.Name = "PnlRed";
            this.PnlRed.Size = new System.Drawing.Size(15, 15);
            this.PnlRed.TabIndex = 10;
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.Depth = 0;
            this.CmdClose.Location = new System.Drawing.Point(882, 514);
            this.CmdClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Primary = true;
            this.CmdClose.Size = new System.Drawing.Size(90, 35);
            this.CmdClose.TabIndex = 12;
            this.CmdClose.Text = "Exit";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // ScanCompareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.PnlRed);
            this.Controls.Add(this.LblOrange);
            this.Controls.Add(this.PnlOrange);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.PnlGreen);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanCompareView";
            this.Text = "FilesCompare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreLeft;
        private System.Windows.Forms.TreeView TreRight;
        private System.Windows.Forms.Label LblScanTitleLeft;
        private System.Windows.Forms.Label LblScanTitleRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PnlGreen;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.Label LblOrange;
        private System.Windows.Forms.Panel PnlOrange;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.Panel PnlRed;
        private MaterialSkin.Controls.MaterialRaisedButton CmdClose;
    }
}