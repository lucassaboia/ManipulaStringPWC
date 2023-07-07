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
    public partial class frmOrdem : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmOrdem()
        {
            InitializeComponent();
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            string input = txtOrdem.Texts;
            string output = ManipulaString.InvertePalavras(input);
            lblOrdem.Text = output;
            lblOrdem.Visible = true;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            txtOrdem.Texts = "";
            lblOrdem.Text = "";
        }
    }
}
