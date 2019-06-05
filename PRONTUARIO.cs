using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeClinic
{
    public partial class PRONTUARIO : Form
    {
        public PRONTUARIO()
        {
            InitializeComponent();
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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde uns instantes ...");
        }

        private void PRONTUARIO_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
