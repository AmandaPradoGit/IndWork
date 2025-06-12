using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndWork.dados;
using IndWork.banco;

namespace IndWork.Telas
{
    public partial class Contratacao : Form
    {
        private string emailPrestador;

        public Contratacao(string email)
        {
            InitializeComponent();
            emailPrestador = email;
            PreencherDados();
            CarregarComboBoxContratantes();
        }

        private void CarregarComboBoxContratantes()
        {
            CadastroDAO dao = new CadastroDAO();
            List<Contratante> contratantes = dao.PesquisarContratante(""); 

            cmbContratantes.DataSource = contratantes;
            cmbContratantes.DisplayMember = "Nome"; 
            cmbContratantes.ValueMember = "Id"; 

        }

        private void PreencherDados()
        {
            lblEmail.Text = emailPrestador; 
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
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

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncadPrestador_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = cmbContratantes.Text;
            string descricao = txtDescricao.Text.Trim();
            string contato = txtContato.Text.Trim();
            try
            {
                var fromAddress = new MailAddress("dairohelp@gmail.com", "Recuperação Senha");
                var toAddress = new MailAddress(lblEmail.Text.Trim(), "Destinatário");
                const string fromPassword = "tkep pwkn tsor voas";
                const string subject = "Solicitação de Contrato";
                string body = "Comunicamos que " + nomeSelecionado + " Solicitou seu serviço. Descrição: "+
                descricao + " onde " + nomeSelecionado + " forneceu este contato: "+contato;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

