namespace CaesarCipher.Services.Interfaces
{
    public interface ICipherService
    {
        string GetCipheredText(string textToCypher, int steps);
        string GetDecipheredText(string textToDecipher, int steps);
        string GetCipheredTextLooped(string textToCipher, int steps);
        string GetDecipheredTextLooped(string textToDecipher, int steps);
    }
}