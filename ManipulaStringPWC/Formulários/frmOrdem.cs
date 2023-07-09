using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmOrdem : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
        public frmOrdem()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public static int parentX, parentY;
        private void btnOrdem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos.", Form_Alert.enmType.Info);
            }
            else
            {
                Form modalBackground = new Form();
                string input = txtOrdem.Texts;
                string output = ManipulaString.InvertePalavras(input);
                using (modalOrdem modal = new modalOrdem(output))
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
        private void customButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdem.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo.", Form_Alert.enmType.Warning);
            }
            else
            {
                this.Alert("Texto limpo com sucesso!", Form_Alert.enmType.Success);
                txtOrdem.Texts = "";
            }
        }
    }
}
