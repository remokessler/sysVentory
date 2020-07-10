namespace sysVentory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblComputerName = new System.Windows.Forms.Label();
            this.LstComputerName = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblComputerName
            // 
            this.LblComputerName.AutoSize = true;
            this.LblComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComputerName.Location = new System.Drawing.Point(11, 9);
            this.LblComputerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblComputerName.Name = "LblComputerName";
            this.LblComputerName.Size = new System.Drawing.Size(153, 20);
            this.LblComputerName.TabIndex = 0;
            this.LblComputerName.Text = "Choose Computer";
            // 
            // LstComputerName
            // 
            this.LstComputerName.BackColor = System.Drawing.SystemColors.Control;
            this.LstComputerName.FormattingEnabled = true;
            this.LstComputerName.Location = new System.Drawing.Point(13, 41);
            this.LstComputerName.Margin = new System.Windows.Forms.Padding(2);
            this.LstComputerName.Name = "LstComputerName";
            this.LstComputerName.Size = new System.Drawing.Size(685, 316);
            this.LstComputerName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(542, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "New Scan";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 394);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LstComputerName);
            this.Controls.Add(this.LblComputerName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "sysInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblComputerName;
        private System.Windows.Forms.ListBox LstComputerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}

