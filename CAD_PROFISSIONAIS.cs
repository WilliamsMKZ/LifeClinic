using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LifeClinic
{
    public partial class CAD_PROFISSIONAIS : Form
    {
        public CAD_PROFISSIONAIS()
        {
            InitializeComponent();
        }

        private void CAD_PROFISSIONAIS_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Cadastro será direcionado para o OleDb e para o SqlClient
            MessageBox.Show("Cadastro Realizado com Sucesso");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Cancelar?",
                    "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {


                Close();
            }
        }
    }
}
