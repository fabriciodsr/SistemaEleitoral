namespace SistemaEleitoral
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
            this.txtEnderecoMesario = new System.Windows.Forms.TextBox();
            this.mtbDataNascMesario = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfMesario = new System.Windows.Forms.TextBox();
            this.txtRgMesario = new System.Windows.Forms.TextBox();
            this.txtNomeMesario = new System.Windows.Forms.TextBox();
            this.txtCodigoMesario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMesario = new System.Windows.Forms.DataGridView();
            this.mtbTelMesario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMesario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnderecoMesario
            // 
            this.txtEnderecoMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoMesario.Location = new System.Drawing.Point(136, 90);
            this.txtEnderecoMesario.Name = "txtEnderecoMesario";
            this.txtEnderecoMesario.Size = new System.Drawing.Size(508, 24);
            this.txtEnderecoMesario.TabIndex = 2;
            this.txtEnderecoMesario.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // mtbDataNascMesario
            // 
            this.mtbDataNascMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNascMesario.Location = new System.Drawing.Point(136, 210);
            this.mtbDataNascMesario.Mask = "00/00/0000";
            this.mtbDataNascMesario.Name = "mtbDataNascMesario";
            this.mtbDataNascMesario.Size = new System.Drawing.Size(80, 24);
            this.mtbDataNascMesario.TabIndex = 6;
            this.mtbDataNascMesario.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpfMesario
            // 
            this.txtCpfMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfMesario.Location = new System.Drawing.Point(136, 180);
            this.txtCpfMesario.Name = "txtCpfMesario";
            this.txtCpfMesario.Size = new System.Drawing.Size(121, 24);
            this.txtCpfMesario.TabIndex = 5;
            this.txtCpfMesario.Text = "XXXXXXXXXXX";
            // 
            // txtRgMesario
            // 
            this.txtRgMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgMesario.Location = new System.Drawing.Point(136, 150);
            this.txtRgMesario.Name = "txtRgMesario";
            this.txtRgMesario.Size = new System.Drawing.Size(100, 24);
            this.txtRgMesario.TabIndex = 4;
            this.txtRgMesario.Text = "XXXXXXXXX";
            // 
            // txtNomeMesario
            // 
            this.txtNomeMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMesario.Location = new System.Drawing.Point(136, 60);
            this.txtNomeMesario.Name = "txtNomeMesario";
            this.txtNomeMesario.Size = new System.Drawing.Size(508, 24);
            this.txtNomeMesario.TabIndex = 1;
            this.txtNomeMesario.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // txtCodigoMesario
            // 
            this.txtCodigoMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMesario.Location = new System.Drawing.Point(136, 30);
            this.txtCodigoMesario.Name = "txtCodigoMesario";
            this.txtCodigoMesario.ReadOnly = true;
            this.txtCodigoMesario.Size = new System.Drawing.Size(47, 24);
            this.txtCodigoMesario.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data de Nasc.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome:";
            // 
            // dtgMesario
            // 
            this.dtgMesario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMesario.Location = new System.Drawing.Point(27, 253);
            this.dtgMesario.Name = "dtgMesario";
            this.dtgMesario.Size = new System.Drawing.Size(968, 262);
            this.dtgMesario.TabIndex = 32;
            // 
            // mtbTelMesario
            // 
            this.mtbTelMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelMesario.Location = new System.Drawing.Point(136, 120);
            this.mtbTelMesario.Mask = "(99) 0000-0000";
            this.mtbTelMesario.Name = "mtbTelMesario";
            this.mtbTelMesario.Size = new System.Drawing.Size(110, 24);
            this.mtbTelMesario.TabIndex = 3;
            this.mtbTelMesario.Tag = "";
            // 
            // frmCadastroMesario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 527);
            this.Controls.Add(this.dtgMesario);
            this.Controls.Add(this.txtEnderecoMesario);
            this.Controls.Add(this.mtbDataNascMesario);
            this.Controls.Add(this.mtbTelMesario);
            this.Controls.Add(this.txtCpfMesario);
            this.Controls.Add(this.txtRgMesario);
            this.Controls.Add(this.txtNomeMesario);
            this.Controls.Add(this.txtCodigoMesario);
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
            this.Name = "frmCadastroMesario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Mesário";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMesario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnderecoMesario;
        private System.Windows.Forms.MaskedTextBox mtbDataNascMesario;
        private System.Windows.Forms.TextBox txtCpfMesario;
        private System.Windows.Forms.TextBox txtRgMesario;
        private System.Windows.Forms.TextBox txtNomeMesario;
        private System.Windows.Forms.TextBox txtCodigoMesario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMesario;
        private System.Windows.Forms.MaskedTextBox mtbTelMesario;
    }
}