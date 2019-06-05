using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LifeClinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Arrastar Form sem Bordas !

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;


        // Espaço Codigo MySql / SqlServer Version 1.6.0



        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Arredondar o Form !
            ArredondaCantosdoForm();


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Fechar o Life Clinic?",
                   "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
                Close();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            CADASTROS CADASTROS = new CADASTROS();
            CADASTROS.ShowDialog();
        }

        private void BtnProntuario_Click(object sender, EventArgs e)
        {
            PRONTUARIO PRONTUARIO = new PRONTUARIO();
            PRONTUARIO.ShowDialog();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            RELATORIO RELATORIO = new RELATORIO();
            RELATORIO.ShowDialog();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            CONFIGURAÇÕES CONFIGURAÇÕES = new CONFIGURAÇÕES();
            CONFIGURAÇÕES.ShowDialog();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Finalizar sua sessão?",
                   "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();              
                Close();
              
            }
        }

        private void BtnReportarBug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encontrou algum tipo de bug? você será redirecionado para o nosso site ...");
            System.Diagnostics.Process.Start("");
        }
    }
}
