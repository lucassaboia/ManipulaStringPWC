using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManipulaStringPWC.Formulários
{
    public partial class frmMaiuscula : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmMaiuscula()
        {
            InitializeComponent();
        }

        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            string input = txtMaiuscula.Texts;
            string output = ManipulaString.PrimeiraLetraMaiuscula(input);
            lblMaiusculo.Text = output;
            lblMaiusculo.Visible = true;
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            txtMaiuscula.Texts = "";
            lblMaiusculo.Text = "";
        }
    }
}
