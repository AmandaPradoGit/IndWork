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
    public partial class Categorias: Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSobreNós_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SobreNos sobreNos = new SobreNos();
            sobreNos.Show();
            this.Hide();
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton26_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton29_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton28_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton27_Click(object sender, EventArgs e)
        {

        }

        private void btnIndWork_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
