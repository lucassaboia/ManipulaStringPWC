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
    public partial class frmOrdem : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmOrdem()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnOrdem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos.", Form_Alert.enmType.Info);
            }
            else
            {  
                string input = txtOrdem.Texts;
                string output = ManipulaString.InvertePalavras(input);
                lblOrdem.Text = output;
                lblOrdem.Visible = true;
                this.Alert("Ordem invertida!", Form_Alert.enmType.Success);
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo.", Form_Alert.enmType.Warning);
            }
            else
            {

                this.Alert("Texto limpo com sucesso!", Form_Alert.enmType.Success);
                txtOrdem.Texts = "";
                lblOrdem.Text = "";
            }
        }
    }
}
