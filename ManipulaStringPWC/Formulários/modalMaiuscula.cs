using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class modalMaiuscula : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public modalMaiuscula(string output)
        {
            InitializeComponent();
            txtOutput.Texts = output;
            this.Alert("Texto formatado!", Form_Alert.enmType.Success);
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void modalMaiuscula_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frmMaiuscula.parentX + 487, frmMaiuscula.parentY + 320);
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Black;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = SystemColors.Control;
            button8.ForeColor = SystemColors.ControlText;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Texts);
            this.Alert("Texto copiado!", Form_Alert.enmType.Success);

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Enabled)
            {
                txtOutput.Enabled = true;
                txtOutput.Focus();
                this.Alert("Disponível para alteração!", Form_Alert.enmType.Success);
            }
            else
            {
                this.Alert("Já está disponível para edição.", Form_Alert.enmType.Info);
            }
        }
    }
}
