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
    public partial class Avaliacao: Form
    {
        private int notaSelecionada = 0;
        public int Nota { get; set; } 
        public string Comentario { get; set; }
        private int prestadorId;
        private Prestador prestadorSelecionado;
        public Avaliacao(Prestador prestador)
        {
            InitializeComponent();
            this.prestadorId = prestadorId;
            prestadorSelecionado = prestador;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            IndWork.dados.Avaliacao avaliacao = new IndWork.dados.Avaliacao
            {
                Nota = notaSelecionada,
                Comentario = txtComentario.Text.Trim()
            };

            new AvaliacaoDAO().InserirAvaliacao(avaliacao);

            this.Hide();
        }


        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
            this.Hide();
        }

        private void btnSobreNós_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SobreNos sobreNos = new SobreNos();
            sobreNos.Show();
            this.Hide();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AtualizarEstrelas(5);
        
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            AtualizarEstrelas(4);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AtualizarEstrelas(3);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           AtualizarEstrelas(2); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           AtualizarEstrelas(1);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Avaliacao_Load(object sender, EventArgs e)
        {
        }
        private void AtualizarEstrelas(int estrelas)
        {
            notaSelecionada = estrelas;
            btn1.BackgroundImage = estrelas >= 1 ? Properties.Resources.Star_1__1_ : Properties.Resources.Star_1;
            btn2.BackgroundImage = estrelas >= 2 ? Properties.Resources.Star_1__1_ : Properties.Resources.Star_1;
            btn3.BackgroundImage = estrelas >= 3 ? Properties.Resources.Star_1__1_ : Properties.Resources.Star_1;
            btn4.BackgroundImage = estrelas >= 4 ? Properties.Resources.Star_1__1_ : Properties.Resources.Star_1;
            btn5.BackgroundImage = estrelas >= 5 ? Properties.Resources.Star_1__1_ : Properties.Resources.Star_1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string comentario = txtComentario.Text.Trim();

            if (notaSelecionada == 0)
            {
                MessageBox.Show("Por favor, selecione uma nota.");
                return;
            }

            if (prestadorSelecionado == null)
            {
                MessageBox.Show("Erro: prestador não selecionado.");
                return;
            }

            IndWork.dados.Avaliacao ava = new IndWork.dados.Avaliacao
            {
                PrestadorId = prestadorSelecionado.Id, 
                Nota = notaSelecionada,
                Comentario = comentario
            };

            try
            {
                new AvaliacaoDAO().InserirAvaliacao(ava);

                PerfilPrestador perfil = Application.OpenForms["PerfilPrestador"] as PerfilPrestador;
                perfil?.AtualizarNota();

                MessageBox.Show("Avaliação enviada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar avaliação: " + ex.Message);
            }
        }


    }
}
