using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{

    public partial class frmAnagrama : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();



        public frmAnagrama()
        {
            InitializeComponent();

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string input = txtPalindromo.Texts;
            bool isAnagramOfPalindrome = ManipulaString.IsAnagramOfPalindrome(input);
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                // lblPalindromo.Text = isAnagramOfPalindrome.ToString();  Texto booleano não traduzido
                lblPalindromo.Visible = true;
                if (isAnagramOfPalindrome == true)
                {
                    // String traduzida e notificação
                    lblPalindromo.Text = "Sim!";
                    this.Alert("Anagrama identificado!", Form_Alert.enmType.Success);
                }
                else
                {
                    lblPalindromo.Text = "Não!";
                    this.Alert("Anagrama não identificado!", Form_Alert.enmType.Error);
                }
            }
        }
        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {
                txtPalindromo.Texts = "";
                lblPalindromo.Text = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
