namespace SistemaEleitoral
{
    partial class frmAutentica_Eleitor_Matricula
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutentica_Eleitor_Matricula));
			this.tb_Matricula_Autentica_Eleitor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_Matricula_Autentica_Eleitor
			// 
			this.tb_Matricula_Autentica_Eleitor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_Matricula_Autentica_Eleitor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_Matricula_Autentica_Eleitor.Location = new System.Drawing.Point(231, 233);
			this.tb_Matricula_Autentica_Eleitor.MaxLength = 8;
			this.tb_Matricula_Autentica_Eleitor.Name = "tb_Matricula_Autentica_Eleitor";
			this.tb_Matricula_Autentica_Eleitor.Size = new System.Drawing.Size(220, 27);
			this.tb_Matricula_Autentica_Eleitor.TabIndex = 0;
			this.tb_Matricula_Autentica_Eleitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tb_Matricula_Autentica_Eleitor.Enter += new System.EventHandler(this.tb_Matricula_Autentica_Eleitor_Enter);
			this.tb_Matricula_Autentica_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Matricula_Autentica_Eleitor_KeyPress);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
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
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label2.Location = new System.Drawing.Point(280, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "MATRÍCULA";
			// 
			// frmAutentica_Eleitor_Matricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(694, 504);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_Matricula_Autentica_Eleitor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAutentica_Eleitor_Matricula";
			this.Text = "frmAutentica_Eleitor_Matricula";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAutentica_Eleitor_Matricula_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAutentica_Eleitor_Matricula_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Matricula_Autentica_Eleitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}