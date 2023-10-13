using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formularios
{
    public partial class frmOrdem : Form
    {
        public frmOrdem()
        {
            InitializeComponent();
        }
        private void BtnOrdem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                Form_Alert.Notificacao("Preencha todos os campos.", Form_Alert.EnmType.Info);
            }
            else
            {
                Form modalBackground = new();
                string input = txtOrdem.Texts;
                string output = ManipulaString.InverterPalavras(input);
                using modalOrdem modal = new(output);
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = new Size(1222, 500);
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                frmOrdemHelpers.parentX = this.Location.X;
                frmOrdemHelpers.parentY = this.Location.Y;
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                Form_Alert.Notificacao("Não há nada para ser limpo.", Form_Alert.EnmType.Warning);
            }
            else
            {
                Form_Alert.Notificacao("Texto limpo com sucesso!", Form_Alert.EnmType.Success);
                txtOrdem.LimparTexto();
            }
        }
    }
}
