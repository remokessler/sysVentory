namespace sysVentory
{
    partial class ScanDetailsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanDetailsView));
            this.TreScan = new System.Windows.Forms.TreeView();
            this.LblScanTitle = new System.Windows.Forms.Label();
            this.CmdClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // TreScan
            // 
            this.TreScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TreScan.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreScan.Location = new System.Drawing.Point(12, 62);
            this.TreScan.Name = "TreScan";
            this.TreScan.Size = new System.Drawing.Size(776, 460);
            this.TreScan.TabIndex = 4;
            // 
            // LblScanTitle
            // 
            this.LblScanTitle.AutoSize = true;
            this.LblScanTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScanTitle.ForeColor = System.Drawing.Color.White;
            this.LblScanTitle.Location = new System.Drawing.Point(7, 30);
            this.LblScanTitle.Name = "LblScanTitle";
            this.LblScanTitle.Size = new System.Drawing.Size(31, 29);
            this.LblScanTitle.TabIndex = 5;
            this.LblScanTitle.Text = "...";
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.Depth = 0;
            this.CmdClose.Location = new System.Drawing.Point(698, 528);
            this.CmdClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Primary = true;
            this.CmdClose.Size = new System.Drawing.Size(90, 35);
            this.CmdClose.TabIndex = 13;
            this.CmdClose.Text = "Exit";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // ScanDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.TreScan);
            this.Controls.Add(this.LblScanTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanDetailsView";
            this.Text = "Scan Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreScan;
        private System.Windows.Forms.Label LblScanTitle;
        private MaterialSkin.Controls.MaterialRaisedButton CmdClose;
    }
}