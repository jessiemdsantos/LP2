using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Form1 : Form
    {
        double A, B, C;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text == String.Empty || txtLadoB.Text == String.Empty || txtLadoC.Text == String.Empty)
            {
                MessageBox.Show("Espaço não pode ficar em branco!!");
            }
            else
            {
                if ((double.TryParse(txtLadoA.Text, out A)) &&
                    (double.TryParse(txtLadoB.Text, out B)) &&
                    (double.TryParse(txtLadoC.Text, out C)))
                {
                    if ((Math.Abs(B - C) < A && A < (B + C)) &&
                        (Math.Abs(A - C) < B && B < (A + C)) &&
                        (Math.Abs(A - B) < C && C < (A + B)))
                    {
                        if (A == B && B == C)
                        {
                            MessageBox.Show("Triângulo Equilátero!");
                        }

                        else if (A != B & B != C && C != A)
                        {
                            MessageBox.Show("Triângulo Escaleno!");
                        }

                        else
                        {
                            MessageBox.Show("Triângulo Isósceles!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Valores Inválidos!");
                    }
                }
            }
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
