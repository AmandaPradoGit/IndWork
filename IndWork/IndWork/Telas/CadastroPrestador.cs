using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndWork.Telas
{
    public partial class CadastroPrestador: Form
    {
        public CadastroPrestador()
        {
            InitializeComponent();
            panel1.Resize += panel1_Resize;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1_Resize(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {

            int espaco = 100;
            int margemLateral = 70;

            int larguraDisponivel = panel1.ClientSize.Width - (2 * margemLateral) - espaco;
            int larguraCadaElemento = larguraDisponivel / 2;


            panel4.Width = larguraCadaElemento;
            panel4.Left = margemLateral;
            panel4.Top = 100;

            roundedPanel9.Width = larguraCadaElemento;
            roundedPanel9.Left = panel4.Right + espaco;
            roundedPanel9.Top = 100;

            btnCadastrar.Left = roundedPanel9.Left ;
            btnCadastrar.Top = roundedPanel9.Bottom + 20; 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIndWork_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel9_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
            this.Hide();
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SobreNos sobreNos = new SobreNos();
            sobreNos.Show();
            this.Hide();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
