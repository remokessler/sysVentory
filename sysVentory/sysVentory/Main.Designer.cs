namespace sysVentory
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlScanedComputers = new System.Windows.Forms.Panel();
            this.pnlScanHistroy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlScanedComputers
            // 
            this.pnlScanedComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScanedComputers.Location = new System.Drawing.Point(0, 0);
            this.pnlScanedComputers.Name = "pnlScanedComputers";
            this.pnlScanedComputers.Size = new System.Drawing.Size(244, 514);
            this.pnlScanedComputers.TabIndex = 1;
            // 
            // pnlScanHistroy
            // 
            this.pnlScanHistroy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScanHistroy.Location = new System.Drawing.Point(242, 0);
            this.pnlScanHistroy.Name = "pnlScanHistroy";
            this.pnlScanHistroy.Size = new System.Drawing.Size(642, 514);
            this.pnlScanHistroy.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pnlScanHistroy);
            this.Controls.Add(this.pnlScanedComputers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Main";
            this.Text = "sysInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScanedComputers;
        private System.Windows.Forms.Panel pnlScanHistroy;
    }
}

