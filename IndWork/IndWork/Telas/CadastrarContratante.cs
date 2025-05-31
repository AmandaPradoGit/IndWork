using IndWork.Codigo.Dominio.Entidades;
using IndWork.Codigo.Infraestrutura.Repositorios;
using IndWork.Codigo.Servicos;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace IndWork.Telas
{
    public partial class CadastrarContratante : Form
    {
        private PessoaServico _servico;

        public CadastrarContratante()
        {
            InitializeComponent();
            _servico = new PessoaServico(new PessoaRepositorio());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa
                {
                    Nome = txtNome.Text,
                    DataNascimento = dateNascimento.Value,
                    Cpf = txtCpf.Text,
                    Telefone = txtTelefone.Text,
                    Email = txtEmail.Text,
                    Endereco = txtRua.Text,
                    Numero = txtNumero.Text,
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text
                };

                _servico.Inserir(pessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o Contratante. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
