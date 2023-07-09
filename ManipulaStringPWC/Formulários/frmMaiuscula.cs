using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class FrmMaiuscula : Form
    {
        public FrmMaiuscula()
        {
            InitializeComponent();
        }
        public static void Notificacao(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new();
            frm.MostrarNotificacao(msg, type);
        }

        private void BtnMaiusculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                Notificacao("Preencha todos os campos", Form_Alert.EnmType.Info);
            }
            else
            {
                Form modalBackground = new();
                string input = txtMaiuscula.Texts;
                string output = ManipulaString.TransformarPrimeiraLetraMaiuscula(input);
                using modalMaiuscula modal = new(output);
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = new Size(1222, 500);
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                frmMaiusculaHelpers.parentX = this.Location.X;
                frmMaiusculaHelpers.parentY = this.Location.Y;
                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                Notificacao("Não há nada para ser limpo", Form_Alert.EnmType.Warning);
            }
            else
            {
                txtMaiuscula.Texts = "";
                Notificacao("Texto limpo com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
