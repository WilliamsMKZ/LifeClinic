using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LifeClinic
{
    public partial class CONFIGURAÇÕES : Form
    {
        public CONFIGURAÇÕES()
        {
            InitializeComponent();
        }

        // Arrastar Form sem Bordas !

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;


        private void CONFIGURAÇÕES_Load(object sender, EventArgs e)
        {

        }

        private void CONFIGURAÇÕES_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void CONFIGURAÇÕES_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void CONFIGURAÇÕES_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verificando Uptade . . . .  Sua versão 1.0.0");
            
        }

        private void BtnReportarBugs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encontrou algum tipo de bug?  Você será redirecionado para o nosso site ...");
            System.Diagnostics.Process.Start("https://life-clinic.webnode.com");
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido pelo Grupo CODEZILA™ ");
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verificando ... Licença Gratuita Versão 1.0.0");
        }
    }
}
