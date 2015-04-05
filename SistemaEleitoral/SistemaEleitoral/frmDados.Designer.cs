namespace SistemaEleitoral
{
    partial class frmDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.eleitor_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_IDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_tel_fixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_tel_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_voto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleitor_alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eleitor_excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 509);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Votação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eleitores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleitor_mat,
            this.eleitor_nome,
            this.eleitor_CPF,
            this.eleitor_IDT,
            this.eleitor_End,
            this.eleitor_bairro,
            this.eleitor_cidade,
            this.eleitor_CEP,
            this.eleitor_UF,
            this.eleitor_email,
            this.eleitor_nascimento,
            this.eleitor_tel_fixo,
            this.eleitor_tel_cel,
            this.eleitor_sexo,
            this.eleitor_voto,
            this.eleitor_alterar,
            this.eleitor_excluir});
            this.dataGridView1.Location = new System.Drawing.Point(10, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Candidatos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(967, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cargos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(967, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mesários";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(967, 483);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Turmas";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // eleitor_mat
            // 
            this.eleitor_mat.HeaderText = "Matrícula";
            this.eleitor_mat.Name = "eleitor_mat";
            this.eleitor_mat.ReadOnly = true;
            this.eleitor_mat.Width = 80;
            // 
            // eleitor_nome
            // 
            this.eleitor_nome.HeaderText = "Nome";
            this.eleitor_nome.Name = "eleitor_nome";
            this.eleitor_nome.ReadOnly = true;
            this.eleitor_nome.Width = 250;
            // 
            // eleitor_CPF
            // 
            this.eleitor_CPF.HeaderText = "CPF";
            this.eleitor_CPF.Name = "eleitor_CPF";
            this.eleitor_CPF.ReadOnly = true;
            // 
            // eleitor_IDT
            // 
            this.eleitor_IDT.HeaderText = "IDT";
            this.eleitor_IDT.Name = "eleitor_IDT";
            this.eleitor_IDT.ReadOnly = true;
            // 
            // eleitor_End
            // 
            this.eleitor_End.HeaderText = "Endereço";
            this.eleitor_End.Name = "eleitor_End";
            this.eleitor_End.ReadOnly = true;
            this.eleitor_End.Width = 300;
            // 
            // eleitor_bairro
            // 
            this.eleitor_bairro.HeaderText = "Bairro";
            this.eleitor_bairro.Name = "eleitor_bairro";
            this.eleitor_bairro.ReadOnly = true;
            this.eleitor_bairro.Width = 200;
            // 
            // eleitor_cidade
            // 
            this.eleitor_cidade.HeaderText = "Cidade";
            this.eleitor_cidade.Name = "eleitor_cidade";
            this.eleitor_cidade.ReadOnly = true;
            this.eleitor_cidade.Width = 200;
            // 
            // eleitor_CEP
            // 
            this.eleitor_CEP.HeaderText = "CEP";
            this.eleitor_CEP.Name = "eleitor_CEP";
            this.eleitor_CEP.ReadOnly = true;
            this.eleitor_CEP.Width = 80;
            // 
            // eleitor_UF
            // 
            this.eleitor_UF.HeaderText = "UF";
            this.eleitor_UF.Name = "eleitor_UF";
            this.eleitor_UF.ReadOnly = true;
            this.eleitor_UF.Width = 40;
            // 
            // eleitor_email
            // 
            this.eleitor_email.HeaderText = "e-mail";
            this.eleitor_email.Name = "eleitor_email";
            this.eleitor_email.ReadOnly = true;
            this.eleitor_email.Width = 200;
            // 
            // eleitor_nascimento
            // 
            this.eleitor_nascimento.HeaderText = "Data Nasc";
            this.eleitor_nascimento.Name = "eleitor_nascimento";
            this.eleitor_nascimento.ReadOnly = true;
            // 
            // eleitor_tel_fixo
            // 
            this.eleitor_tel_fixo.HeaderText = "Tel Fixo";
            this.eleitor_tel_fixo.Name = "eleitor_tel_fixo";
            this.eleitor_tel_fixo.ReadOnly = true;
            // 
            // eleitor_tel_cel
            // 
            this.eleitor_tel_cel.HeaderText = "Tel Cel";
            this.eleitor_tel_cel.Name = "eleitor_tel_cel";
            this.eleitor_tel_cel.ReadOnly = true;
            // 
            // eleitor_sexo
            // 
            this.eleitor_sexo.HeaderText = "Sexo";
            this.eleitor_sexo.Name = "eleitor_sexo";
            this.eleitor_sexo.ReadOnly = true;
            this.eleitor_sexo.Width = 60;
            // 
            // eleitor_voto
            // 
            this.eleitor_voto.HeaderText = "Voto";
            this.eleitor_voto.Name = "eleitor_voto";
            this.eleitor_voto.ReadOnly = true;
            this.eleitor_voto.Width = 50;
            // 
            // eleitor_alterar
            // 
            this.eleitor_alterar.HeaderText = "Alt";
            this.eleitor_alterar.Name = "eleitor_alterar";
            this.eleitor_alterar.Text = "Alt";
            this.eleitor_alterar.ToolTipText = "Alt";
            this.eleitor_alterar.UseColumnTextForButtonValue = true;
            this.eleitor_alterar.Width = 30;
            // 
            // eleitor_excluir
            // 
            this.eleitor_excluir.HeaderText = "Del";
            this.eleitor_excluir.Name = "eleitor_excluir";
            this.eleitor_excluir.Text = "Del";
            this.eleitor_excluir.ToolTipText = "Del";
            this.eleitor_excluir.UseColumnTextForButtonValue = true;
            this.eleitor_excluir.Width = 30;
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 514);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_IDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_tel_fixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_tel_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleitor_voto;
        private System.Windows.Forms.DataGridViewButtonColumn eleitor_alterar;
        private System.Windows.Forms.DataGridViewButtonColumn eleitor_excluir;
    }
}