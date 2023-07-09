using CustomAlertBoxDemo;
namespace ManipulaStringPWC.Formulários
{
    public partial class frmAnagrama : Form
    {
        public frmAnagrama()
        {
            InitializeComponent();
        }
        public static void Notificacao(string msg, Form_Alert.EnmType type)
        {
            // Cria uma instância do formulário de notificação
            Form_Alert frm = new();

            // Chama o método mostrarNotificacao no formulário de notificação para exibir a notificação
            frm.MostrarNotificacao(msg, type);
        }

        private void BtnPalindromo_Click(object sender, EventArgs e)
        {
            // Obtém o texto do campo de entrada
            string input = txtPalindromo.Texts;

            // Identifica se é um anagrama de palíndromo
            bool IdentificaAnagramaDePalindromo = ManipulaString.IdentificaAnagramaDePalindromo(input);

            // Verifica se o campo de entrada está vazio ou contém apenas espaços em branco
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                // Mostra uma notificação de que todos os campos devem ser preenchidos
                Notificacao("Preencha todos os campos", Form_Alert.EnmType.Info);
            }
            else
            {
                // lblPalindromo.Text = IdentificaAnagramaDePalindromo.ToString();  Texto booleano não traduzido

                // Torna o rótulo de palíndromo visível
                lblPalindromo.Visible = true;

                if (IdentificaAnagramaDePalindromo == true)
                {
                    // Define o texto do rótulo de palíndromo como "Sim!"
                    lblPalindromo.Text = "Sim!";

                    // Mostra uma notificação de que um anagrama foi identificado
                    Notificacao("Anagrama identificado!", Form_Alert.EnmType.Success);
                }
                else
                {
                    // Define o texto do rótulo de palíndromo como "Não!"
                    lblPalindromo.Text = "Não!";

                    // Mostra uma notificação de que nenhum anagrama foi identificado
                    Notificacao("Anagrama não identificado!", Form_Alert.EnmType.Error);
                }
            }
        }

        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de entrada está vazio ou contém apenas espaços em branco
            if (string.IsNullOrEmpty(txtPalindromo.Texts.Trim()))
            {
                // Mostra uma notificação de que não há nada para limpar
                Notificacao("Não há nada para ser limpo", Form_Alert.EnmType.Warning);
            }
            else
            {
                // Limpa o campo de entrada e o rótulo de palíndromo
                txtPalindromo.Texts = "";
                lblPalindromo.Text = "";

                // Mostra uma notificação de que o texto foi limpo com sucesso
                Notificacao("Texto limpo com sucesso", Form_Alert.EnmType.Success);
            }
        }
    }
}
