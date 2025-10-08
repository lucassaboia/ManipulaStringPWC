using System.Diagnostics;

namespace ManipulaStringPWC.Formularios
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string urlDestino = "https://github.com/lucassaboia/ManipulaStringPWC";
            ProcessStartInfo link = new()
            {
                FileName = urlDestino,
                UseShellExecute = true
            };
            Process.Start(link);
        }
    }
}
