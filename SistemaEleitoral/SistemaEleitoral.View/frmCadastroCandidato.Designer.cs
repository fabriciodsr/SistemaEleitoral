namespace SistemaEleitoral
{
    partial class frmCadastroCandidato
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCandidato));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.mtbCep = new System.Windows.Forms.MaskedTextBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.mtbTel = new System.Windows.Forms.MaskedTextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtRg = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFoto = new System.Windows.Forms.TextBox();
			this.btnCarregarFoto = new System.Windows.Forms.Button();
			this.pbCandidato = new System.Windows.Forms.PictureBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.cmbCargo = new System.Windows.Forms.ComboBox();
			this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.pbCandidato)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(446, 440);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(49, 44);
			this.btnCancelar.TabIndex = 51;
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
			this.btnSalvar.Location = new System.Drawing.Point(350, 440);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(90, 44);
			this.btnSalvar.TabIndex = 50;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
			this.cmbSexo.Location = new System.Drawing.Point(140, 391);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(132, 26);
			this.cmbSexo.TabIndex = 13;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label13.Location = new System.Drawing.Point(82, 394);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 18);
			this.label13.TabIndex = 48;
			this.label13.Text = "Sexo:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtEmail.Location = new System.Drawing.Point(140, 361);
			this.txtEmail.MaxLength = 40;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(410, 24);
			this.txtEmail.TabIndex = 12;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label12.Location = new System.Drawing.Point(72, 364);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 18);
			this.label12.TabIndex = 46;
			this.label12.Text = "E-mail:";
			// 
			// mtbCep
			// 
			this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.mtbCep.Location = new System.Drawing.Point(140, 178);
			this.mtbCep.Mask = "00000-999";
			this.mtbCep.Name = "mtbCep";
			this.mtbCep.Size = new System.Drawing.Size(80, 24);
			this.mtbCep.TabIndex = 6;
			this.mtbCep.Tag = "";
			// 
			// cmbEstado
			// 
			this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
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
			this.cmbEstado.Location = new System.Drawing.Point(140, 208);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(177, 26);
			this.cmbEstado.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label11.Location = new System.Drawing.Point(67, 211);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 18);
			this.label11.TabIndex = 43;
			this.label11.Text = "Estado:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label10.Location = new System.Drawing.Point(86, 181);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 18);
			this.label10.TabIndex = 42;
			this.label10.Text = "CEP:";
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtCidade.Location = new System.Drawing.Point(140, 148);
			this.txtCidade.MaxLength = 30;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(311, 24);
			this.txtCidade.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label9.Location = new System.Drawing.Point(68, 151);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 18);
			this.label9.TabIndex = 40;
			this.label9.Text = "Cidade:";
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtBairro.Location = new System.Drawing.Point(140, 118);
			this.txtBairro.MaxLength = 30;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(311, 24);
			this.txtBairro.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label8.Location = new System.Drawing.Point(74, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 18);
			this.label8.TabIndex = 38;
			this.label8.Text = "Bairro:";
			// 
			// mtbTel
			// 
			this.mtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.mtbTel.Location = new System.Drawing.Point(140, 240);
			this.mtbTel.Mask = "(99) 0000-0000";
			this.mtbTel.Name = "mtbTel";
			this.mtbTel.Size = new System.Drawing.Size(110, 24);
			this.mtbTel.TabIndex = 8;
			this.mtbTel.Tag = "";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtEndereco.Location = new System.Drawing.Point(140, 88);
			this.txtEndereco.MaxLength = 50;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(508, 24);
			this.txtEndereco.TabIndex = 3;
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtCpf.Location = new System.Drawing.Point(140, 300);
			this.txtCpf.MaxLength = 11;
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(121, 24);
			this.txtCpf.TabIndex = 10;
			// 
			// txtRg
			// 
			this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtRg.Location = new System.Drawing.Point(140, 270);
			this.txtRg.MaxLength = 10;
			this.txtRg.Name = "txtRg";
			this.txtRg.Size = new System.Drawing.Size(110, 24);
			this.txtRg.TabIndex = 9;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtNome.Location = new System.Drawing.Point(140, 58);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(508, 24);
			this.txtNome.TabIndex = 2;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtNumero.Location = new System.Drawing.Point(140, 28);
			this.txtNumero.MaxLength = 2;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(34, 24);
			this.txtNumero.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label7.Location = new System.Drawing.Point(60, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 18);
			this.label7.TabIndex = 35;
			this.label7.Text = "Número:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label6.Location = new System.Drawing.Point(13, 333);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 18);
			this.label6.TabIndex = 33;
			this.label6.Text = "Data de Nasc.:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label5.Location = new System.Drawing.Point(87, 303);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 18);
			this.label5.TabIndex = 31;
			this.label5.Text = "CPF:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label4.Location = new System.Drawing.Point(95, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 18);
			this.label4.TabIndex = 29;
			this.label4.Text = "RG:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label3.Location = new System.Drawing.Point(55, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 27;
			this.label3.Text = "Telefone:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label2.Location = new System.Drawing.Point(48, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 18);
			this.label2.TabIndex = 26;
			this.label2.Text = "Endereço:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label1.Location = new System.Drawing.Point(75, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "Nome:";
			// 
			// txtFoto
			// 
			this.txtFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFoto.BackColor = System.Drawing.Color.White;
			this.txtFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.txtFoto.ForeColor = System.Drawing.Color.Black;
			this.txtFoto.Location = new System.Drawing.Point(469, 178);
			this.txtFoto.Name = "txtFoto";
			this.txtFoto.Size = new System.Drawing.Size(230, 24);
			this.txtFoto.TabIndex = 14;
			this.txtFoto.Text = "foto.jpg";
			// 
			// btnCarregarFoto
			// 
			this.btnCarregarFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarregarFoto.BackgroundImage")));
			this.btnCarregarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnCarregarFoto.Location = new System.Drawing.Point(704, 177);
			this.btnCarregarFoto.Name = "btnCarregarFoto";
			this.btnCarregarFoto.Size = new System.Drawing.Size(27, 25);
			this.btnCarregarFoto.TabIndex = 53;
			this.btnCarregarFoto.UseVisualStyleBackColor = true;
			this.btnCarregarFoto.Click += new System.EventHandler(this.button1_Click);
			// 
			// pbCandidato
			// 
			this.pbCandidato.BackColor = System.Drawing.Color.Transparent;
			this.pbCandidato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbCandidato.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCandidato.InitialImage")));
			this.pbCandidato.Location = new System.Drawing.Point(570, 208);
			this.pbCandidato.Name = "pbCandidato";
			this.pbCandidato.Size = new System.Drawing.Size(161, 200);
			this.pbCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbCandidato.TabIndex = 54;
			this.pbCandidato.TabStop = false;
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
			this.btnFechar.TabIndex = 55;
			this.btnFechar.UseVisualStyleBackColor = false;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.label14.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.label14.Location = new System.Drawing.Point(264, 31);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(59, 18);
			this.label14.TabIndex = 56;
			this.label14.Text = "Cargo:";
			// 
			// cmbCargo
			// 
			this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.cmbCargo.FormattingEnabled = true;
			this.cmbCargo.Items.AddRange(new object[] {
            "REPRESENTANTE DE TURMA",
            "COORDENADOR",
            "DIRETOR"});
			this.cmbCargo.Location = new System.Drawing.Point(323, 28);
			this.cmbCargo.Name = "cmbCargo";
			this.cmbCargo.Size = new System.Drawing.Size(325, 26);
			this.cmbCargo.TabIndex = 1;
			// 
			// dtpDataNasc
			// 
			this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNasc.Location = new System.Drawing.Point(140, 331);
			this.dtpDataNasc.Name = "dtpDataNasc";
			this.dtpDataNasc.Size = new System.Drawing.Size(110, 24);
			this.dtpDataNasc.TabIndex = 11;
			// 
			// frmCadastroCandidato
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(768, 540);
			this.Controls.Add(this.dtpDataNasc);
			this.Controls.Add(this.cmbCargo);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.pbCandidato);
			this.Controls.Add(this.btnCarregarFoto);
			this.Controls.Add(this.txtFoto);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.mtbCep);
			this.Controls.Add(this.cmbEstado);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.mtbTel);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtRg);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtNumero);
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
			this.Name = "frmCadastroCandidato";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Candidato";
			((System.ComponentModel.ISupportInitialize)(this.pbCandidato)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.PictureBox pbCandidato;
        private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmbCargo;
		private System.Windows.Forms.DateTimePicker dtpDataNasc;
	}
}