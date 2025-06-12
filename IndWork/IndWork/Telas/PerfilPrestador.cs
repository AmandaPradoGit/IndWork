using IndWork.dados;
using IndWork.banco;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace IndWork.Telas
{
    public partial class PerfilPrestador : Form
    {
        private Prestador prestador;

        public PerfilPrestador(Prestador prestadorSelecionado)
        {
            InitializeComponent();

            if (prestadorSelecionado == null)
            {
                MessageBox.Show("Erro ao carregar informações do prestador.");
                return;
            }

            prestador = prestadorSelecionado;
            PreencherDados();
        }

        private void PreencherDados()
        {
            lblNome.Text = prestador.Nome;
            lblEmail.Text = prestador.Email;
            lblTelefone.Text = prestador.Telefone;
            lblServico.Text = FormatarNomeServico(prestador.Servico);
            lblRua.Text = prestador.Rua;
            lblBairro.Text = prestador.Bairro;
            lblNum.Text = prestador.Numero.ToString();
            lblCep.Text = prestador.CEP;

            double media = new AvaliacaoDAO().ObterMediaAvaliacao(prestador.Id) ?? 0.0;
            Console.WriteLine($"Média calculada: {media}"); // depuração
            lblNota.Text = media.ToString("0.0") + " / 5";
        }

        public void AtualizarNota()
        {
            double novaMedia = new AvaliacaoDAO().ObterMediaAvaliacao(prestador.Id) ?? 0.0;
            lblNota.Text = novaMedia.ToString("0.0") + " / 5"; 
        }

        private string FormatarNomeServico(EnumServicos servico)
        {
            return Regex.Replace(servico.ToString(), "(?<!^)([A-Z])", " $1");
        }
    


        private void PerfilPrestador_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Avaliacao telaAvaliacao = new Avaliacao(prestador);
            telaAvaliacao.ShowDialog();
        }


        private void btncadPrestador_Click(object sender, EventArgs e)
        {
            Contratacao contratacao = new Contratacao(prestador.Email);
            contratacao.Show();
        }

        private void lblNota_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Avaliacao telaAvaliacao = new Avaliacao(prestador);
            telaAvaliacao.ShowDialog();
        }
    }
}
