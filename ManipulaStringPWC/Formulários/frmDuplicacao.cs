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
    public partial class frmDuplicacao : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmDuplicacao()
        {
            InitializeComponent();
        }

        private void btnDuplicacao_Click(object sender, EventArgs e)
        {
            string input = txtDuplicado.Texts;
            string output = ManipulaString.RemoverDuplicacoes(input);

            lblDuplicacao.Text = output;
            lblDuplicacao.Visible = true;
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            txtDuplicado.Texts = "";
            lblDuplicacao.Text = "";
        }
    }
}
