namespace IndWork.Telas
{
    partial class CardPesquisa
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFoto = new CircularButton();
            this.linkResultado = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFoto.BorderColor = System.Drawing.Color.Black;
            this.btnFoto.BorderSize = 0;
            this.btnFoto.Location = new System.Drawing.Point(15, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(45, 42);
            this.btnFoto.TabIndex = 0;
            this.btnFoto.Text = "circularButton1";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // linkResultado
            // 
            this.linkResultado.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkResultado.AutoSize = true;
            this.linkResultado.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkResultado.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkResultado.Location = new System.Drawing.Point(66, 9);
            this.linkResultado.Name = "linkResultado";
            this.linkResultado.Size = new System.Drawing.Size(102, 36);
            this.linkResultado.TabIndex = 1;
            this.linkResultado.TabStop = true;
            this.linkResultado.Text = "Resultado";
            this.linkResultado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CardPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkResultado);
            this.Controls.Add(this.btnFoto);
            this.Name = "CardPesquisa";
            this.Size = new System.Drawing.Size(993, 49);
            this.Load += new System.EventHandler(this.CardPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton btnFoto;
        private System.Windows.Forms.LinkLabel linkResultado;
    }
}
