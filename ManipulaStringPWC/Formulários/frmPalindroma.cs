using System.Diagnostics;
using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmPalindroma : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmPalindroma()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string urlDestino = "https://pt.wikipedia.org/wiki/Pal%C3%ADndromo";
            ProcessStartInfo link = new ProcessStartInfo
            {
                FileName = urlDestino,
                UseShellExecute = true
            };
            Process.Start(link);
        }
        private void btnPalindromaLonga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalindromaLonga.Texts.Trim()))

            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                string input = txtPalindromaLonga.Texts;
                string output = ManipulaString.PalindromaLonga(input);
                lblPalindromaLonga.Text = output;
                lblPalindromaLonga.Visible = true;
                this.Alert("Maior palíndroma identificada!", Form_Alert.enmType.Success);
            }
        }
        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalindromaLonga.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {
                txtPalindromaLonga.Texts = "";
                lblPalindromaLonga.Text = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
