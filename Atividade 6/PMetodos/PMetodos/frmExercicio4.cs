using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (var i = 0; i < richtxtTexto.Text.Length; i++)
            {
                if (char.IsNumber(richtxtTexto.Text[i]))
                    cont += 1;
            }
            MessageBox.Show("Quantidade de números: " + cont);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int posicao = cont - 1;
            string espaco = richtxtTexto.Text;
            if (espaco== "")
            {
                MessageBox.Show("Está todo em branco!");
            }
            else
            {
                while (posicao <= 0)
                {
                    if (! char.IsWhiteSpace(richtxtTexto.Text[cont]))
                    {
                        cont += 1;
                    }
                    else
                    {
                        posicao = cont;
                }
            }
            MessageBox.Show(" O primeiro espaço em branco está na posição de número: " + posicao);
        }

        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
           int cont = 0;
            foreach (char letra in richtxtTexto.Text)
            {
            if (char.IsLetter(letra))
            
                cont += 1;
            }
            MessageBox.Show("Quantidade de Letras: " + cont);
            
        }
    }
}
