using IndWork.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndWork
{
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
            panelCategorias.Resize += PanelCategorias_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PanelCategorias_Resize(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void PanelCategorias_Resize(object sender, EventArgs e)
        {
            int espaco = 110;
            int larguraBotao = 60;
            int larguraDisponivel = Math.Max(0, panelCategorias.ClientSize.Width - (5 * espaco) - (2 * larguraBotao));
            int larguraPainel = Math.Max(50, larguraDisponivel / 5);

            int totalLarguraBotoes = (5 * larguraPainel) + (4 * espaco);
            int deslocamentoInicial = Math.Max(0, (panelCategorias.ClientSize.Width - totalLarguraBotoes) / 2);

            var botoesOrdenados = panelCategorias.Controls.OfType<Button>().OrderBy(b => b.TabIndex).ToList();

            int posicaoBotao = 0;
            foreach (Button btn in botoesOrdenados)
            {
                btn.Width = larguraPainel;
                btn.Left = deslocamentoInicial + posicaoBotao * (larguraPainel + espaco);
                btn.Top = Math.Max(0, (panelCategorias.ClientSize.Height - btn.Height) / 2);
                btn.BackgroundImageLayout = ImageLayout.Zoom;

                string labelName = "label" + (posicaoBotao + 1);
                Label label = panelCategorias.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);

                if (label != null)
                {
                    label.Left = btn.Left + (btn.Width - label.Width) / 2;
                    label.Top = btn.Bottom + 10;
                }

                posicaoBotao++;
            }
        }



        private void circularButton5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelCategorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            CadastroPrestador cadastroPrestador = new CadastroPrestador();
            cadastroPrestador.Show();
            this.Hide();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            CadastrarContratante cadastroContratante = new CadastrarContratante();
            cadastroContratante.Show();
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();
            pesquisa.Show();
            this.Hide();
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

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void gerenciarContratante_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarPrestadores_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
