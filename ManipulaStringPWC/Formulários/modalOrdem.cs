using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class modalOrdem : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public modalOrdem(string output)
        {
            InitializeComponent();
            txtOutput.Texts = output;
            this.Notificacao("Texto invertido!", Form_Alert.EnmType.Success);
        }
        public void Notificacao(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.MostrarNotificacao(msg, type);
        }
        private void modalOrdem_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frmMaiusculaHelpers.parentX + 487, frmMaiusculaHelpers.parentY + 320);
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
            this.Notificacao("Texto copiado!", Form_Alert.EnmType.Success);

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Enabled)
            {
                txtOutput.Enabled = true;
                txtOutput.Focus();
                this.Notificacao("Disponível para alteração!", Form_Alert.EnmType.Success);
            }
            else
            {
                this.Notificacao("Já está disponível para edição.", Form_Alert.EnmType.Info);
            }
        }
    }
}
