using CustomAlertBoxDemo;
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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnDuplicacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                string input = txtDuplicado.Texts;
                string output = ManipulaString.RemoverDuplicacoes(input);
                lblDuplicacao.Text = output;
                lblDuplicacao.Visible = true;
                this.Alert("Retirado todas as duplicações!", Form_Alert.enmType.Success);
            }
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {                
                txtDuplicado.Texts = "";
                lblDuplicacao.Text = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
