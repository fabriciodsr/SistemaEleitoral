namespace SistemaEleitoral
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleiçãoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.eleiçãoToolStripMenuItem.Text = "Eleição";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatoToolStripMenuItem,
            this.eleitorToolStripMenuItem,
            this.mesárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // candidatoToolStripMenuItem
            // 
            this.candidatoToolStripMenuItem.Name = "candidatoToolStripMenuItem";
            this.candidatoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.candidatoToolStripMenuItem.Text = "Candidato";
            this.candidatoToolStripMenuItem.Click += new System.EventHandler(this.candidatoToolStripMenuItem_Click);
            // 
            // eleitorToolStripMenuItem
            // 
            this.eleitorToolStripMenuItem.Name = "eleitorToolStripMenuItem";
            this.eleitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eleitorToolStripMenuItem.Text = "Eleitor";
            this.eleitorToolStripMenuItem.Click += new System.EventHandler(this.eleitorToolStripMenuItem_Click);
            // 
            // mesárioToolStripMenuItem
            // 
            this.mesárioToolStripMenuItem.Name = "mesárioToolStripMenuItem";
            this.mesárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mesárioToolStripMenuItem.Text = "Mesário";
            this.mesárioToolStripMenuItem.Click += new System.EventHandler(this.mesárioToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 615);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesárioToolStripMenuItem;
    }
}

