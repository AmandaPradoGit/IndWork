using System;
using Microsoft.VisualBasic;
using IndWork.banco;
using IndWork.dados;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;


namespace IndWork.Telas
{
    public partial class GerenciarContratantes : Form
    {
        private int usuarioId = 0; 


        public GerenciarContratantes(string textoBusca)
        {
            InitializeComponent();
            txtPesquisar.Text = textoBusca;
            btnPesquisar.PerformClick();
            roundedPanel9.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeContratante = txtPesquisar.Text.Trim();

            CadastroDAO dao = new CadastroDAO();
            var lista = dao.PesquisarContratante(nomeContratante);

            roundedPanel1.Controls.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum contratante encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var contratante in lista)
            {
                CardPesquisaUsuario cardPesquisa = new CardPesquisaUsuario(contratante);
                cardPesquisa.OnSelecionado += CardPesquisaUsuario_OnSelecionado;
                roundedPanel1.Controls.Add(cardPesquisa);
                cardPesquisa.BringToFront();
            }
        }
        private void CardPesquisaUsuario_OnSelecionado(object sender, string nome)
        {
            CadastroDAO dao = new CadastroDAO();
            var contratante = dao.PesquisarContratante(nome).FirstOrDefault();
            int usuarioId = contratante?.Id ?? 0;
            Cadastro cadastro = dao.BuscarCadastro(usuarioId);
            Console.WriteLine($"ID do usuário armazenado: {usuarioId}");

            if (contratante != null)
            {
                lblNome.Text = contratante.Nome;
                lblTelefone.Text = contratante.Telefone;
                lblEmail.Text = contratante.Email;
                lblRua.Text = contratante.Rua;
                lblBairro.Text = contratante.Bairro;
                lblNum.Text = contratante.Numero.ToString();
                lblCep.Text = contratante.CEP;

                roundedPanel9.Visible = true;
            }
            else
            {
                MessageBox.Show("Contratante não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roundedPanel9.Visible = true;
            }
        }


        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarTelefone_Click(object sender, EventArgs e)
        {
           
            
        }

        private void AtualizarCadastro(int usuarioId, Dictionary<string, object> campos)
        {

        }

        private void btnAtualizarEmail_Click(object sender, EventArgs e)
        {

            
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GerenciarContratantes_Load(object sender, EventArgs e)
        {
            
        }

        private void btncadPrestador_Click(object sender, EventArgs e)
        {

            var campos = new Dictionary<string, object>
            {
                { "telefone", lblTelefone.Text.Trim() },
                { "email", lblEmail.Text.Trim() },
                { "bairro", lblBairro.Text.Trim() },
                { "rua", lblRua.Text.Trim() },
                { "numero", lblNum.Text.Trim() },
                { "cep", lblCep.Text.Trim() }
            };

            CadastroDAO dao = new CadastroDAO();

        }
    }
}