namespace ManipulaStringPWC
{
    public partial class Form1 : Form
    {
        private ManipulaString ManipulaString;

        public Form1()
        {
            InitializeComponent();
            ManipulaString = new ManipulaString();
        }
        private void btnOrdem_Click(object sender, EventArgs e)
        {
            string input = txtOrdem.Text;
            string output = ManipulaString.InvertePalavras(input);
            lblOrdem.Text = output;
            lblOrdem.Visible = true;
        }

        private void btnDuplicacao_Click(object sender, EventArgs e)
        {
            string input = txtDuplicado.Text;
            string output = ManipulaString.RemoverDuplicacoes(input);

            lblDuplicacao.Text = output;
            lblDuplicacao.Visible = true;
        }

        private void btnPalindromaLonga_Click(object sender, EventArgs e)
        {
            string input = txtPalindromaLonga.Text;
            string output = ManipulaString.PalindromaLonga(input);

            lblPalindromaLonga.Text = output;
            lblPalindromaLonga.Visible = true;
        }

        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            string input = txtMaiuscula.Text;
            string output = ManipulaString.PrimeiraLetraMaiuscula(input);

            lblMaiusculo.Text = output;
            lblMaiusculo.Visible = true;
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string input = txtPalindromo.Text;
            bool isAnagramOfPalindrome = ManipulaString.IsAnagramOfPalindrome(input);

            lblPalindromo.Text = isAnagramOfPalindrome.ToString();
            lblPalindromo.Visible = true;
        }
    }
}
