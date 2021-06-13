using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptografiaSenha
{
    public partial class frmCriptografandoSenhas : Form
    {
        public frmCriptografandoSenhas()
        {
            InitializeComponent();
        }

        private void btnCriptografarSenha_Click(object sender, EventArgs e)
        {
            txtSenhaCriptografada.Text = CriptografarSenha(txtSenhaOriginal.Text);
        }
        
        private string CriptografarSenha(string senha)
        {
            Byte[] byteTamanhoOriginal = ASCIIEncoding.Default.GetBytes(senha);

            MD5 md5 = new MD5CryptoServiceProvider();

            Byte[] byteTamanhoCriptografado = md5.ComputeHash(byteTamanhoOriginal);

            return Regex.Replace(BitConverter.ToString(
                byteTamanhoCriptografado), "-", "").ToLower();
        }
    }
}
