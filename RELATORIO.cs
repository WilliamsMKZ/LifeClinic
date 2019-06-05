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
    public partial class RELATORIO : Form
    {
        public RELATORIO()
        {
            InitializeComponent();
        }

        private void RELATORIO_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde uns instantes ...");
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

        private void BtnImprimir2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde uns instantes ...");
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
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

        private void BtnImprimir3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde uns instantes ...");
        }

        private void BtnCancelar3_Click(object sender, EventArgs e)
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
