using IndWork.banco;
using IndWork.dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txtNum.Refresh();

            string numeroTexto = txtNum.Text.Trim();

            int numero;
            if (!int.TryParse(txtNum.Text, out numero))
            {
                MessageBox.Show("Número inválido!");
                return;
            }

            string servicosSelecionados = ObterServicosSelecionados().Trim().Replace(" ", "");

            servicosSelecionados = RemoverAcentos(ObterServicosSelecionados().Trim().Replace(" ", ""));


            EnumServicos servicoEnum;
            if (!Enum.TryParse(servicosSelecionados, true, out servicoEnum))
            {
                MessageBox.Show($"Serviço inválido: '{servicosSelecionados}' não corresponde a um valor válido.");
                return;
            }
            foreach (string nomeEnum in Enum.GetNames(typeof(EnumServicos)))
            {
                Console.WriteLine($"Enum encontrado: {nomeEnum}");
            }


            IndWork.dados.Prestador novoPrestador = new IndWork.dados.Prestador
            (
                0,
                txtNome.Text,
                txtEmail.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtRua.Text,
                txtBairro.Text,
                txtCep.Text,
                numero,
                dateNascimento.Value,
                servicoEnum
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

            PrestadorDAO dao = new PrestadorDAO();
            dao.AdicionarPrestador(novoPrestador);

            MessageBox.Show("Prestador cadastrado com sucesso!");

            Principal p = new Principal();
            p.Show();
            this.Hide(); 

            MessageBox.Show("Prestador cadastrado com sucesso!");
        }

        private string ObterServicosSelecionados()
        {
            List<string> servicos = new List<string>();

            foreach (Control controle in roundedPanel9.Controls)
            {
                if (controle is CheckBox checkbox && checkbox.Checked)
                {
                    servicos.Add(checkbox.Text.Trim()); 
                }
            }

            return servicos.Count > 0 ? string.Join(", ", servicos) : "Nenhum serviço selecionado";
        }
        private string RemoverAcentos(string texto)
        {
            return new string(texto.Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray());
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

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

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
