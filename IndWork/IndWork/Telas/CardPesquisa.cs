using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndWork.dados;

namespace IndWork.Telas
{
    public partial class CardPesquisa: UserControl
    {
        private Prestador prestador;
        public CardPesquisa(Prestador prestador)
        {
            InitializeComponent();
            this.prestador = prestador;
            lblNome.Text = prestador.Nome;
        }

        private void CardPesquisa_Load(object sender, EventArgs e)
        {
        }

       
        private void lblNome_Click(object sender, EventArgs e)
        {
            if (prestador != null)
            {
                PerfilPrestador telaPerfil = new PerfilPrestador(prestador);
                telaPerfil.Show();
                Form pesquisa = this.FindForm();
                if (pesquisa != null)
                {
                    pesquisa.Hide();
                }
            }
            else
            {
                MessageBox.Show("Prestador não disponível.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
