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
    public partial class Categorias: Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton26_Click(object sender, EventArgs e)
        {
            string textoBusca = "Entregas";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void roundedButton29_Click(object sender, EventArgs e)
        {
            string textoBusca = "Fantasias";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void roundedButton28_Click(object sender, EventArgs e)
        {
            string textoBusca = "Som";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void roundedButton27_Click(object sender, EventArgs e)
        {
            string textoBusca = "Iluminação";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnIndWork_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnConstrucao_Click(object sender, EventArgs e)
        {
            string textoBusca = "Construção";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMecanica_Click(object sender, EventArgs e)
        {
            string textoBusca = "Mecanica";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnLimpeza_Click(object sender, EventArgs e)
        {
            string textoBusca = "Limpeza";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnPintor_Click(object sender, EventArgs e)
        {
            string textoBusca = "Pintor";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnEncanamento_Click(object sender, EventArgs e)
        {
            string textoBusca = "Encanamento";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnEletrica_Click(object sender, EventArgs e)
        {
            string textoBusca = "Eletrica";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnJardinagem_Click(object sender, EventArgs e)
        {
            string textoBusca = "Jardinagem";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMarcenaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Marcenaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnFunilaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Funilaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnVidracaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Vidraçaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMarmoaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Marmoaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnAzulejaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Azulejaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnCabelereiro_Click(object sender, EventArgs e)
        {
            string textoBusca = "Cabelereiro";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnManicure_Click(object sender, EventArgs e)
        {
            string textoBusca = "Manicure";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMassoterapia_Click(object sender, EventArgs e)
        {
            string textoBusca = "Massoterapia";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnEsteticista_Click(object sender, EventArgs e)
        {
            string textoBusca = "Esteticista";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnBarbearia_Click(object sender, EventArgs e)
        {
            string textoBusca = "Barbearia";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnConsultoriaImagem_Click(object sender, EventArgs e)
        {
            string textoBusca = "Consultoria de Imagem";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnDesignSobrancelhas_Click(object sender, EventArgs e)
        {
            string textoBusca = "Design de Sobrancelhas";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnDesignCilios_Click(object sender, EventArgs e)
        {
            string textoBusca = "Design de cilios";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMaquiagem_Click(object sender, EventArgs e)
        {
            string textoBusca = "Maquiagem";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnDepilacao_Click(object sender, EventArgs e)
        {
            string textoBusca = "Depilação";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnCostura_Click(object sender, EventArgs e)
        {
            string textoBusca = "Costura";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnAssistenciaTecnica_Click(object sender, EventArgs e)
        {
            string textoBusca = "Assistencia tecnica";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnConfeitaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Confeitaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnCulinaria_Click(object sender, EventArgs e)
        {
            string textoBusca = "Culinaria";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnBuffet_Click(object sender, EventArgs e)
        {
            string textoBusca = "Buffet";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnFotografia_Click(object sender, EventArgs e)
        {
            string textoBusca = "Fotografia";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnDecoracao_Click(object sender, EventArgs e)
        {
            string textoBusca = "Decoração";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnFreteamento_Click(object sender, EventArgs e)
        {
            string textoBusca = "Freteamento";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }

        private void btnMotoristas_Click(object sender, EventArgs e)
        {
            string textoBusca = "Motoristas";
            Pesquisa pesquisa = new Pesquisa(textoBusca);
            pesquisa.Show();
            this.Hide();
        }
    }
}
