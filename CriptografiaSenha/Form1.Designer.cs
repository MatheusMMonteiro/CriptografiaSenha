
namespace CriptografiaSenha
{
    partial class frmCriptografandoSenhas
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSenhaOriginal = new System.Windows.Forms.Label();
            this.lblSenhaCriptografada = new System.Windows.Forms.Label();
            this.txtSenhaOriginal = new System.Windows.Forms.TextBox();
            this.txtSenhaCriptografada = new System.Windows.Forms.TextBox();
            this.btnCriptografarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenhaOriginal
            // 
            this.lblSenhaOriginal.AutoSize = true;
            this.lblSenhaOriginal.Location = new System.Drawing.Point(13, 13);
            this.lblSenhaOriginal.Name = "lblSenhaOriginal";
            this.lblSenhaOriginal.Size = new System.Drawing.Size(76, 13);
            this.lblSenhaOriginal.TabIndex = 0;
            this.lblSenhaOriginal.Text = "Senha Original";
            // 
            // lblSenhaCriptografada
            // 
            this.lblSenhaCriptografada.AutoSize = true;
            this.lblSenhaCriptografada.Location = new System.Drawing.Point(12, 51);
            this.lblSenhaCriptografada.Name = "lblSenhaCriptografada";
            this.lblSenhaCriptografada.Size = new System.Drawing.Size(104, 13);
            this.lblSenhaCriptografada.TabIndex = 1;
            this.lblSenhaCriptografada.Text = "Senha Criptografada";
            // 
            // txtSenhaOriginal
            // 
            this.txtSenhaOriginal.Location = new System.Drawing.Point(143, 5);
            this.txtSenhaOriginal.Name = "txtSenhaOriginal";
            this.txtSenhaOriginal.Size = new System.Drawing.Size(363, 20);
            this.txtSenhaOriginal.TabIndex = 2;
            // 
            // txtSenhaCriptografada
            // 
            this.txtSenhaCriptografada.Location = new System.Drawing.Point(143, 48);
            this.txtSenhaCriptografada.Name = "txtSenhaCriptografada";
            this.txtSenhaCriptografada.Size = new System.Drawing.Size(363, 20);
            this.txtSenhaCriptografada.TabIndex = 3;
            // 
            // btnCriptografarSenha
            // 
            this.btnCriptografarSenha.Location = new System.Drawing.Point(143, 92);
            this.btnCriptografarSenha.Name = "btnCriptografarSenha";
            this.btnCriptografarSenha.Size = new System.Drawing.Size(363, 23);
            this.btnCriptografarSenha.TabIndex = 4;
            this.btnCriptografarSenha.Text = "Criptografar Senha";
            this.btnCriptografarSenha.UseVisualStyleBackColor = true;
            this.btnCriptografarSenha.Click += new System.EventHandler(this.btnCriptografarSenha_Click);
            // 
            // frmCriptografandoSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 127);
            this.Controls.Add(this.btnCriptografarSenha);
            this.Controls.Add(this.txtSenhaCriptografada);
            this.Controls.Add(this.txtSenhaOriginal);
            this.Controls.Add(this.lblSenhaCriptografada);
            this.Controls.Add(this.lblSenhaOriginal);
            this.Name = "frmCriptografandoSenhas";
            this.Text = "Criptografando Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaOriginal;
        private System.Windows.Forms.Label lblSenhaCriptografada;
        private System.Windows.Forms.TextBox txtSenhaOriginal;
        private System.Windows.Forms.TextBox txtSenhaCriptografada;
        private System.Windows.Forms.Button btnCriptografarSenha;
    }
}

