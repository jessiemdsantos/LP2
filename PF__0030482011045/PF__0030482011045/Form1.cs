using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PF__0030482011045
{
    public partial class frmPrincipal : Form

    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source = JESSMI\\SQLEXPRESS; Initial Catalog = LP2; Integrated Security = True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados!" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outro tipo de erro" + ex.Message);
            }
        }

        private void cadastroCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];

            if (fc != null)
                fc.Close();

            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmSobre frmS = new frmSobre();
           
           
           
        }
    }
}


