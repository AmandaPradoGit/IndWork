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
    public partial class CardPesquisaUsuario: UserControl
    {
        private Contratante contratante;
        public event EventHandler<string> OnSelecionado;

        public CardPesquisaUsuario(Contratante contratante)
        {
            InitializeComponent();
            this.contratante = contratante;
            lblNome.Text = contratante.Nome;
        }

        private void CardPesquisaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CardPesquisaUsuario_Click(object sender, EventArgs e)
        {
            OnSelecionado?.Invoke(this, lblNome.Text);
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
