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
            this.CmdNewScan.Location = new System.Drawing.Point(15, 15);
            this.CmdNewScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNewScan.Name = "CmdNewScan";
            this.CmdNewScan.Primary = true;
            this.CmdNewScan.Size = new System.Drawing.Size(90, 30);
            this.CmdNewScan.TabIndex = 1;
            this.CmdNewScan.Text = "New Scan";
            this.CmdNewScan.UseVisualStyleBackColor = true;
            this.CmdNewScan.Click += new System.EventHandler(this.CmdNewScan_Click);
            this.CmdNewScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdNewScan_MouseClick);
            // 
            // CmdCompare
            // 
            this.CmdCompare.Depth = 0;
            this.CmdCompare.Location = new System.Drawing.Point(135, 15);
            this.CmdCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCompare.Name = "CmdCompare";
            this.CmdCompare.Primary = true;
            this.CmdCompare.Size = new System.Drawing.Size(90, 30);
            this.CmdCompare.TabIndex = 2;
            this.CmdCompare.Text = "Compare";
            this.CmdCompare.UseVisualStyleBackColor = true;
            this.CmdCompare.Click += new System.EventHandler(this.CmdCompare_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Depth = 0;
            this.CmdDelete.Location = new System.Drawing.Point(255, 15);
            this.CmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Primary = true;
            this.CmdDelete.Size = new System.Drawing.Size(90, 30);
            this.CmdDelete.TabIndex = 3;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // LstScans
            // 
            this.LstScans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.LstScans.ForeColor = System.Drawing.SystemColors.Window;
            this.LstScans.HideSelection = false;
            this.LstScans.Location = new System.Drawing.Point(15, 60);
            this.LstScans.Margin = new System.Windows.Forms.Padding(2);
            this.LstScans.Name = "LstScans";
            this.LstScans.Size = new System.Drawing.Size(725, 370);
            this.LstScans.TabIndex = 4;
            this.LstScans.UseCompatibleStateImageBehavior = false;
            this.LstScans.View = System.Windows.Forms.View.List;
            // 
            // ScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.LstScans);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdCompare);
            this.Controls.Add(this.CmdNewScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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