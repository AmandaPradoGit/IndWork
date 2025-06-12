using IndWork.banco;
using IndWork.dados;
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
    public partial class Pesquisa: Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        public Pesquisa(string textoBusca)
        {
            InitializeComponent();
            txtPesquisar.Text = textoBusca;
            btnPesquisar.PerformClick();

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnIndWork_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }


        private void AtualizarCards(string nomePesquisa)
        {
            flowLayoutPanel1.Controls.Clear();

            PrestadorDAO dao = new PrestadorDAO();
            var lista = dao.PesquisarPrestador(nomePesquisa);

            foreach (var prestador in lista)
            {
                CardPesquisa cardPesquisa = new CardPesquisa(prestador);
                flowLayoutPanel1.Controls.Add(cardPesquisa);
                cardPesquisa.BringToFront();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeServico = txtPesquisar.Text.Trim();

            // Verifica se o serviço existe no EnumServicos
            bool servicoExiste = Enum.GetNames(typeof(EnumServicos))
                .Any(s => s.Equals(nomeServico, StringComparison.OrdinalIgnoreCase));

            if (!servicoExiste)
            {
                MessageBox.Show("Serviço não Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flowLayoutPanel1.Controls.Clear();
                return;
            }

            PrestadorDAO dao = new PrestadorDAO();
            var lista = dao.PesquisarPorServico(nomeServico);

            flowLayoutPanel1.Controls.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum prestador encontrado para esse serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var prestador in lista)
            {
                CardPesquisa cardPesquisa = new CardPesquisa(prestador);
                flowLayoutPanel1.Controls.Add(cardPesquisa);
                cardPesquisa.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
