using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class Form1 : Form

    {
        double valor1, valor2;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out valor1) &&
            double.TryParse(txtNum2.Text, out valor2))
            {

            result = valor1 + valor2;

            txtResultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido!");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out valor1) &&
            double.TryParse(txtNum2.Text, out valor2))
            {

                result = valor1 - valor2;

                txtResultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido!");
            }
        }

        private void bntMulti_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out valor1) &&
               double.TryParse(txtNum2.Text, out valor2))
            {

                result = valor1 * valor2;

                txtResultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Valor Inválido!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out valor1) &&
             double.TryParse(txtNum2.Text, out valor2))
            {
                if (valor2 == 0)
                  MessageBox.Show("Denominador não pode ser zero!");
                else
                {
                    result = valor1 / valor2;

                    txtResultado.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Valor Inválido!");
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
