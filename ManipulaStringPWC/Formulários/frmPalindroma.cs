using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace ManipulaStringPWC.Formulários
{
    public partial class frmPalindroma : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmPalindroma()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string urlDestino = "https://pt.wikipedia.org/wiki/Pal%C3%ADndromo";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = urlDestino,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void btnPalindromaLonga_Click(object sender, EventArgs e)
        {
            string input = txtPalindromaLonga.Texts;
            string output = ManipulaString.PalindromaLonga(input);

            lblPalindromaLonga.Text = output;
            lblPalindromaLonga.Visible = true;
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            txtPalindromaLonga.Texts = "";
            lblPalindromaLonga.Text = "";
        }
    }
}
