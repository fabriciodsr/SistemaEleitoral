namespace SistemaEleitoral
{
	partial class frmCadastroTurma
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTurma));
			this.txtDescricaoTurma = new System.Windows.Forms.TextBox();
			this.txtAnoTurma = new System.Windows.Forms.TextBox();
			this.txtNumeroTurma = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDescricaoTurma
			// 
			this.txtDescricaoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtDescricaoTurma.Location = new System.Drawing.Point(138, 90);
			this.txtDescricaoTurma.MaxLength = 50;
			this.txtDescricaoTurma.Name = "txtDescricaoTurma";
			this.txtDescricaoTurma.Size = new System.Drawing.Size(508, 24);
			this.txtDescricaoTurma.TabIndex = 28;
			// 
			// txtAnoTurma
			// 
			this.txtAnoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtAnoTurma.Location = new System.Drawing.Point(138, 60);
			this.txtAnoTurma.MaxLength = 4;
			this.txtAnoTurma.Name = "txtAnoTurma";
			this.txtAnoTurma.Size = new System.Drawing.Size(45, 24);
			this.txtAnoTurma.TabIndex = 26;
			// 
			// txtNumeroTurma
			// 
			this.txtNumeroTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtNumeroTurma.Location = new System.Drawing.Point(138, 30);
			this.txtNumeroTurma.MaxLength = 4;
			this.txtNumeroTurma.Name = "txtNumeroTurma";
			this.txtNumeroTurma.Size = new System.Drawing.Size(45, 24);
			this.txtNumeroTurma.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label7.Location = new System.Drawing.Point(59, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 18);
			this.label7.TabIndex = 29;
			this.label7.Text = "Número:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label2.Location = new System.Drawing.Point(42, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 18);
			this.label2.TabIndex = 27;
			this.label2.Text = "Descrição:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label1.Location = new System.Drawing.Point(90, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 18);
			this.label1.TabIndex = 25;
			this.label1.Text = "Ano:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(597, 238);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(49, 44);
			this.btnCancelar.TabIndex = 31;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalvar.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.Location = new System.Drawing.Point(501, 238);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(90, 44);
			this.btnSalvar.TabIndex = 30;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.BackColor = System.Drawing.Color.Transparent;
			this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFechar.FlatAppearance.BorderSize = 0;
			this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
			this.btnFechar.Location = new System.Drawing.Point(653, 1);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(26, 24);
			this.btnFechar.TabIndex = 56;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// frmCadastroTurma
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SistemaEleitoral.Properties.Resources.Fundo_Tela_Login;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(681, 313);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtDescricaoTurma);
			this.Controls.Add(this.txtAnoTurma);
			this.Controls.Add(this.txtNumeroTurma);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCadastroTurma";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastrarTurma";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtDescricaoTurma;
		private System.Windows.Forms.TextBox txtAnoTurma;
		private System.Windows.Forms.TextBox txtNumeroTurma;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFechar;
	}
}