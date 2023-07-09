namespace ManipulaStringPWC
{
    public partial class Form1 : Form
    {
        private ManipulaString ManipulaString = new ManipulaString();
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
            OpenChildForm(new Formulários.frmHome(), btnnavHome);
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
            if (activeForm != null)
            {
                activeForm.Close();
            }
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
        private void btnnavHome_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmHome(), button);
            }
        }
        private void btnnavOrdem_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmOrdem(), button);
            }
        }
        private void btnnavDuplicacao_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmDuplicacao(), button);
            }
        }

        private void btnnavPalindroma_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmPalindroma(), button);
            }
        }

        private void btnnavMaiuscula_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmMaiuscula(), button);
            }
        }

        private void btnnavAnagrama_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                OpenChildForm(new Formulários.frmAnagrama(), button);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button8_Click(object sender, EventArgs e)
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
