using System.Text;
using CaesarCipher.Services.Interfaces;

namespace CaesarCipher.Services
{
    public class CipherService : ICipherService
    {
        private readonly int _letterCountInAlphabet;

        public CipherService()
        {
            _letterCountInAlphabet = 26;
        }

        public string GetCipheredText(string textToCypher, int steps)
        {
            var cipheredText = new StringBuilder(string.Empty);

            foreach (var letter in textToCypher)
            {
                var charByte = (char)(letter + steps);
                cipheredText.Append(charByte);
            }

            return cipheredText.ToString();
        }

        public string GetDecipheredText(string textToDecipher, int steps)
        {
            return GetCipheredText(textToDecipher, steps * -1);
        }

        public string GetCipheredTextLooped(string textToCipher, int steps)
        {
            var cipheredText = new StringBuilder(string.Empty);

            foreach (var letter in textToCipher)
            {
                if (char.IsLetter(letter))
                {
                    var cipheredLetter = CipherLetterLooped(letter, steps);
                    cipheredText.Append(cipheredLetter);
                }
                else
                {
                    cipheredText.Append(letter);
                }
            }

            return cipheredText.ToString();
        }

        public string GetDecipheredTextLooped(string textToDecipher, int steps)
        {
            return GetCipheredTextLooped(textToDecipher, _letterCountInAlphabet - steps);
        }

        private char CipherLetterLooped(char charToCipher, int steps)
        {
            var charBeforeCipher = charToCipher;
            steps %= _letterCountInAlphabet;

            charToCipher = (char) (charToCipher + steps);
            if (char.IsLower(charBeforeCipher) && charToCipher > 'z' ||
                char.IsUpper(charBeforeCipher) && charToCipher > 'Z')
            {
                charToCipher = (char) (charToCipher - _letterCountInAlphabet);
            }

            return charToCipher;
        }
    }


}