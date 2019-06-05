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
    public partial class CADASTROS : Form
    {
        public CADASTROS()
        {
            InitializeComponent();
        }

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            CAD_PACIENTE CAD_PACIENTE = new CAD_PACIENTE();
            CAD_PACIENTE.ShowDialog();
        }

        private void BtnProfissionais_Click(object sender, EventArgs e)
        {
            CAD_PROFISSIONAIS CAD_PROFISSIONAIS = new CAD_PROFISSIONAIS();
            CAD_PROFISSIONAIS.ShowDialog();
        }

        private void BtnServiços_Click(object sender, EventArgs e)
        {
            CAD_SERVIÇOS CAD_SERVIÇOS = new CAD_SERVIÇOS();
            CAD_SERVIÇOS.ShowDialog();
        }

        private void BtnConvenio_Click(object sender, EventArgs e)
        {
            CAD_CONVENIO CAD_CONVENIO = new CAD_CONVENIO();
            CAD_CONVENIO.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
