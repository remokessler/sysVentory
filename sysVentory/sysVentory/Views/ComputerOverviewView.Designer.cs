namespace sysVentory.Views
{
    partial class ComputerOverviewView
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
            this.LblComputernames = new System.Windows.Forms.Label();
            this.LstComputers = new System.Windows.Forms.ListView();
            this.CmdDeleteComputer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdNewScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdCompareComputer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // LblComputernames
            // 
            this.LblComputernames.AutoSize = true;
            this.LblComputernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputernames.ForeColor = System.Drawing.Color.White;
            this.LblComputernames.Location = new System.Drawing.Point(20, 25);
            this.LblComputernames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblComputernames.Name = "LblComputernames";
            this.LblComputernames.Size = new System.Drawing.Size(216, 31);
            this.LblComputernames.TabIndex = 1;
            this.LblComputernames.Text = "Select Computer";
            // 
            // LstComputers
            // 
            this.LstComputers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LstComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstComputers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LstComputers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstComputers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LstComputers.ForeColor = System.Drawing.SystemColors.Window;
            this.LstComputers.FullRowSelect = true;
            this.LstComputers.HideSelection = false;
            this.LstComputers.Location = new System.Drawing.Point(20, 68);
            this.LstComputers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstComputers.Name = "LstComputers";
            this.LstComputers.Size = new System.Drawing.Size(372, 508);
            this.LstComputers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LstComputers.TabIndex = 2;
            this.LstComputers.TileSize = new System.Drawing.Size(270, 15);
            this.LstComputers.UseCompatibleStateImageBehavior = false;
            this.LstComputers.View = System.Windows.Forms.View.Tile;
            this.LstComputers.SelectedIndexChanged += new System.EventHandler(this.LstComputers_SelectedComputerChanged);
            // 
            // CmdDeleteComputer
            // 
            this.CmdDeleteComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdDeleteComputer.Depth = 0;
            this.CmdDeleteComputer.Location = new System.Drawing.Point(16, 582);
            this.CmdDeleteComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdDeleteComputer.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDeleteComputer.Name = "CmdDeleteComputer";
            this.CmdDeleteComputer.Primary = true;
            this.CmdDeleteComputer.Size = new System.Drawing.Size(120, 37);
            this.CmdDeleteComputer.TabIndex = 4;
            this.CmdDeleteComputer.Text = "Delete";
            this.CmdDeleteComputer.UseVisualStyleBackColor = true;
            this.CmdDeleteComputer.Click += new System.EventHandler(this.CmdDeleteComputer_Click);
            // 
            // CmdNewScan
            // 
            this.CmdNewScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdNewScan.Depth = 0;
            this.CmdNewScan.Location = new System.Drawing.Point(144, 582);
            this.CmdNewScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdNewScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdNewScan.Name = "CmdNewScan";
            this.CmdNewScan.Primary = true;
            this.CmdNewScan.Size = new System.Drawing.Size(120, 37);
            this.CmdNewScan.TabIndex = 5;
            this.CmdNewScan.Text = "New Scan";
            this.CmdNewScan.UseVisualStyleBackColor = true;
            this.CmdNewScan.Click += new System.EventHandler(this.CmdNewScan_Click);
            // 
            // CmdCompareComputer
            // 
            this.CmdCompareComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdCompareComputer.Depth = 0;
            this.CmdCompareComputer.Location = new System.Drawing.Point(272, 582);
            this.CmdCompareComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdCompareComputer.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdCompareComputer.Name = "CmdCompareComputer";
            this.CmdCompareComputer.Primary = true;
            this.CmdCompareComputer.Size = new System.Drawing.Size(120, 37);
            this.CmdCompareComputer.TabIndex = 6;
            this.CmdCompareComputer.Text = "Compare";
            this.CmdCompareComputer.UseVisualStyleBackColor = true;
            this.CmdCompareComputer.Click += new System.EventHandler(this.CmdCompareComputer_Click);
            // 
            // ScanedComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(397, 634);
            this.ControlBox = false;
            this.Controls.Add(this.CmdCompareComputer);
            this.Controls.Add(this.CmdNewScan);
            this.Controls.Add(this.CmdDeleteComputer);
            this.Controls.Add(this.LstComputers);
            this.Controls.Add(this.LblComputernames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScanedComputers";
            this.Text = "ScanOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblComputernames;
        private System.Windows.Forms.ListView LstComputers;
        private MaterialSkin.Controls.MaterialRaisedButton CmdDeleteComputer;
        private MaterialSkin.Controls.MaterialRaisedButton CmdNewScan;
        private MaterialSkin.Controls.MaterialRaisedButton CmdCompareComputer;
    }
}