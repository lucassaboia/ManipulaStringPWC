using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulaStringPWC.Formulários
{
    public partial class frmAnagrama : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmAnagrama()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string input = txtPalindromo.Texts;
            bool isAnagramOfPalindrome = ManipulaString.IsAnagramOfPalindrome(input);

            lblPalindromo.Text = isAnagramOfPalindrome.ToString();
            lblPalindromo.Visible = true;
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            txtPalindromo.Texts = "";
            lblPalindromo.Text = "";
        }
    }
}
