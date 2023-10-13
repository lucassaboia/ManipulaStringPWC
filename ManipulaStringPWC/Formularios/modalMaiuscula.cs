using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formularios
{
    public partial class modalMaiuscula : Form
    {
        public modalMaiuscula(string output)
        {
            InitializeComponent();
            txtOutput.Texts = output;
            Form_Alert.Notificacao("Texto formatado!", Form_Alert.EnmType.Success);
        }
        private void ModalMaiuscula_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frmMaiusculaHelpers.parentX + 487, frmMaiusculaHelpers.parentY + 320);
        }
        private void BtnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Black;
        }

        private void BtnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = SystemColors.Control;
            btnFechar.ForeColor = SystemColors.ControlText;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Texts);
            Form_Alert.Notificacao("Texto copiado!", Form_Alert.EnmType.Success);

        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Enabled)
            {
                txtOutput.Enabled = true;
                txtOutput.Focus();
                Form_Alert.Notificacao("Disponível para alteração!", Form_Alert.EnmType.Success);
            }
            else
            {
                Form_Alert.Notificacao("Já está disponível para edição.", Form_Alert.EnmType.Info);
            }
        }
    }
}
