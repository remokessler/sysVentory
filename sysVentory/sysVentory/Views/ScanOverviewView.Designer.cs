namespace sysVentory.Views
{
    partial class ScanOverviewView
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
            this.CmdCompare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LstScans = new System.Windows.Forms.ListView();
            this.CmdDetails = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblActiveComputer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdCompare
            // 
            this.CmdCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCompare.Depth = 0;
            this.CmdCompare.Location = new System.Drawing.Point(736, 502);
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
            this.CmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdDelete.Depth = 0;
            this.CmdDelete.Location = new System.Drawing.Point(864, 502);
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
            this.LstScans.Size = new System.Drawing.Size(965, 421);
            this.LstScans.TabIndex = 4;
            this.LstScans.UseCompatibleStateImageBehavior = false;
            this.LstScans.View = System.Windows.Forms.View.List;
            // 
            // CmdDetails
            // 
            this.CmdDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdDetails.Depth = 0;
            this.CmdDetails.Location = new System.Drawing.Point(608, 502);
            this.CmdDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDetails.Name = "CmdDetails";
            this.CmdDetails.Primary = true;
            this.CmdDetails.Size = new System.Drawing.Size(120, 37);
            this.CmdDetails.TabIndex = 5;
            this.CmdDetails.Text = "Details";
            this.CmdDetails.UseVisualStyleBackColor = true;
            this.CmdDetails.Click += new System.EventHandler(this.CmdDetails_Click);
            // 
            // LblActiveComputer
            // 
            this.LblActiveComputer.AutoSize = true;
            this.LblActiveComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveComputer.ForeColor = System.Drawing.Color.White;
            this.LblActiveComputer.Location = new System.Drawing.Point(15, 43);
            this.LblActiveComputer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblActiveComputer.Name = "LblActiveComputer";
            this.LblActiveComputer.Size = new System.Drawing.Size(31, 29);
            this.LblActiveComputer.TabIndex = 6;
            this.LblActiveComputer.Text = "...";
            // 
            // ScanOverviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.LblActiveComputer);
            this.Controls.Add(this.CmdDetails);
            this.Controls.Add(this.LstScans);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScanOverviewView";
            this.Text = "ScanHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton CmdCompare;
        private MaterialSkin.Controls.MaterialRaisedButton CmdDelete;
        private System.Windows.Forms.ListView LstScans;
        private MaterialSkin.Controls.MaterialRaisedButton CmdDetails;
        private System.Windows.Forms.Label LblActiveComputer;
    }
}