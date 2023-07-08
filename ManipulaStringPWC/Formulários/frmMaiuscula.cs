using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmMaiuscula : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmMaiuscula()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                string input = txtMaiuscula.Texts;
                string output = ManipulaString.PrimeiraLetraMaiuscula(input);
                lblMaiusculo.Text = output;
                lblMaiusculo.Visible = true;
                this.Alert("Texto formatado!", Form_Alert.enmType.Success);
            }
        }
        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {       
                txtMaiuscula.Texts = "";
                lblMaiusculo.Text = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
