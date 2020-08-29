namespace sysVentory.Views
{
    partial class ScanHistory
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
            this.CmdNewScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LstScans = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CmdNewScan
            // 
            this.CmdNewScan.Depth = 0;
            this.CmdNewScan.Location = new System.Drawing.Point(20, 18);
            this.CmdNewScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdNewScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNewScan.Name = "CmdNewScan";
            this.CmdNewScan.Primary = true;
            this.CmdNewScan.Size = new System.Drawing.Size(120, 37);
            this.CmdNewScan.TabIndex = 1;
            this.CmdNewScan.Text = "New Scan";
            this.CmdNewScan.UseVisualStyleBackColor = true;
            this.CmdNewScan.Click += new System.EventHandler(this.CmdNewScan_Click);
            // 
            // CmdCompare
            // 
            this.CmdCompare.Depth = 0;
            this.CmdCompare.Location = new System.Drawing.Point(180, 18);
            this.CmdCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCompare.Name = "CmdCompare";
            this.CmdCompare.Primary = true;
            this.CmdCompare.Size = new System.Drawing.Size(120, 37);
            this.CmdCompare.TabIndex = 2;
            this.CmdCompare.Text = "Compare";
            this.CmdCompare.UseVisualStyleBackColor = true;
            this.CmdCompare.Click += new System.EventHandler(this.CmdCompare_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Depth = 0;
            this.CmdDelete.Location = new System.Drawing.Point(340, 18);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Primary = true;
            this.CmdDelete.Size = new System.Drawing.Size(120, 37);
            this.CmdDelete.TabIndex = 3;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // LstScans
            // 
            this.LstScans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.LstScans.ForeColor = System.Drawing.SystemColors.Window;
            this.LstScans.HideSelection = false;
            this.LstScans.Location = new System.Drawing.Point(20, 74);
            this.LstScans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstScans.Name = "LstScans";
            this.LstScans.Size = new System.Drawing.Size(965, 454);
            this.LstScans.TabIndex = 4;
            this.LstScans.UseCompatibleStateImageBehavior = false;
            this.LstScans.View = System.Windows.Forms.View.List;
            // 
            // ScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.LstScans);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdCompare);
            this.Controls.Add(this.CmdNewScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScanHistory";
            this.Text = "ScanHistory";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton CmdNewScan;
        private MaterialSkin.Controls.MaterialRaisedButton CmdCompare;
        private MaterialSkin.Controls.MaterialRaisedButton CmdDelete;
        private System.Windows.Forms.ListView LstScans;
    }
}