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
            string urlDestino = "manipulastringweb.vercel.app";
            ProcessStartInfo link = new()
            {
                FileName = urlDestino,
                UseShellExecute = true
            };
            Process.Start(link);
        }
    }
}
