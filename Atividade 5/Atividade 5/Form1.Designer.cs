namespace Atividade_5
{
    partial class Form1
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
            this.gpbxDados = new System.Windows.Forms.GroupBox();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.mskbxNFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNome = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbxResultado = new System.Windows.Forms.GroupBox();
            this.mskbxSLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliINSS = new System.Windows.Forms.MaskedTextBox();
            this.lblSLiquido = new System.Windows.Forms.Label();
            this.lblSFamilia = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblAliIRPF = new System.Windows.Forms.Label();
            this.lblAliINSS = new System.Windows.Forms.Label();
            this.txtMessagem = new System.Windows.Forms.TextBox();
            this.ckbxSolteiro = new System.Windows.Forms.CheckBox();
            this.gpbxDados.SuspendLayout();
            this.gboxSexo.SuspendLayout();
            this.gpbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDados
            // 
            this.gpbxDados.Controls.Add(this.ckbxSolteiro);
            this.gpbxDados.Controls.Add(this.ckbxCasado);
            this.gpbxDados.Controls.Add(this.mskbxNFilhos);
            this.gpbxDados.Controls.Add(this.mskbxSBruto);
            this.gpbxDados.Controls.Add(this.mskbxNome);
            this.gpbxDados.Controls.Add(this.label3);
            this.gpbxDados.Controls.Add(this.lblSalario);
            this.gpbxDados.Controls.Add(this.lblNome);
            this.gpbxDados.Controls.Add(this.gboxSexo);
            this.gpbxDados.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxDados.ForeColor = System.Drawing.Color.Navy;
            this.gpbxDados.Location = new System.Drawing.Point(12, 2);
            this.gpbxDados.Name = "gpbxDados";
            this.gpbxDados.Size = new System.Drawing.Size(816, 193);
            this.gpbxDados.TabIndex = 0;
            this.gpbxDados.TabStop = false;
            this.gpbxDados.Text = "Dados";
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Checked = true;
            this.ckbxCasado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxCasado.ForeColor = System.Drawing.Color.Black;
            this.ckbxCasado.Location = new System.Drawing.Point(659, 136);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(118, 29);
            this.ckbxCasado.TabIndex = 1;
            this.ckbxCasado.Text = "Casado(a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // mskbxNFilhos
            // 
            this.mskbxNFilhos.Location = new System.Drawing.Point(167, 137);
            this.mskbxNFilhos.Mask = "00";
            this.mskbxNFilhos.Name = "mskbxNFilhos";
            this.mskbxNFilhos.Size = new System.Drawing.Size(232, 31);
            this.mskbxNFilhos.TabIndex = 7;
            // 
            // mskbxSBruto
            // 
            this.mskbxSBruto.Location = new System.Drawing.Point(167, 87);
            this.mskbxSBruto.Mask = "99000.00";
            this.mskbxSBruto.Name = "mskbxSBruto";
            this.mskbxSBruto.Size = new System.Drawing.Size(232, 31);
            this.mskbxSBruto.TabIndex = 6;
            // 
            // mskbxNome
            // 
            this.mskbxNome.Location = new System.Drawing.Point(167, 39);
            this.mskbxNome.Name = "mskbxNome";
            this.mskbxNome.PromptChar = ' ';
            this.mskbxNome.Size = new System.Drawing.Size(433, 31);
            this.mskbxNome.TabIndex = 5;
            this.mskbxNome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de Filhos";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(7, 87);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(162, 25);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário Bruto (R$)";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(7, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(154, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome Completo";
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rbtnMasculino);
            this.gboxSexo.Controls.Add(this.rbtnFeminino);
            this.gboxSexo.ForeColor = System.Drawing.Color.Navy;
            this.gboxSexo.Location = new System.Drawing.Point(649, 16);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(158, 85);
            this.gboxSexo.TabIndex = 0;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.ForeColor = System.Drawing.Color.Black;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 50);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(121, 29);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.ForeColor = System.Drawing.Color.Black;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 23);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(113, 29);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Magenta;
            this.btnVerificar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Navy;
            this.btnVerificar.Location = new System.Drawing.Point(488, 201);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(160, 66);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Navy;
            this.btnLimpar.Location = new System.Drawing.Point(654, 201);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 66);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbxResultado
            // 
            this.gpbxResultado.BackColor = System.Drawing.Color.Plum;
            this.gpbxResultado.Controls.Add(this.mskbxSLiquido);
            this.gpbxResultado.Controls.Add(this.mskbxSFamilia);
            this.gpbxResultado.Controls.Add(this.mskbxDescIRPF);
            this.gpbxResultado.Controls.Add(this.mskbxDescINSS);
            this.gpbxResultado.Controls.Add(this.mskbxAliIRPF);
            this.gpbxResultado.Controls.Add(this.mskbxAliINSS);
            this.gpbxResultado.Controls.Add(this.lblSLiquido);
            this.gpbxResultado.Controls.Add(this.lblSFamilia);
            this.gpbxResultado.Controls.Add(this.lblDescIRPF);
            this.gpbxResultado.Controls.Add(this.lblDescINSS);
            this.gpbxResultado.Controls.Add(this.lblAliIRPF);
            this.gpbxResultado.Controls.Add(this.lblAliINSS);
            this.gpbxResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxResultado.ForeColor = System.Drawing.Color.Navy;
            this.gpbxResultado.Location = new System.Drawing.Point(12, 265);
            this.gpbxResultado.Name = "gpbxResultado";
            this.gpbxResultado.Size = new System.Drawing.Size(816, 153);
            this.gpbxResultado.TabIndex = 3;
            this.gpbxResultado.TabStop = false;
            this.gpbxResultado.Text = "Resultados";
            // 
            // mskbxSLiquido
            // 
            this.mskbxSLiquido.Enabled = false;
            this.mskbxSLiquido.Location = new System.Drawing.Point(687, 100);
            this.mskbxSLiquido.Name = "mskbxSLiquido";
            this.mskbxSLiquido.Size = new System.Drawing.Size(120, 31);
            this.mskbxSLiquido.TabIndex = 11;
            // 
            // mskbxSFamilia
            // 
            this.mskbxSFamilia.Enabled = false;
            this.mskbxSFamilia.Location = new System.Drawing.Point(687, 37);
            this.mskbxSFamilia.Name = "mskbxSFamilia";
            this.mskbxSFamilia.Size = new System.Drawing.Size(120, 31);
            this.mskbxSFamilia.TabIndex = 10;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(412, 100);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(120, 31);
            this.mskbxDescIRPF.TabIndex = 9;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(412, 37);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(120, 31);
            this.mskbxDescINSS.TabIndex = 8;
            // 
            // mskbxAliIRPF
            // 
            this.mskbxAliIRPF.Enabled = false;
            this.mskbxAliIRPF.Location = new System.Drawing.Point(133, 103);
            this.mskbxAliIRPF.Name = "mskbxAliIRPF";
            this.mskbxAliIRPF.Size = new System.Drawing.Size(139, 31);
            this.mskbxAliIRPF.TabIndex = 7;
            // 
            // mskbxAliINSS
            // 
            this.mskbxAliINSS.Enabled = false;
            this.mskbxAliINSS.Location = new System.Drawing.Point(133, 37);
            this.mskbxAliINSS.Name = "mskbxAliINSS";
            this.mskbxAliINSS.Size = new System.Drawing.Size(139, 31);
            this.mskbxAliINSS.TabIndex = 6;
            // 
            // lblSLiquido
            // 
            this.lblSLiquido.AutoSize = true;
            this.lblSLiquido.ForeColor = System.Drawing.Color.Black;
            this.lblSLiquido.Location = new System.Drawing.Point(538, 106);
            this.lblSLiquido.Name = "lblSLiquido";
            this.lblSLiquido.Size = new System.Drawing.Size(138, 25);
            this.lblSLiquido.TabIndex = 5;
            this.lblSLiquido.Text = "Sálario Líquido";
            // 
            // lblSFamilia
            // 
            this.lblSFamilia.AutoSize = true;
            this.lblSFamilia.ForeColor = System.Drawing.Color.Black;
            this.lblSFamilia.Location = new System.Drawing.Point(538, 40);
            this.lblSFamilia.Name = "lblSFamilia";
            this.lblSFamilia.Size = new System.Drawing.Size(141, 25);
            this.lblSFamilia.TabIndex = 4;
            this.lblSFamilia.Text = "Salário Família ";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.ForeColor = System.Drawing.Color.Black;
            this.lblDescIRPF.Location = new System.Drawing.Point(278, 106);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(137, 25);
            this.lblDescIRPF.TabIndex = 3;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.ForeColor = System.Drawing.Color.Black;
            this.lblDescINSS.Location = new System.Drawing.Point(278, 43);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(139, 25);
            this.lblDescINSS.TabIndex = 2;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblAliIRPF
            // 
            this.lblAliIRPF.AutoSize = true;
            this.lblAliIRPF.ForeColor = System.Drawing.Color.Black;
            this.lblAliIRPF.Location = new System.Drawing.Point(6, 106);
            this.lblAliIRPF.Name = "lblAliIRPF";
            this.lblAliIRPF.Size = new System.Drawing.Size(129, 25);
            this.lblAliIRPF.TabIndex = 1;
            this.lblAliIRPF.Text = "Alíquota IRPF";
            // 
            // lblAliINSS
            // 
            this.lblAliINSS.AutoSize = true;
            this.lblAliINSS.ForeColor = System.Drawing.Color.Black;
            this.lblAliINSS.Location = new System.Drawing.Point(6, 43);
            this.lblAliINSS.Name = "lblAliINSS";
            this.lblAliINSS.Size = new System.Drawing.Size(131, 25);
            this.lblAliINSS.TabIndex = 0;
            this.lblAliINSS.Text = "Alíquota INSS";
            // 
            // txtMessagem
            // 
            this.txtMessagem.BackColor = System.Drawing.Color.Violet;
            this.txtMessagem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessagem.Location = new System.Drawing.Point(12, 202);
            this.txtMessagem.Multiline = true;
            this.txtMessagem.Name = "txtMessagem";
            this.txtMessagem.Size = new System.Drawing.Size(460, 65);
            this.txtMessagem.TabIndex = 4;
            // 
            // ckbxSolteiro
            // 
            this.ckbxSolteiro.AutoSize = true;
            this.ckbxSolteiro.ForeColor = System.Drawing.Color.Black;
            this.ckbxSolteiro.Location = new System.Drawing.Point(659, 166);
            this.ckbxSolteiro.Name = "ckbxSolteiro";
            this.ckbxSolteiro.Size = new System.Drawing.Size(122, 29);
            this.ckbxSolteiro.TabIndex = 8;
            this.ckbxSolteiro.Text = "Solteiro(a)";
            this.ckbxSolteiro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(831, 430);
            this.Controls.Add(this.txtMessagem);
            this.Controls.Add(this.gpbxResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.gpbxDados);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbxDados.ResumeLayout(false);
            this.gpbxDados.PerformLayout();
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gpbxResultado.ResumeLayout(false);
            this.gpbxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDados;
        private System.Windows.Forms.MaskedTextBox mskbxNFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbxResultado;
        private System.Windows.Forms.MaskedTextBox mskbxSLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxSFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxAliINSS;
        private System.Windows.Forms.Label lblSLiquido;
        private System.Windows.Forms.Label lblSFamilia;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblAliIRPF;
        private System.Windows.Forms.Label lblAliINSS;
        private System.Windows.Forms.TextBox txtMessagem;
        private System.Windows.Forms.CheckBox ckbxSolteiro;
    }
}

