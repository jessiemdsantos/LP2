namespace PMetodos
{
    partial class frmExercicio4
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
            this.richtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richtxtTexto
            // 
            this.richtxtTexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richtxtTexto.Location = new System.Drawing.Point(168, 31);
            this.richtxtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.richtxtTexto.Name = "richtxtTexto";
            this.richtxtTexto.Size = new System.Drawing.Size(443, 119);
            this.richtxtTexto.TabIndex = 0;
            this.richtxtTexto.Text = "";
            // 
            // btnNumero
            // 
            this.btnNumero.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNumero.Location = new System.Drawing.Point(95, 194);
            this.btnNumero.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(161, 78);
            this.btnNumero.TabIndex = 1;
            this.btnNumero.Text = "Contar Números";
            this.btnNumero.UseVisualStyleBackColor = false;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBranco.Location = new System.Drawing.Point(334, 194);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(168, 78);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Posição Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLetras.Location = new System.Drawing.Point(557, 194);
            this.btnLetras.Margin = new System.Windows.Forms.Padding(4);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(160, 78);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Contar Letra";
            this.btnLetras.UseVisualStyleBackColor = false;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(802, 376);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.richtxtTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtTexto;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetras;
    }
}