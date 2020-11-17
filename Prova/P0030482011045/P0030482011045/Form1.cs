using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482011045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            
            double[,] matrizVendas = new double[5, 4];
            double totalMes = 0;
            double totalGeral = 0;
            string Valor;

            for (int i = 0; i < matrizVendas.GetLength(0); i++)
            {
                for (int j = 0; j < matrizVendas.GetLength(1); j++)
                {
                    while (true)
                    {
                        Valor = Interaction.InputBox("Valor referente: \nMês: " + (i + 1) + 
                            "\nSemana: " + (j + 1), "Valores das vendas");

                        if (double.TryParse(Valor, out matrizVendas[i, j]))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Erro! Digite um valor valído!");
                        }
                    }
                }

            }
            
                     LstbxVendas.Items.Clear();
                for (int i = 0; i < matrizVendas.GetLength(0); i++)
                {
                for (int j = 0; j < matrizVendas.GetLength(1); j++)
                
                {
                LstbxVendas.Items.Add("Total do Mes: " + (i + 1) + " Semana " + (j + 1) + ": " + matrizVendas[i, j].ToString("C2"));
                totalGeral += matrizVendas[i, j];
                totalMes += matrizVendas[i, j]; }
                    LstbxVendas.Items.Add(">>Total do Mês " + (i + 1) + ": " + totalMes.ToString("C2"));
                    totalMes = 0;
                    LstbxVendas.Items.Add("-------------------------------");
            }
               
                LstbxVendas.Items.Add(" >>>> Total Geral: " + totalGeral.ToString("C2"));
        }

        private void LstbxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
              

        }
    }
}
