using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmDuplicacao : Form
    {
        public frmDuplicacao()
        {
            InitializeComponent();
        }

        public static void Notificacao(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new();
            frm.MostrarNotificacao(msg, type);
        }

        private void BtnDuplicacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                Notificacao("Preencha todos os campos", Form_Alert.EnmType.Info);
            }
            else
            {
                Form modalBackground = new();
                string input = txtDuplicado.Texts;
                string output = ManipulaString.RemoverDuplicacoes(input);
                using modalDuplicacao modal = new(output);
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = new Size(1222, 500);
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                frmDuplicacaoHelpers.parentX = this.Location.X;
                frmDuplicacaoHelpers.parentY = this.Location.Y;
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                Notificacao("Não há nada para ser limpo", Form_Alert.EnmType.Warning);
            }
            else
            {
                txtDuplicado.Texts = "";
                Notificacao("Texto limpo com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
