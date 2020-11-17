namespace P0030482011045
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
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LstbxVendas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificar.Location = new System.Drawing.Point(52, 82);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(148, 82);
            this.BtnVerificar.TabIndex = 0;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LstbxVendas
            // 
            this.LstbxVendas.FormattingEnabled = true;
            this.LstbxVendas.ItemHeight = 16;
            this.LstbxVendas.Location = new System.Drawing.Point(316, 15);
            this.LstbxVendas.Name = "LstbxVendas";
            this.LstbxVendas.Size = new System.Drawing.Size(262, 244);
            this.LstbxVendas.TabIndex = 1;
            this.LstbxVendas.SelectedIndexChanged += new System.EventHandler(this.LstbxVendas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 277);
            this.Controls.Add(this.LstbxVendas);
            this.Controls.Add(this.BtnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.ListBox LstbxVendas;
    }
}

