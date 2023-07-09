using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaStringPWC
{
    public class ManipulaString
    {
        public static string InverterPalavras(string input)
        {
            // Dividir a frase em palavras
            string[] palavras = input.Split(' ');

            // Reverter a ordem das palavras
            Array.Reverse(palavras);

            // Juntar as palavras novamente em uma frase
            string reverter = string.Join(" ", palavras);

            return reverter;
        }
        public static string RemoverDuplicacoes(string input)
        {
            string resultado = "";
            foreach (char caracter in input)
            {
                if (!resultado.Contains(caracter))
                {
                    resultado += caracter;
                }
            }

            return resultado;
        }

        public static string EncontrarPalindromaLonga(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            string stringModificar = IdentificarPalindroma(input);

            int[] comprimentroPalindroma = new int[stringModificar.Length];
            int center = 0;
            int limiteDireito = 0;

            for (int i = 1; i < stringModificar.Length - 1; i++)
            {
                int igual = 2 * center - i;

                if (i < limiteDireito)
                    comprimentroPalindroma[i] = Math.Min(limiteDireito - i, comprimentroPalindroma[igual]);

                while (stringModificar[i + (1 + comprimentroPalindroma[i])] == stringModificar[i - (1 + comprimentroPalindroma[i])])
                    comprimentroPalindroma[i]++;

                if (i + comprimentroPalindroma[i] > limiteDireito)
                {
                    center = i;
                    limiteDireito = i + comprimentroPalindroma[i];
                }
            }

            int comprimentoMaximo = comprimentroPalindroma.Max();
            int indiceMaximo = comprimentroPalindroma.ToList().IndexOf(comprimentoMaximo);

            int comecoIndice = (indiceMaximo - comprimentoMaximo) / 2;

            return input.Substring(comecoIndice, comprimentoMaximo);
        }

        public static string IdentificarPalindroma(string input)
        {
            StringBuilder sb = new();

            sb.Append('^');

            foreach (char caracter in input)
            {
                sb.Append('#');
                sb.Append(caracter);
            }

            sb.Append("#$");

            return sb.ToString();
        }
        public static string TransformarPrimeiraLetraMaiuscula(string input)
        {
            string[] frases = input.Split(new[] { '.', '?' });

            StringBuilder construtor = new();

            for (int i = 0; i < frases.Length; i++)
            {
                string frase = frases[i];

                if (!string.IsNullOrWhiteSpace(frase))
                {
                    string cortarFrase = frase.Trim();

                    if (!string.IsNullOrEmpty(cortarFrase))
                    {
                        char[] caracteresFrase = cortarFrase.ToCharArray();
                        caracteresFrase[0] = char.ToUpper(caracteresFrase[0]);
                        construtor.Append(new string(caracteresFrase));
                    }

                    if (i < frases.Length - 1)
                    {
                        char delimitador = input[input.IndexOf(frase) + frase.Length];
                        construtor.Append(delimitador);
                    }

                    construtor.Append(' ');
                }
            }

            return construtor.ToString().Trim();
        }
        public static bool IdentificaAnagramaDePalindromo(string input)
        {
            Dictionary<char, int> contadorCaracter = new();

            // Conta o número de ocorrências de cada caractere
            foreach (char caracter in input)
            {
                if (contadorCaracter.ContainsKey(caracter))
                {
                    contadorCaracter[caracter]++;
                }
                else
                {
                    contadorCaracter[caracter] = 1;
                }
            }

            int oddCount = 0;

            // Verifica se a contagem de ocorrências é válida para um anagrama de palíndromo
            foreach (int count in contadorCaracter.Values)
            {
                if (count % 2 != 0)
                {
                    oddCount++;

                    // Se houver mais de um caractere com contagem ímpar, não é um anagrama de palíndromo
                    if (oddCount > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}