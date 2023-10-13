namespace ManipulaStringPWC
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            currentButton = new Button();
            activeForm = new Form();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.frmHome(), btnnavHome);
        }
        private void ClicarBotao(Button button)
        {
            if (button != null && currentButton != button)
            {
                SairBotao();
                Color color = Color.FromArgb(29, 29, 29);
                currentButton = button;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void SairBotao()
        {
            foreach (Control previousBtn in panelNavbar.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.FromArgb(249, 249, 249);
                    previousBtn.ForeColor = Color.FromArgb(156, 156, 156);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, Button button)
        {
            activeForm?.Close();
            if (button != null)
            {
                ClicarBotao(button);
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnnavHome_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.frmHome(), button);
            }
        }
        private void BtnnavOrdem_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.frmOrdem(), button);
            }
        }
        private void BtnnavDuplicacao_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.frmDuplicacao(), button);
            }
        }

        private void BtnnavPalindroma_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.frmPalindroma(), button);
            }
        }

        private void BtnnavMaiuscula_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.FrmMaiuscula(), button);
            }
        }
        private void BtnnavAnagrama_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formularios.frmAnagrama(), button);
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                      "PWC - Processo Seletivo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
