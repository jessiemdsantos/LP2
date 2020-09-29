namespace Atividade_3
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
            this.maskbtnPeso = new System.Windows.Forms.MaskedTextBox();
            this.maskbtnAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.gboxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskbtnPeso
            // 
            this.maskbtnPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskbtnPeso.Location = new System.Drawing.Point(145, 39);
            this.maskbtnPeso.Mask = "000.00";
            this.maskbtnPeso.Name = "maskbtnPeso";
            this.maskbtnPeso.Size = new System.Drawing.Size(142, 30);
            this.maskbtnPeso.TabIndex = 0;
            this.maskbtnPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskbtnPeso_MaskInputRejected);
            // 
            // maskbtnAltura
            // 
            this.maskbtnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskbtnAltura.Location = new System.Drawing.Point(145, 91);
            this.maskbtnAltura.Mask = "0.00";
            this.maskbtnAltura.Name = "maskbtnAltura";
            this.maskbtnAltura.Size = new System.Drawing.Size(142, 30);
            this.maskbtnAltura.TabIndex = 1;
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoAtual.Location = new System.Drawing.Point(12, 34);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(114, 29);
            this.lblPesoAtual.TabIndex = 2;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(56, 91);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 29);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // btnTestar
            // 
            this.btnTestar.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(212, 196);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(146, 51);
            this.btnTestar.TabIndex = 6;
            this.btnTestar.Text = "Calcular";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rbtnMasculino);
            this.gboxGenero.Controls.Add(this.rbtnFeminino);
            this.gboxGenero.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGenero.Location = new System.Drawing.Point(395, 34);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Size = new System.Drawing.Size(154, 157);
            this.gboxGenero.TabIndex = 7;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Gênero";
            this.gboxGenero.Enter += new System.EventHandler(this.gboxGenero_Enter);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 101);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(103, 26);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(7, 52);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(95, 26);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            this.rbtnFeminino.CheckedChanged += new System.EventHandler(this.rbtnFeminino_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 291);
            this.Controls.Add(this.gboxGenero);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.maskbtnAltura);
            this.Controls.Add(this.maskbtnPeso);
            this.Name = "Form1";
            this.Text = "Cálculo do Peso Ideal";
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskbtnPeso;
        private System.Windows.Forms.MaskedTextBox maskbtnAltura;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
    }
}

