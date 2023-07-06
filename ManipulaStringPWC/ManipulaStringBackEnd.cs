using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaStringPWC
{
    public class ManipulaString
    {
        public string InvertePalavras(string input)
        {
            // Dividir a frase em palavras
            string[] palavras = input.Split(' ');

            // Reverter a ordem das palavras
            Array.Reverse(palavras);

            // Juntar as palavras novamente em uma frase
            string reversed = string.Join(" ", palavras);

            return reversed;
        }
        public string RemoverDuplicacoes(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                if (result.IndexOf(c) == -1)
                {
                    result += c;
                }
            }

            return result;
        }

        public string PalindromaLonga(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            string modifiedString = IdentificaPalindroma(input);

            int[] palindromaLengths = new int[modifiedString.Length];
            int center = 0;
            int rightBoundary = 0;

            for (int i = 1; i < modifiedString.Length - 1; i++)
            {
                int mirror = 2 * center - i;

                if (i < rightBoundary)
                    palindromaLengths[i] = Math.Min(rightBoundary - i, palindromaLengths[mirror]);

                while (modifiedString[i + (1 + palindromaLengths[i])] == modifiedString[i - (1 + palindromaLengths[i])])
                    palindromaLengths[i]++;

                if (i + palindromaLengths[i] > rightBoundary)
                {
                    center = i;
                    rightBoundary = i + palindromaLengths[i];
                }
            }

            int maxLength = palindromaLengths.Max();
            int maxIndex = palindromaLengths.ToList().IndexOf(maxLength);

            int startIndex = (maxIndex - maxLength) / 2;

            return input.Substring(startIndex, maxLength);
        }

        public string IdentificaPalindroma(string input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append('^');

            foreach (char c in input)
            {
                sb.Append('#');
                sb.Append(c);
            }

            sb.Append("#$");

            return sb.ToString();
        }
        public string PrimeiraLetraMaiuscula(string input)
        {
            string[] sentences = input.Split(new[] { '.', '?' });

            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i];

                if (!string.IsNullOrWhiteSpace(sentence))
                {
                    string trimmedSentence = sentence.Trim();

                    if (!string.IsNullOrEmpty(trimmedSentence))
                    {
                        char[] sentenceChars = trimmedSentence.ToCharArray();
                        sentenceChars[0] = char.ToUpper(sentenceChars[0]);
                        resultBuilder.Append(new string(sentenceChars));
                    }

                    if (i < sentences.Length - 1)
                    {
                        char delimiter = input[input.IndexOf(sentence) + sentence.Length];
                        resultBuilder.Append(delimiter);
                    }

                    resultBuilder.Append(" ");
                }
            }

            return resultBuilder.ToString().Trim();
        }
        public static bool IsAnagramOfPalindrome(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Conta o número de ocorrências de cada caractere
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            int oddCount = 0;

            // Verifica se a contagem de ocorrências é válida para um anagrama de palíndromo
            foreach (int count in charCount.Values)
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