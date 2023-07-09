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
        public static int parentX, parentY;
        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                this.Alert("Preencha todos os campos", Form_Alert.enmType.Info);
            }
            else
            {
                Form modalBackground = new Form();
                string input = txtMaiuscula.Texts;
                string output = ManipulaString.PrimeiraLetraMaiuscula(input);
                using (modalMaiuscula modal = new modalMaiuscula(output))
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
            if (string.IsNullOrEmpty(txtMaiuscula.Texts.Trim()))
            {
                this.Alert("Não há nada para ser limpo", Form_Alert.enmType.Warning);
            }
            else
            {
                txtMaiuscula.Texts = "";
                this.Alert("Texto limpo com sucesso", Form_Alert.enmType.Success);
            }
        }
    }
}
