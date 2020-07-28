namespace sysVentory
{
    partial class Exit
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.CmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdExit
            // 
            this.CmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdExit.Image = ((System.Drawing.Image)(resources.GetObject("CmdExit.Image")));
            this.CmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdExit.Location = new System.Drawing.Point(5, 3);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(69, 34);
            this.CmdExit.TabIndex = 16;
            this.CmdExit.Text = "Exit";
            this.CmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdExit);
            this.Name = "Exit";
            this.Size = new System.Drawing.Size(77, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdExit;
    }
}
