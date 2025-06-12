namespace IndWork.Telas
{
    partial class Contratacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new GradientPanel();
            this.btnSobreNós = new System.Windows.Forms.LinkLabel();
            this.btnAjuda = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.roundedPanel1 = new RoundedPanel();
            this.cmbContratantes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btncadPrestador = new RoundedButton();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 670);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.btnSobreNós);
            this.gradientPanel1.Controls.Add(this.btnAjuda);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Controls.Add(this.Fechar);
            this.gradientPanel1.Controls.Add(this.Minimizar);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(4)))), ((int)(((byte)(115)))));
            this.gradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(927, 50);
            this.gradientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanel1.TabIndex = 5;
            // 
            // btnSobreNós
            // 
            this.btnSobreNós.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.btnSobreNós.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobreNós.AutoSize = true;
            this.btnSobreNós.BackColor = System.Drawing.Color.Transparent;
            this.btnSobreNós.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreNós.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnSobreNós.LinkColor = System.Drawing.Color.White;
            this.btnSobreNós.Location = new System.Drawing.Point(743, 17);
            this.btnSobreNós.Name = "btnSobreNós";
            this.btnSobreNós.Size = new System.Drawing.Size(78, 27);
            this.btnSobreNós.TabIndex = 5;
            this.btnSobreNós.TabStop = true;
            this.btnSobreNós.Text = "Sobre nós";
            this.btnSobreNós.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSobreNós.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSobreNós_LinkClicked);
            // 
            // btnAjuda
            // 
            this.btnAjuda.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjuda.AutoSize = true;
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnAjuda.LinkColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(650, 17);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(51, 27);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.TabStop = true;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAjuda_LinkClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::IndWork.Properties.Resources.IndWork;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(23, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 18);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(889, 5);
            this.Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(27, 43);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizar.ForeColor = System.Drawing.Color.White;
            this.Minimizar.Location = new System.Drawing.Point(838, 0);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(29, 48);
            this.Minimizar.TabIndex = 0;
            this.Minimizar.Text = "_";
            this.Minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.cmbContratantes);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.txtContato);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.txtDescricao);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.lblEmail);
            this.roundedPanel1.Controls.Add(this.btncadPrestador);
            this.roundedPanel1.Location = new System.Drawing.Point(200, 149);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(547, 416);
            this.roundedPanel1.TabIndex = 31;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // cmbContratantes
            // 
            this.cmbContratantes.FormattingEnabled = true;
            this.cmbContratantes.Location = new System.Drawing.Point(37, 125);
            this.cmbContratantes.Name = "cmbContratantes";
            this.cmbContratantes.Size = new System.Drawing.Size(464, 24);
            this.cmbContratantes.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Contratante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "Contato de contratante";
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(37, 180);
            this.txtContato.Multiline = true;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(464, 26);
            this.txtContato.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Insira data, hora e o que deseja";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(37, 235);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(464, 93);
            this.txtDescricao.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 78;
            this.label1.Text = "Descrição da Solicitação";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 41);
            this.lblEmail.TabIndex = 77;
            this.lblEmail.Text = "Email";
            // 
            // btncadPrestador
            // 
            this.btncadPrestador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(4)))), ((int)(((byte)(115)))));
            this.btncadPrestador.BorderColor = System.Drawing.Color.Black;
            this.btncadPrestador.BorderRadius = 20;
            this.btncadPrestador.BorderSize = 0;
            this.btncadPrestador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadPrestador.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadPrestador.ForeColor = System.Drawing.Color.White;
            this.btncadPrestador.Location = new System.Drawing.Point(161, 354);
            this.btncadPrestador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncadPrestador.Name = "btncadPrestador";
            this.btncadPrestador.Size = new System.Drawing.Size(236, 41);
            this.btncadPrestador.TabIndex = 76;
            this.btncadPrestador.Text = "Contratar";
            this.btncadPrestador.UseVisualStyleBackColor = false;
            this.btncadPrestador.Click += new System.EventHandler(this.btncadPrestador_Click);
            // 
            // Contratacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contratacao";
            this.Text = "Contratacao";
            this.panel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.LinkLabel btnSobreNós;
        private System.Windows.Forms.LinkLabel btnAjuda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button Minimizar;
        private RoundedPanel roundedPanel1;
        private RoundedButton btncadPrestador;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.ComboBox cmbContratantes;
        private System.Windows.Forms.Label label4;
    }
}