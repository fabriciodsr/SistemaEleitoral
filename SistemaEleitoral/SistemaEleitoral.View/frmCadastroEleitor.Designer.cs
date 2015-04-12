namespace SistemaEleitoral
{
    partial class frmCadastroEleitor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEleitor));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCodigoEleitor = new System.Windows.Forms.TextBox();
			this.txtNomeEleitor = new System.Windows.Forms.TextBox();
			this.txtRgEleitor = new System.Windows.Forms.TextBox();
			this.txtCpfEleitor = new System.Windows.Forms.TextBox();
			this.txtEnderecoEleitor = new System.Windows.Forms.TextBox();
			this.mtbTelEleitor = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbEstadoEleitor = new System.Windows.Forms.ComboBox();
			this.mtbCepEleitor = new System.Windows.Forms.MaskedTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtEmailEleitor = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbSexoEleitor = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.dtpDataNascEleitor = new System.Windows.Forms.DateTimePicker();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label1.Location = new System.Drawing.Point(74, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label2.Location = new System.Drawing.Point(47, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Endereço:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label3.Location = new System.Drawing.Point(54, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefone:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label4.Location = new System.Drawing.Point(94, 276);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "RG:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label5.Location = new System.Drawing.Point(86, 306);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "CPF:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label6.Location = new System.Drawing.Point(12, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Data de Nasc.:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label7.Location = new System.Drawing.Point(50, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Matrícula:";
			// 
			// txtCodigoEleitor
			// 
			this.txtCodigoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtCodigoEleitor.Location = new System.Drawing.Point(139, 31);
			this.txtCodigoEleitor.MaxLength = 8;
			this.txtCodigoEleitor.Name = "txtCodigoEleitor";
			this.txtCodigoEleitor.Size = new System.Drawing.Size(80, 24);
			this.txtCodigoEleitor.TabIndex = 7;
			// 
			// txtNomeEleitor
			// 
			this.txtNomeEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtNomeEleitor.Location = new System.Drawing.Point(139, 61);
			this.txtNomeEleitor.MaxLength = 50;
			this.txtNomeEleitor.Name = "txtNomeEleitor";
			this.txtNomeEleitor.Size = new System.Drawing.Size(508, 24);
			this.txtNomeEleitor.TabIndex = 1;
			// 
			// txtRgEleitor
			// 
			this.txtRgEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtRgEleitor.Location = new System.Drawing.Point(139, 273);
			this.txtRgEleitor.MaxLength = 10;
			this.txtRgEleitor.Name = "txtRgEleitor";
			this.txtRgEleitor.Size = new System.Drawing.Size(110, 24);
			this.txtRgEleitor.TabIndex = 4;
			// 
			// txtCpfEleitor
			// 
			this.txtCpfEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtCpfEleitor.Location = new System.Drawing.Point(139, 303);
			this.txtCpfEleitor.MaxLength = 11;
			this.txtCpfEleitor.Name = "txtCpfEleitor";
			this.txtCpfEleitor.Size = new System.Drawing.Size(121, 24);
			this.txtCpfEleitor.TabIndex = 5;
			// 
			// txtEnderecoEleitor
			// 
			this.txtEnderecoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtEnderecoEleitor.Location = new System.Drawing.Point(139, 91);
			this.txtEnderecoEleitor.MaxLength = 50;
			this.txtEnderecoEleitor.Name = "txtEnderecoEleitor";
			this.txtEnderecoEleitor.Size = new System.Drawing.Size(508, 24);
			this.txtEnderecoEleitor.TabIndex = 2;
			// 
			// mtbTelEleitor
			// 
			this.mtbTelEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.mtbTelEleitor.Location = new System.Drawing.Point(139, 243);
			this.mtbTelEleitor.Mask = "(99) 0000-0000";
			this.mtbTelEleitor.Name = "mtbTelEleitor";
			this.mtbTelEleitor.Size = new System.Drawing.Size(110, 24);
			this.mtbTelEleitor.TabIndex = 3;
			this.mtbTelEleitor.Tag = "";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label10.Location = new System.Drawing.Point(85, 184);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 18);
			this.label10.TabIndex = 12;
			this.label10.Text = "CEP:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label11.Location = new System.Drawing.Point(66, 214);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 18);
			this.label11.TabIndex = 14;
			this.label11.Text = "Estado:";
			// 
			// cmbEstadoEleitor
			// 
			this.cmbEstadoEleitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstadoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbEstadoEleitor.FormattingEnabled = true;
			this.cmbEstadoEleitor.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
			this.cmbEstadoEleitor.Location = new System.Drawing.Point(139, 211);
			this.cmbEstadoEleitor.Name = "cmbEstadoEleitor";
			this.cmbEstadoEleitor.Size = new System.Drawing.Size(177, 26);
			this.cmbEstadoEleitor.TabIndex = 15;
			// 
			// mtbCepEleitor
			// 
			this.mtbCepEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.mtbCepEleitor.Location = new System.Drawing.Point(139, 181);
			this.mtbCepEleitor.Mask = "00000-999";
			this.mtbCepEleitor.Name = "mtbCepEleitor";
			this.mtbCepEleitor.Size = new System.Drawing.Size(80, 24);
			this.mtbCepEleitor.TabIndex = 16;
			this.mtbCepEleitor.Tag = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label12.Location = new System.Drawing.Point(71, 367);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 18);
			this.label12.TabIndex = 17;
			this.label12.Text = "E-mail:";
			// 
			// txtEmailEleitor
			// 
			this.txtEmailEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtEmailEleitor.Location = new System.Drawing.Point(139, 364);
			this.txtEmailEleitor.MaxLength = 40;
			this.txtEmailEleitor.Name = "txtEmailEleitor";
			this.txtEmailEleitor.Size = new System.Drawing.Size(406, 24);
			this.txtEmailEleitor.TabIndex = 19;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label13.Location = new System.Drawing.Point(81, 397);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 18);
			this.label13.TabIndex = 20;
			this.label13.Text = "Sexo:";
			// 
			// cmbSexoEleitor
			// 
			this.cmbSexoEleitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbSexoEleitor.FormattingEnabled = true;
			this.cmbSexoEleitor.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
			this.cmbSexoEleitor.Location = new System.Drawing.Point(139, 394);
			this.cmbSexoEleitor.Name = "cmbSexoEleitor";
			this.cmbSexoEleitor.Size = new System.Drawing.Size(132, 26);
			this.cmbSexoEleitor.TabIndex = 21;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(445, 443);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(49, 44);
			this.btnCancelar.TabIndex = 23;
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
			this.btnSalvar.Location = new System.Drawing.Point(349, 443);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(90, 44);
			this.btnSalvar.TabIndex = 22;
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
			this.btnFechar.Location = new System.Drawing.Point(741, 1);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(26, 24);
			this.btnFechar.TabIndex = 24;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// dtpDataNascEleitor
			// 
			this.dtpDataNascEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.dtpDataNascEleitor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNascEleitor.Location = new System.Drawing.Point(139, 334);
			this.dtpDataNascEleitor.Name = "dtpDataNascEleitor";
			this.dtpDataNascEleitor.Size = new System.Drawing.Size(110, 24);
			this.dtpDataNascEleitor.TabIndex = 59;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtCidade.Location = new System.Drawing.Point(139, 151);
			this.txtCidade.MaxLength = 30;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(311, 24);
			this.txtCidade.TabIndex = 63;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label9.Location = new System.Drawing.Point(67, 154);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 18);
			this.label9.TabIndex = 62;
			this.label9.Text = "Cidade:";
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtBairro.Location = new System.Drawing.Point(139, 121);
			this.txtBairro.MaxLength = 30;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(311, 24);
			this.txtBairro.TabIndex = 61;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label8.Location = new System.Drawing.Point(73, 124);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 18);
			this.label8.TabIndex = 60;
			this.label8.Text = "Bairro:";
			// 
			// frmCadastroEleitor
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(768, 540);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpDataNascEleitor);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cmbSexoEleitor);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtEmailEleitor);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.mtbCepEleitor);
			this.Controls.Add(this.cmbEstadoEleitor);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.mtbTelEleitor);
			this.Controls.Add(this.txtEnderecoEleitor);
			this.Controls.Add(this.txtCpfEleitor);
			this.Controls.Add(this.txtRgEleitor);
			this.Controls.Add(this.txtNomeEleitor);
			this.Controls.Add(this.txtCodigoEleitor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCadastroEleitor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Eleitor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoEleitor;
        private System.Windows.Forms.TextBox txtNomeEleitor;
        private System.Windows.Forms.TextBox txtRgEleitor;
        private System.Windows.Forms.TextBox txtCpfEleitor;
        private System.Windows.Forms.TextBox txtEnderecoEleitor;
        private System.Windows.Forms.MaskedTextBox mtbTelEleitor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEstadoEleitor;
        private System.Windows.Forms.MaskedTextBox mtbCepEleitor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailEleitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSexoEleitor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.DateTimePicker dtpDataNascEleitor;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label8;
	}
}