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
            this.dtgEleitor = new System.Windows.Forms.DataGridView();
            this.mtbDataNascEleitor = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelEleitor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEleitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nasc.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código:";
            // 
            // txtCodigoEleitor
            // 
            this.txtCodigoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEleitor.Location = new System.Drawing.Point(139, 31);
            this.txtCodigoEleitor.Name = "txtCodigoEleitor";
            this.txtCodigoEleitor.ReadOnly = true;
            this.txtCodigoEleitor.Size = new System.Drawing.Size(47, 24);
            this.txtCodigoEleitor.TabIndex = 7;
            // 
            // txtNomeEleitor
            // 
            this.txtNomeEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEleitor.Location = new System.Drawing.Point(139, 61);
            this.txtNomeEleitor.Name = "txtNomeEleitor";
            this.txtNomeEleitor.Size = new System.Drawing.Size(508, 24);
            this.txtNomeEleitor.TabIndex = 1;
            this.txtNomeEleitor.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // txtRgEleitor
            // 
            this.txtRgEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgEleitor.Location = new System.Drawing.Point(139, 151);
            this.txtRgEleitor.Name = "txtRgEleitor";
            this.txtRgEleitor.Size = new System.Drawing.Size(100, 24);
            this.txtRgEleitor.TabIndex = 4;
            this.txtRgEleitor.Text = "XXXXXXXXX";
            // 
            // txtCpfEleitor
            // 
            this.txtCpfEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfEleitor.Location = new System.Drawing.Point(139, 181);
            this.txtCpfEleitor.Name = "txtCpfEleitor";
            this.txtCpfEleitor.Size = new System.Drawing.Size(121, 24);
            this.txtCpfEleitor.TabIndex = 5;
            this.txtCpfEleitor.Text = "XXXXXXXXXXX";
            // 
            // txtEnderecoEleitor
            // 
            this.txtEnderecoEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEleitor.Location = new System.Drawing.Point(139, 91);
            this.txtEnderecoEleitor.Name = "txtEnderecoEleitor";
            this.txtEnderecoEleitor.Size = new System.Drawing.Size(508, 24);
            this.txtEnderecoEleitor.TabIndex = 2;
            this.txtEnderecoEleitor.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // dtgEleitor
            // 
            this.dtgEleitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEleitor.Location = new System.Drawing.Point(30, 253);
            this.dtgEleitor.Name = "dtgEleitor";
            this.dtgEleitor.Size = new System.Drawing.Size(968, 262);
            this.dtgEleitor.TabIndex = 33;
            // 
            // mtbDataNascEleitor
            // 
            this.mtbDataNascEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNascEleitor.Location = new System.Drawing.Point(139, 211);
            this.mtbDataNascEleitor.Mask = "00/00/0000";
            this.mtbDataNascEleitor.Name = "mtbDataNascEleitor";
            this.mtbDataNascEleitor.Size = new System.Drawing.Size(80, 24);
            this.mtbDataNascEleitor.TabIndex = 6;
            this.mtbDataNascEleitor.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTelEleitor
            // 
            this.mtbTelEleitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelEleitor.Location = new System.Drawing.Point(139, 121);
            this.mtbTelEleitor.Mask = "(99) 0000-0000";
            this.mtbTelEleitor.Name = "mtbTelEleitor";
            this.mtbTelEleitor.Size = new System.Drawing.Size(110, 24);
            this.mtbTelEleitor.TabIndex = 3;
            this.mtbTelEleitor.Tag = "";
            // 
            // frmCadastroEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 527);
            this.Controls.Add(this.mtbDataNascEleitor);
            this.Controls.Add(this.mtbTelEleitor);
            this.Controls.Add(this.dtgEleitor);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroEleitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Eleitor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEleitor)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgEleitor;
        private System.Windows.Forms.MaskedTextBox mtbDataNascEleitor;
        private System.Windows.Forms.MaskedTextBox mtbTelEleitor;
    }
}