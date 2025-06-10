
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using IndWork.banco;
using IndWork.dados;

namespace IndWork.Telas
{
    public partial class CadastrarContratante : Form
    {

        public CadastrarContratante()
        {
            InitializeComponent();
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
            txtNum.Refresh();

            string numeroTexto = txtNum.Text.Trim();

            int numero;
            if (!int.TryParse(txtNum.Text, out numero))
            {
                return;
            }
            IndWork.dados.Cadastro novoCadastro = new IndWork.dados.Cadastro(
               0,
               txtNome.Text,
               txtEmail.Text,
               txtCpf.Text,
               txtTelefone.Text,
               txtRua.Text,
               txtBairro.Text,
               txtCep.Text,
               numero,
               dateNascimento.Value
           );
            
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtCep.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cpfSemMascara = txtCpf.Text.Replace(".", "").Replace("-", "");
            if (cpfSemMascara.Length != 11 || !cpfSemMascara.All(char.IsDigit))
            {
                MessageBox.Show("CPF inválido! Preencha corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string telefoneSemMascara = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (telefoneSemMascara.Length < 10 || telefoneSemMascara.Length > 11 || !telefoneSemMascara.All(char.IsDigit))
            {
                MessageBox.Show("Telefone inválido! Digite corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numero <= 0)
            {
                MessageBox.Show("Número da residência inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CadastroDAO dao = new CadastroDAO();
            dao.AdicionarCadastro(novoCadastro);

            MessageBox.Show("Prestador cadastrado com sucesso!");

            Principal p = new Principal();
            p.Show();
            this.Hide();

            MessageBox.Show("Prestador cadastrado com sucesso!");

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

            if (texto.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (texto.Length == 3 || texto.Length == 6) txtCpf.Text += ".";
            if (texto.Length == 9) txtCpf.Text += "-";

            if ((texto.Length == 3 || texto.Length == 6 || texto.Length == 9) && e.KeyChar == (char)Keys.Back)
            {
                txtCpf.Text = txtCpf.Text.Substring(0, txtCpf.Text.Length - 1);
                txtCpf.SelectionStart = txtCpf.Text.Length;
            }

            txtCpf.SelectionStart = txtCpf.Text.Length;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (texto.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (texto.Length == 0)
            {
                txtTelefone.Text = "(" + e.KeyChar;
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
                e.Handled = true; 
                return;
            }

            if (texto.Length == 2) txtTelefone.Text += ") ";

            if (texto.Length == 7) txtTelefone.Text += "-";

            if ((texto.Length <= 2 || texto.Length == 7) && e.KeyChar == (char)Keys.Back)
            {
                txtTelefone.Text = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }

            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }




        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
                return;
            }

            string texto = new string(txtCep.Text.Where(char.IsDigit).ToArray());

            if (texto.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (texto.Length == 5 && e.KeyChar != (char)Keys.Back)
            {
                txtCep.Text += "-";
                txtCep.SelectionStart = txtCep.Text.Length;
            }

            if (texto.Length == 5 && e.KeyChar == (char)Keys.Back)
            {
                txtCep.Text = texto.Substring(0, 5); 
                txtCep.SelectionStart = txtCep.Text.Length;
            }
        }

    }

}
