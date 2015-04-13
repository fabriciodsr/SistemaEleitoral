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
			this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.menuStrip1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleiçãoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.dadosToolStripMenuItem,
            this.sobreToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1105, 47);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// eleiçãoToolStripMenuItem
			// 
			this.eleiçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
			this.eleiçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eleiçãoToolStripMenuItem.Image")));
			this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
			this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(90, 43);
			this.eleiçãoToolStripMenuItem.Text = "Eleição";
			this.eleiçãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
			this.iniciarToolStripMenuItem.Text = "Votar";
			this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatoToolStripMenuItem,
            this.eleitorToolStripMenuItem,
            this.mesárioToolStripMenuItem});
			this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(106, 43);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			this.cadastroToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// candidatoToolStripMenuItem
			// 
			this.candidatoToolStripMenuItem.Name = "candidatoToolStripMenuItem";
			this.candidatoToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
			this.candidatoToolStripMenuItem.Text = "Candidato";
			this.candidatoToolStripMenuItem.Click += new System.EventHandler(this.candidatoToolStripMenuItem_Click);
			// 
			// eleitorToolStripMenuItem
			// 
			this.eleitorToolStripMenuItem.Name = "eleitorToolStripMenuItem";
			this.eleitorToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
			this.eleitorToolStripMenuItem.Text = "Eleitor";
			this.eleitorToolStripMenuItem.Click += new System.EventHandler(this.eleitorToolStripMenuItem_Click);
			// 
			// mesárioToolStripMenuItem
			// 
			this.mesárioToolStripMenuItem.Name = "mesárioToolStripMenuItem";
			this.mesárioToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
			this.mesárioToolStripMenuItem.Text = "Mesário";
			this.mesárioToolStripMenuItem.Click += new System.EventHandler(this.mesárioToolStripMenuItem_Click);
			// 
			// dadosToolStripMenuItem
			// 
			this.dadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dadosToolStripMenuItem.Image")));
			this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
			this.dadosToolStripMenuItem.Size = new System.Drawing.Size(82, 43);
			this.dadosToolStripMenuItem.Text = "Dados";
			this.dadosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(78, 43);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1105, 615);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MENU";
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
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
    }
}

