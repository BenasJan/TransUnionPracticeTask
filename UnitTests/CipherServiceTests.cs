using CaesarCipher.Services;
using CaesarCipher.Services.Interfaces;
using NUnit.Framework;

namespace UnitTests
{
    public class CipherServiceTests
    {
        private readonly ICipherService _cipherService = new CipherService();

        [Test]
        [TestCase("uvwxyzXYZ", 3, ExpectedResult = @"xyz{|}[\]")]
        [TestCase("]^_`", 4, ExpectedResult = "abcd")]
        [TestCase("hOuSe", 7, ExpectedResult = "oV|Zl")]
        public string GetCipheredText_AnyText_ReturnsCipheredText(string textToCipher, int steps)
        {
            var cipheredText = _cipherService.GetCipheredText(textToCipher, steps);

            return cipheredText;
        }

        [Test]
        [TestCase(@"xyz{|}[\]", 3, ExpectedResult = "uvwxyzXYZ")]
        [TestCase("abcd", 4, ExpectedResult = "]^_`")]
        [TestCase("oV|Zl", 7, ExpectedResult = "hOuSe")]
        public string GetDecipheredText_AnyText_ReturnsDecipheredText(string textToDecipher, int steps)
        {
            var decipheredText = _cipherService.GetDecipheredText(textToDecipher, steps);

            return decipheredText;
        }

        [Test]
        [TestCase("AbCdEzZ", 3, ExpectedResult = "DeFgHcC")]
        [TestCase("namas", 5, ExpectedResult = "sfrfx")]
        [TestCase("IJklmNOPqRsT", 27, ExpectedResult = "JKlmnOPQrStU")]
        [TestCase("123abcdef", 60, ExpectedResult = "123ijklmn")]
        public string GetCipheredTextLooped_LettersAndNotLettersText_ReturnsCipheredText(string textToCipher, int steps)
        {
            var cipheredText = _cipherService.GetCipheredTextLooped(textToCipher, steps);

            return cipheredText;
        }

        [Test]
        [TestCase("DeFg=/HcC", 3, ExpectedResult = "AbCd=/EzZ")]
        [TestCase("sfrfx", 5, ExpectedResult = "namas")]
        [TestCase("JKlmnOPQrStU", 27, ExpectedResult = "IJklmNOPqRsT")]
        [TestCase("ijk*-+8lmn", 60, ExpectedResult = "abc*-+8def")]
        public string GetDecipheredTextLooped_LettersAndNotLettersText_ReturnsDecipheredText(string textToDecipher, int steps)
        {
            var decipheredText = _cipherService.GetDecipheredTextLooped(textToDecipher, steps);
            
            return decipheredText;
        }
    }
}