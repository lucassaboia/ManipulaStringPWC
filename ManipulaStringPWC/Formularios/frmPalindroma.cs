using System.Diagnostics;
using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formularios
{
    public partial class frmPalindroma : Form
    {
        public frmPalindroma()
        {
            InitializeComponent();
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            string urlDestino = "https://pt.wikipedia.org/wiki/Pal%C3%ADndromo";
            ProcessStartInfo link = new()
            {
                FileName = urlDestino,
                UseShellExecute = true
            };
            Process.Start(link);
        }
        private void BtnEncontrarPalindromaLonga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncontrarPalindromaLonga.Texts.Trim()))
            {
                Form_Alert.Notificacao("Preencha todos os campos", Form_Alert.EnmType.Info);
            }
            else
            {
                string input = txtEncontrarPalindromaLonga.Texts;
                string output = ManipulaString.EncontrarPalindromaLonga(input);
                lblEncontrarPalindromaLonga.Text = output;
                lblEncontrarPalindromaLonga.Visible = true;
                Form_Alert.Notificacao("Maior palíndroma identificada!", Form_Alert.EnmType.Success);
            }
        }
        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncontrarPalindromaLonga.Texts.Trim()))
            {
                Form_Alert.Notificacao("Não há nada para ser limpo", Form_Alert.EnmType.Warning);
            }
            else
            {
                txtEncontrarPalindromaLonga.LimparTexto();
                lblEncontrarPalindromaLonga.Text = "";
                Form_Alert.Notificacao("Texto limpo com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
