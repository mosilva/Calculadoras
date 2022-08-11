namespace Calculadoras
{
    partial class PrincipalMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCalcSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImc,
            this.ToolStripMenuItemCalcSimples});
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // ToolStripMenuItemImc
            // 
            this.ToolStripMenuItemImc.Name = "ToolStripMenuItemImc";
            this.ToolStripMenuItemImc.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemImc.Text = "IMC";
            this.ToolStripMenuItemImc.Click += new System.EventHandler(this.ToolStripMenuItemImc_Click);
            // 
            // ToolStripMenuItemCalcSimples
            // 
            this.ToolStripMenuItemCalcSimples.Name = "ToolStripMenuItemCalcSimples";
            this.ToolStripMenuItemCalcSimples.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCalcSimples.Text = "Padrão";
            this.ToolStripMenuItemCalcSimples.Click += new System.EventHandler(this.ToolStripMenuItemCalcSimples_Click);
            // 
            // PrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 307);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculadorasToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemImc;
        private ToolStripMenuItem ToolStripMenuItemCalcSimples;
    }
}