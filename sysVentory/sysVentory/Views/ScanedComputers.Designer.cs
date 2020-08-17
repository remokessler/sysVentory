namespace sysVentory.Views
{
    partial class ScanedComputers
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
            this.LstComputers.HideSelection = false;
            this.LstComputers.Location = new System.Drawing.Point(26, 72);
            this.LstComputers.Name = "LstComputers";
            this.LstComputers.Size = new System.Drawing.Size(269, 537);
            this.LstComputers.TabIndex = 2;
            this.LstComputers.UseCompatibleStateImageBehavior = false;
            this.LstComputers.SelectedIndexChanged += new System.EventHandler(this.LstComputers_SelectedComputerChanged);
            // 
            // ScanedComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(307, 634);
            this.ControlBox = false;
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
    }
}