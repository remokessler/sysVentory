namespace sysVentory
{
    partial class ScansControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdNewScan = new System.Windows.Forms.Button();
            this.CmdDeleteScans = new System.Windows.Forms.Button();
            this.LstScans = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdNewScan
            // 
            this.CmdNewScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdNewScan.Location = new System.Drawing.Point(562, 385);
            this.CmdNewScan.Name = "CmdNewScan";
            this.CmdNewScan.Size = new System.Drawing.Size(75, 23);
            this.CmdNewScan.TabIndex = 14;
            this.CmdNewScan.Text = "New Scan";
            this.CmdNewScan.UseVisualStyleBackColor = true;
            this.CmdNewScan.Click += new System.EventHandler(this.CmdNewScan_Click);
            // 
            // CmdDeleteScans
            // 
            this.CmdDeleteScans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdDeleteScans.Location = new System.Drawing.Point(643, 385);
            this.CmdDeleteScans.Name = "CmdDeleteScans";
            this.CmdDeleteScans.Size = new System.Drawing.Size(75, 23);
            this.CmdDeleteScans.TabIndex = 13;
            this.CmdDeleteScans.Text = "Delete";
            this.CmdDeleteScans.UseVisualStyleBackColor = true;
            // 
            // LstScans
            // 
            this.LstScans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstScans.BackColor = System.Drawing.SystemColors.Control;
            this.LstScans.FormattingEnabled = true;
            this.LstScans.Location = new System.Drawing.Point(3, 2);
            this.LstScans.Margin = new System.Windows.Forms.Padding(2);
            this.LstScans.Name = "LstScans";
            this.LstScans.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstScans.Size = new System.Drawing.Size(716, 368);
            this.LstScans.TabIndex = 12;
            // 
            // ScansControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdNewScan);
            this.Controls.Add(this.CmdDeleteScans);
            this.Controls.Add(this.LstScans);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScansControl";
            this.Size = new System.Drawing.Size(721, 411);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdNewScan;
        private System.Windows.Forms.Button CmdDeleteScans;
        private System.Windows.Forms.ListBox LstScans;
    }
}
