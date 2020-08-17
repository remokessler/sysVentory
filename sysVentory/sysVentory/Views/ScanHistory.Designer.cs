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
            this.cmdNewScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LstScans = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmdNewScan
            // 
            this.cmdNewScan.Depth = 0;
            this.cmdNewScan.Location = new System.Drawing.Point(20, 18);
            this.cmdNewScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdNewScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdNewScan.Name = "cmdNewScan";
            this.cmdNewScan.Primary = true;
            this.cmdNewScan.Size = new System.Drawing.Size(120, 37);
            this.cmdNewScan.TabIndex = 1;
            this.cmdNewScan.Text = "New Scan";
            this.cmdNewScan.UseVisualStyleBackColor = true;
            this.cmdNewScan.Click += new System.EventHandler(this.cmdNewScan_Click);
            // 
            // cmdCompare
            // 
            this.cmdCompare.Depth = 0;
            this.cmdCompare.Location = new System.Drawing.Point(180, 18);
            this.cmdCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Primary = true;
            this.cmdCompare.Size = new System.Drawing.Size(120, 37);
            this.cmdCompare.TabIndex = 2;
            this.cmdCompare.Text = "Compare";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Depth = 0;
            this.cmdDelete.Location = new System.Drawing.Point(340, 18);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Primary = true;
            this.cmdDelete.Size = new System.Drawing.Size(120, 37);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // LstScans
            // 
            this.LstScans.BackColor = System.Drawing.Color.White;
            this.LstScans.HideSelection = false;
            this.LstScans.Location = new System.Drawing.Point(20, 70);
            this.LstScans.Name = "LstScans";
            this.LstScans.Size = new System.Drawing.Size(968, 472);
            this.LstScans.TabIndex = 4;
            this.LstScans.UseCompatibleStateImageBehavior = false;
            // 
            // ScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.LstScans);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdCompare);
            this.Controls.Add(this.cmdNewScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScanHistory";
            this.Text = "ScanHistory";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton cmdNewScan;
        private MaterialSkin.Controls.MaterialRaisedButton cmdCompare;
        private MaterialSkin.Controls.MaterialRaisedButton cmdDelete;
        private System.Windows.Forms.ListView LstScans;
    }
}