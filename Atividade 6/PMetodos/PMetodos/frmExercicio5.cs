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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
           
            Random sorteio = new Random();
            int num1 = 0;
            int num2 = 0;
            if (int.TryParse(txtNum1.Text, out num1) && 
                (int.TryParse(txtNum2.Text, out num2)))

                     
            MessageBox.Show(" O número sorteado é: " + sorteio.Next(num1,num2));

            

               
            }
        }
    }

