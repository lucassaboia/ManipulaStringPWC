using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmDuplicacao : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmDuplicacao()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public static int parentX, parentY;
        private void btnDuplicacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                Form modalBackground = new Form();
                string input = txtDuplicado.Texts;
                string output = ManipulaString.RemoverDuplicacoes(input);
                using (modalDuplicacao modal = new modalDuplicacao(output))
                {
                    modalBackground.StartPosition = FormStartPosition.CenterScreen;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = new Size(1222, 500);
                    modalBackground.Location = this.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;
                    parentX = this.Location.X;
                    parentY = this.Location.Y;
                    modal.ShowDialog();
                    modalBackground.Dispose();
                }
            }
        }
        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuplicado.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {
                txtDuplicado.Texts = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
