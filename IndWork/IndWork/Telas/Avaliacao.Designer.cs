namespace IndWork.Telas
{
    partial class Avaliacao
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
            this.Fechar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPicture1 = new Acelera2025.Ferramentas.RoundedPicture();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.roundedPicture1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
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
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(570, 41);
            this.gradientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradientPanel1.TabIndex = 6;
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
            this.btnSobreNós.Location = new System.Drawing.Point(432, 14);
            this.btnSobreNós.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSobreNós.Name = "btnSobreNós";
            this.btnSobreNós.Size = new System.Drawing.Size(62, 21);
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
            this.btnAjuda.Location = new System.Drawing.Point(362, 14);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(41, 21);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.TabStop = true;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAjuda_LinkClicked);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(541, 4);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(20, 35);
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
            this.Minimizar.Location = new System.Drawing.Point(503, 0);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(22, 39);
            this.Minimizar.TabIndex = 0;
            this.Minimizar.Text = "_";
            this.Minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::IndWork.Properties.Resources.IndWork;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(17, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 15);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(207, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 34);
            this.label4.TabIndex = 32;
            this.label4.Text = "Avalie meu serviço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(253, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 34);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nome";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // roundedPicture1
            // 
            this.roundedPicture1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roundedPicture1.BorderColor = System.Drawing.Color.Black;
            this.roundedPicture1.BorderRadius = 20;
            this.roundedPicture1.BorderSize = 2;
            this.roundedPicture1.Location = new System.Drawing.Point(126, 100);
            this.roundedPicture1.Name = "roundedPicture1";
            this.roundedPicture1.Size = new System.Drawing.Size(97, 91);
            this.roundedPicture1.TabIndex = 35;
            this.roundedPicture1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 119);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(207, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "Faça um comentário";
            // 
            // Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avaliacao";
            this.Text = "Avaliacao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.LinkLabel btnSobreNós;
        private System.Windows.Forms.LinkLabel btnAjuda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private Acelera2025.Ferramentas.RoundedPicture roundedPicture1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}