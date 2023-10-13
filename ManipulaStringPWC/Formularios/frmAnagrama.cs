using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formularios
{
    public partial class frmAnagrama : Form
    {
        public frmAnagrama()
        {
            InitializeComponent();
        }
        private void BtnPalindromo_Click(object sender, EventArgs e)
        {
            string input = txtPalindromo.Texts;
            bool IdentificaAnagramaDePalindromo = ManipulaString.IdentificaAnagramaDePalindromo(input);
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                Form_Alert.Notificacao("Preencha todos os campos", Form_Alert.EnmType.Info);
            }
            else
            {
                lblPalindromo.Visible = true;
                if (IdentificaAnagramaDePalindromo == true)
                {
                    lblPalindromo.Text = "Sim!";
                    Form_Alert.Notificacao("Anagrama identificado!", Form_Alert.EnmType.Success);
                }
                else
                {
                    lblPalindromo.Text = "Não!";
                    Form_Alert.Notificacao("Anagrama não identificado!", Form_Alert.EnmType.Error);
                }
            }
        }

        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                Form_Alert.Notificacao("Não há nada para ser limpo", Form_Alert.EnmType.Warning);
            }
            else
            {
                txtPalindromo.LimparTexto();
                lblPalindromo.Text = "";
                Form_Alert.Notificacao("Texto limpo com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
