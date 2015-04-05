namespace SistemaEleitoral
{
    partial class frmAutentica_Eleitor_Senha
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
            this.tb_Senha_Autentica_Eleitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Senha_Autentica_Eleitor
            // 
            this.tb_Senha_Autentica_Eleitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Senha_Autentica_Eleitor.Location = new System.Drawing.Point(231, 223);
            this.tb_Senha_Autentica_Eleitor.Name = "tb_Senha_Autentica_Eleitor";
            this.tb_Senha_Autentica_Eleitor.Size = new System.Drawing.Size(220, 20);
            this.tb_Senha_Autentica_Eleitor.TabIndex = 0;
            this.tb_Senha_Autentica_Eleitor.UseSystemPasswordChar = true;
            this.tb_Senha_Autentica_Eleitor.Enter += new System.EventHandler(this.tb_Senha_Autentica_Eleitor_Enter);
            this.tb_Senha_Autentica_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Senha_Autentica_Eleitor_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTENTICAÇÃO DE ELEITOR";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // frmAutentica_Eleitor_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Senha_Autentica_Eleitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutentica_Eleitor_Senha";
            this.Text = "frmAutentica_Eleitor_Senha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAutentica_Eleitor_Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Senha_Autentica_Eleitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}