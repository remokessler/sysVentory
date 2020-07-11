namespace sysVentory
{
    partial class sysInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sysInventoryForm));
            this.LblTitel = new System.Windows.Forms.Label();
            this.LstChoose = new System.Windows.Forms.ListBox();
            this.CmdShowDetails = new System.Windows.Forms.Button();
            this.CmdNewScan = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitel
            // 
            this.LblTitel.AutoSize = true;
            this.LblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitel.Location = new System.Drawing.Point(11, 9);
            this.LblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitel.Name = "LblTitel";
            this.LblTitel.Size = new System.Drawing.Size(153, 20);
            this.LblTitel.TabIndex = 0;
            this.LblTitel.Text = "Choose Computer";
            // 
            // LstChoose
            // 
            this.LstChoose.BackColor = System.Drawing.SystemColors.Control;
            this.LstChoose.FormattingEnabled = true;
            this.LstChoose.Location = new System.Drawing.Point(13, 41);
            this.LstChoose.Margin = new System.Windows.Forms.Padding(2);
            this.LstChoose.Name = "LstChoose";
            this.LstChoose.Size = new System.Drawing.Size(685, 316);
            this.LstChoose.TabIndex = 1;
            // 
            // CmdShowDetails
            // 
            this.CmdShowDetails.Location = new System.Drawing.Point(542, 362);
            this.CmdShowDetails.Name = "CmdShowDetails";
            this.CmdShowDetails.Size = new System.Drawing.Size(75, 23);
            this.CmdShowDetails.TabIndex = 2;
            this.CmdShowDetails.Text = "Show details";
            this.CmdShowDetails.UseVisualStyleBackColor = true;
            this.CmdShowDetails.Click += new System.EventHandler(this.CmdShowDetails_Click);
            // 
            // CmdNewScan
            // 
            this.CmdNewScan.Location = new System.Drawing.Point(461, 362);
            this.CmdNewScan.Name = "CmdNewScan";
            this.CmdNewScan.Size = new System.Drawing.Size(75, 23);
            this.CmdNewScan.TabIndex = 10;
            this.CmdNewScan.Text = "New Scan";
            this.CmdNewScan.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(623, 362);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 11;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // sysInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 394);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdNewScan);
            this.Controls.Add(this.CmdShowDetails);
            this.Controls.Add(this.LstChoose);
            this.Controls.Add(this.LblTitel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sysInventoryForm";
            this.Text = "sysInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitel;
        private System.Windows.Forms.ListBox LstChoose;
        private System.Windows.Forms.Button CmdShowDetails;
        private System.Windows.Forms.Button CmdNewScan;
        private System.Windows.Forms.Button CmdDelete;
    }
}

