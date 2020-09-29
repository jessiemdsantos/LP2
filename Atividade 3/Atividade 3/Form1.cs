using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade_3
{
  
    public partial class Form1 : Form
    {
        double altura, peso, pesoIdeal;
        public Form1()
        {
            InitializeComponent();
           
            
        }


        private void btnTestar_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(maskbtnAltura.Text, out altura)) && 
                (double.TryParse(maskbtnPeso.Text, out peso)))
            {
                if (rbtnFeminino.Checked)
                {
                    pesoIdeal = Math.Round(((62.1 * altura) - 44.7),2);
                   
                }

                else
                   
                {
                    pesoIdeal = Math.Round(((72.7 * altura) - 58),2);
                    
                }

                
                MessageBox.Show(Convert.ToString(pesoIdeal));
              

                
                if (peso < pesoIdeal)
                {
                    MessageBox.Show("Coma bastante massas e doces!");
                }

                else if (peso == pesoIdeal)
                {
                    MessageBox.Show("Você está com o peso ideal!");
                }

                else if (peso > pesoIdeal)
                {
                    MessageBox.Show("Regime obrigatório já!");
                }
            }
        }

        private void maskbtnPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void rbtnFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gboxGenero_Enter(object sender, EventArgs e)
        {

        }
    }
}
