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
            this.lstScanHistroy = new System.Windows.Forms.ListBox();
            this.cmdNewScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lstScanHistroy
            // 
            this.lstScanHistroy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScanHistroy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lstScanHistroy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstScanHistroy.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScanHistroy.ForeColor = System.Drawing.Color.White;
            this.lstScanHistroy.FormattingEnabled = true;
            this.lstScanHistroy.ItemHeight = 15;
            this.lstScanHistroy.Location = new System.Drawing.Point(15, 60);
            this.lstScanHistroy.MultiColumn = true;
            this.lstScanHistroy.Name = "lstScanHistroy";
            this.lstScanHistroy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstScanHistroy.Size = new System.Drawing.Size(720, 377);
            this.lstScanHistroy.TabIndex = 0;
            // 
            // cmdNewScan
            // 
            this.cmdNewScan.Depth = 0;
            this.cmdNewScan.Location = new System.Drawing.Point(15, 15);
            this.cmdNewScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdNewScan.Name = "cmdNewScan";
            this.cmdNewScan.Primary = true;
            this.cmdNewScan.Size = new System.Drawing.Size(90, 30);
            this.cmdNewScan.TabIndex = 1;
            this.cmdNewScan.Text = "New Scan";
            this.cmdNewScan.UseVisualStyleBackColor = true;
            this.cmdNewScan.Click += new System.EventHandler(this.cmdNewScan_Click);
            // 
            // cmdCompare
            // 
            this.cmdCompare.Depth = 0;
            this.cmdCompare.Location = new System.Drawing.Point(135, 15);
            this.cmdCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Primary = true;
            this.cmdCompare.Size = new System.Drawing.Size(90, 30);
            this.cmdCompare.TabIndex = 2;
            this.cmdCompare.Text = "Compare";
            this.cmdCompare.UseVisualStyleBackColor = true;
            // 
            // ScanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.cmdCompare);
            this.Controls.Add(this.cmdNewScan);
            this.Controls.Add(this.lstScanHistroy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanHistory";
            this.Text = "ScanHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstScanHistroy;
        private MaterialSkin.Controls.MaterialRaisedButton cmdNewScan;
        private MaterialSkin.Controls.MaterialRaisedButton cmdCompare;
    }
}