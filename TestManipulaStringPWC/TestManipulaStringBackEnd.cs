

using ManipulaStringPWC;

namespace TestManipulaStringPWC

{
    public class TestManipulaStringBackEnd
    {
        [Fact]
        public void TesteInverterPalavras()
        {
            // Arrange
            string input = "o rato roeu a roupa do rei de roma";
            string output = "roma de rei do roupa a roeu rato o";

            // Act
            string result = ManipulaString.InverterPalavras(input);

            // Assert
            Assert.Equal(output, result);
        }

        [Fact]
        public void TesteRemoverDuplicacoes()
        {
            // Arrange
            string input = "aabbcdeeff";
            string output = "abcdef";

            // Act
            string result = ManipulaString.RemoverDuplicacoes(input);

            // Assert
            Assert.Equal(output, result);
        }

        [Fact]
        public void TesteEncontrarPalindromaLonga()
        {
            // Arrange
            string input = "babad";
            string output = "bab";

            // Act
            string result = ManipulaString.EncontrarPalindromaLonga(input);

            // Assert
            Assert.Equal(output, result);
        }

        [Fact]
        public void TesteTransformarPrimeiraLetraMaiuscula()
        {
            // Arrange
            string input = "hello. how are you? i'm fine, thank you.";
            string output = "Hello. How are you? I'm fine, thank you.";

            // Act
            string result = ManipulaString.TransformarPrimeiraLetraMaiuscula(input);

            // Assert
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData("aab", true)]
        [InlineData("abc", false)]
        [InlineData("radar", true)]
        public void TesteIdentificaAnagramaDePalindromo(string input, bool output)
        {
            // Act
            bool result = ManipulaString.IdentificaAnagramaDePalindromo(input);

            // Assert
            Assert.Equal(output, result);
        }
    }
}