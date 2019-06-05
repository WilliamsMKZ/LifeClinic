namespace LifeClinic
{
    partial class CADASTROS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CADASTROS));
            this.BtnPaciente = new System.Windows.Forms.PictureBox();
            this.BtnProfissionais = new System.Windows.Forms.PictureBox();
            this.BtnServiços = new System.Windows.Forms.PictureBox();
            this.BtnConvenio = new System.Windows.Forms.PictureBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnServiços)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConvenio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPaciente
            // 
            this.BtnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.BtnPaciente.Location = new System.Drawing.Point(119, 107);
            this.BtnPaciente.Name = "BtnPaciente";
            this.BtnPaciente.Size = new System.Drawing.Size(207, 50);
            this.BtnPaciente.TabIndex = 6;
            this.BtnPaciente.TabStop = false;
            this.BtnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // BtnProfissionais
            // 
            this.BtnProfissionais.BackColor = System.Drawing.Color.Transparent;
            this.BtnProfissionais.Location = new System.Drawing.Point(365, 107);
            this.BtnProfissionais.Name = "BtnProfissionais";
            this.BtnProfissionais.Size = new System.Drawing.Size(203, 50);
            this.BtnProfissionais.TabIndex = 7;
            this.BtnProfissionais.TabStop = false;
            this.BtnProfissionais.Click += new System.EventHandler(this.BtnProfissionais_Click);
            // 
            // BtnServiços
            // 
            this.BtnServiços.BackColor = System.Drawing.Color.Transparent;
            this.BtnServiços.Location = new System.Drawing.Point(96, 213);
            this.BtnServiços.Name = "BtnServiços";
            this.BtnServiços.Size = new System.Drawing.Size(207, 50);
            this.BtnServiços.TabIndex = 8;
            this.BtnServiços.TabStop = false;
            this.BtnServiços.Click += new System.EventHandler(this.BtnServiços_Click);
            // 
            // BtnConvenio
            // 
            this.BtnConvenio.BackColor = System.Drawing.Color.Transparent;
            this.BtnConvenio.Location = new System.Drawing.Point(334, 213);
            this.BtnConvenio.Name = "BtnConvenio";
            this.BtnConvenio.Size = new System.Drawing.Size(204, 50);
            this.BtnConvenio.TabIndex = 9;
            this.BtnConvenio.TabStop = false;
            this.BtnConvenio.Click += new System.EventHandler(this.BtnConvenio_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(558, 318);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 33);
            this.BtnVoltar.TabIndex = 10;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CADASTROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 363);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConvenio);
            this.Controls.Add(this.BtnServiços);
            this.Controls.Add(this.BtnProfissionais);
            this.Controls.Add(this.BtnPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CADASTROS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            ((System.ComponentModel.ISupportInitialize)(this.BtnPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnServiços)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConvenio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnPaciente;
        private System.Windows.Forms.PictureBox BtnProfissionais;
        private System.Windows.Forms.PictureBox BtnServiços;
        private System.Windows.Forms.PictureBox BtnConvenio;
        private System.Windows.Forms.Button BtnVoltar;
    }
}