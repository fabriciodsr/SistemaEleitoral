﻿namespace SistemaEleitoral
{
    partial class frmCadastroMesario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMesario));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbSexoEleitor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmailEleitor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbCepEleitor = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstadoEleitor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbDataNascEleitor = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelEleitor = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoEleitor = new System.Windows.Forms.TextBox();
            this.txtCpfEleitor = new System.Windows.Forms.TextBox();
            this.txtRgEleitor = new System.Windows.Forms.TextBox();
            this.txtNomeEleitor = new System.Windows.Forms.TextBox();
            this.txtCodigoEleitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
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
            this.btnCancelar.Location = new System.Drawing.Point(707, 456);
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
            this.btnSalvar.Location = new System.Drawing.Point(611, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 44);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbSexoEleitor
            // 
            this.cmbSexoEleitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbSexoEleitor.FormattingEnabled = true;
            this.cmbSexoEleitor.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexoEleitor.Location = new System.Drawing.Point(140, 426);
            this.cmbSexoEleitor.Name = "cmbSexoEleitor";
            this.cmbSexoEleitor.Size = new System.Drawing.Size(132, 26);
            this.cmbSexoEleitor.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.Location = new System.Drawing.Point(84, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Sexo:";
            // 
            // txtEmailEleitor
            // 
            this.txtEmailEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEmailEleitor.Location = new System.Drawing.Point(140, 396);
            this.txtEmailEleitor.MaxLength = 40;
            this.txtEmailEleitor.Name = "txtEmailEleitor";
            this.txtEmailEleitor.Size = new System.Drawing.Size(406, 24);
            this.txtEmailEleitor.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(74, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "E-mail:";
            // 
            // mtbCepEleitor
            // 
            this.mtbCepEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtbCepEleitor.Location = new System.Drawing.Point(140, 213);
            this.mtbCepEleitor.Mask = "00000-999";
            this.mtbCepEleitor.Name = "mtbCepEleitor";
            this.mtbCepEleitor.Size = new System.Drawing.Size(80, 24);
            this.mtbCepEleitor.TabIndex = 45;
            this.mtbCepEleitor.Tag = "";
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
            this.cmbEstadoEleitor.Location = new System.Drawing.Point(140, 243);
            this.cmbEstadoEleitor.Name = "cmbEstadoEleitor";
            this.cmbEstadoEleitor.Size = new System.Drawing.Size(177, 26);
            this.cmbEstadoEleitor.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(69, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 43;
            this.label11.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(88, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 42;
            this.label10.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCidade.Location = new System.Drawing.Point(140, 183);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(508, 24);
            this.txtCidade.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(70, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBairro.Location = new System.Drawing.Point(140, 153);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(508, 24);
            this.txtBairro.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(76, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Bairro:";
            // 
            // mtbDataNascEleitor
            // 
            this.mtbDataNascEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtbDataNascEleitor.Location = new System.Drawing.Point(140, 365);
            this.mtbDataNascEleitor.Mask = "00/00/0000";
            this.mtbDataNascEleitor.Name = "mtbDataNascEleitor";
            this.mtbDataNascEleitor.Size = new System.Drawing.Size(80, 24);
            this.mtbDataNascEleitor.TabIndex = 36;
            this.mtbDataNascEleitor.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTelEleitor
            // 
            this.mtbTelEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mtbTelEleitor.Location = new System.Drawing.Point(140, 275);
            this.mtbTelEleitor.Mask = "(99) 0000-0000";
            this.mtbTelEleitor.Name = "mtbTelEleitor";
            this.mtbTelEleitor.Size = new System.Drawing.Size(110, 24);
            this.mtbTelEleitor.TabIndex = 30;
            this.mtbTelEleitor.Tag = "";
            // 
            // txtEnderecoEleitor
            // 
            this.txtEnderecoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEnderecoEleitor.Location = new System.Drawing.Point(140, 123);
            this.txtEnderecoEleitor.MaxLength = 50;
            this.txtEnderecoEleitor.Name = "txtEnderecoEleitor";
            this.txtEnderecoEleitor.Size = new System.Drawing.Size(508, 24);
            this.txtEnderecoEleitor.TabIndex = 28;
            // 
            // txtCpfEleitor
            // 
            this.txtCpfEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCpfEleitor.Location = new System.Drawing.Point(140, 335);
            this.txtCpfEleitor.MaxLength = 11;
            this.txtCpfEleitor.Name = "txtCpfEleitor";
            this.txtCpfEleitor.Size = new System.Drawing.Size(121, 24);
            this.txtCpfEleitor.TabIndex = 34;
            // 
            // txtRgEleitor
            // 
            this.txtRgEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtRgEleitor.Location = new System.Drawing.Point(140, 305);
            this.txtRgEleitor.MaxLength = 10;
            this.txtRgEleitor.Name = "txtRgEleitor";
            this.txtRgEleitor.Size = new System.Drawing.Size(110, 24);
            this.txtRgEleitor.TabIndex = 32;
            // 
            // txtNomeEleitor
            // 
            this.txtNomeEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeEleitor.Location = new System.Drawing.Point(140, 93);
            this.txtNomeEleitor.MaxLength = 50;
            this.txtNomeEleitor.Name = "txtNomeEleitor";
            this.txtNomeEleitor.Size = new System.Drawing.Size(508, 24);
            this.txtNomeEleitor.TabIndex = 25;
            // 
            // txtCodigoEleitor
            // 
            this.txtCodigoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCodigoEleitor.Location = new System.Drawing.Point(140, 31);
            this.txtCodigoEleitor.MaxLength = 8;
            this.txtCodigoEleitor.Name = "txtCodigoEleitor";
            this.txtCodigoEleitor.Size = new System.Drawing.Size(80, 24);
            this.txtCodigoEleitor.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(68, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(15, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data de Nasc.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(89, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(97, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(57, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(77, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(499, 61);
            this.txtConfirmaSenha.MaxLength = 8;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(149, 24);
            this.txtConfirmaSenha.TabIndex = 55;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.Location = new System.Drawing.Point(312, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 18);
            this.label15.TabIndex = 54;
            this.label15.Text = "Confirmação de Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSenha.Location = new System.Drawing.Point(140, 61);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(149, 24);
            this.txtSenha.TabIndex = 53;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.Location = new System.Drawing.Point(75, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 52;
            this.label14.Text = "Senha:";
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
            this.btnFechar.Location = new System.Drawing.Point(739, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 24);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadastroMesario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(768, 540);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbDataNascEleitor);
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
            this.Name = "frmCadastroMesario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Mesário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbSexoEleitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmailEleitor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCepEleitor;
        private System.Windows.Forms.ComboBox cmbEstadoEleitor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbDataNascEleitor;
        private System.Windows.Forms.MaskedTextBox mtbTelEleitor;
        private System.Windows.Forms.TextBox txtEnderecoEleitor;
        private System.Windows.Forms.TextBox txtCpfEleitor;
        private System.Windows.Forms.TextBox txtRgEleitor;
        private System.Windows.Forms.TextBox txtNomeEleitor;
        private System.Windows.Forms.TextBox txtCodigoEleitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFechar;
    }
}