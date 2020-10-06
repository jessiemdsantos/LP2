using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade_5
{
    public partial class Form1 : Form
    {
               public Form1()
   
        {
            InitializeComponent();
                       
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtMessagem.Clear();
            mskbxSLiquido.Clear();
            mskbxSFamilia.Clear();
            mskbxSBruto.Clear();
            mskbxNome.Clear();
            mskbxNFilhos.Clear();
            mskbxDescIRPF.Clear();
            mskbxDescINSS.Clear();
            mskbxAliIRPF.Clear();
            mskbxAliINSS.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double salarioBruto, salarioFamilia;
            int numFilhos;

            if (double.TryParse(mskbxSBruto.Text, out salarioBruto) &&
                (int.TryParse(mskbxNFilhos.Text, out numFilhos)))
            {
                // Desconto INSS

                if (salarioBruto <= 800.47)
                {
                    mskbxAliINSS.Text = "7,65%";
                    mskbxDescINSS.Text =(7.65 / 100 * salarioBruto).ToString("N2"); 
                    }
                else if (salarioBruto <= 1050)
                {
                    mskbxAliINSS.Text = "8,65%";
                    mskbxDescINSS.Text = (8.65 / 100 * salarioBruto).ToString("N2"); 
                    
                }
                else if (salarioBruto <= 1400.77)
                {
                    mskbxAliINSS.Text = "9,00%";
                    mskbxDescINSS.Text = (9 / 100 * salarioBruto).ToString("N2");

                }
                else if (salarioBruto <= 2801.56)
                {
                    mskbxAliINSS.Text = "11,00%";
                    mskbxDescINSS.Text = (11 / 100 * salarioBruto).ToString("N2");

                }
                else 
                {
                    mskbxAliINSS.Text = " Teto";
                    mskbxDescINSS.Text = "308.17";
                }


                // Descont IRPF

                if (salarioBruto <= 1257.12)
                {
                    mskbxAliIRPF.Text = "isento";
                    mskbxDescIRPF.Text = "0,00";
                }

                else if (salarioBruto <= 2512.08)
                {
                    mskbxAliIRPF.Text = "15,00%";
                    mskbxDescIRPF.Text = (15 / 100 * salarioBruto).ToString("N2");
                }

                else
                {
                    mskbxAliIRPF.Text = "27,50%";
                    mskbxDescIRPF.Text = (27.5 / 100 * salarioBruto).ToString("N2");
                }


                //Desconto Salário Família

                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33 * numFilhos;
                }
                else if (salarioBruto > 435.52 && salarioBruto <= 645.61)
                {
                    salarioFamilia = 15.74 * numFilhos;
                }
                else
                {
                    salarioFamilia = 0;
                }
                mskbxSFamilia.Text = salarioFamilia.ToString("N2");
            }

             //  Caixa de Mensagem

            if (ckbxCasado.Checked)
            {

                txtMessagem.Text = "Descontos do Senhor(a): " + mskbxNome.Text + ", que possui " + mskbxNFilhos.Text + " filhos, e é " + ckbxCasado.Text;
            }
            else
            {

                txtMessagem.Text = "Descontos do Senhor(a): " + mskbxNome.Text + ", que possui " + mskbxNFilhos.Text + " filhos, e é " + ckbxSolteiro.Text;
            }

        }
    }
}
