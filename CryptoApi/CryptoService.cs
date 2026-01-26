namespace CryptoApi;

public class CryptoService
{
    private readonly int _shift = 3;

    public string Encrypt(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        return new string(text.Select(c => (char)(c + _shift)).ToArray());
    }

    public string Decrypt(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        return new string(text.Select(c => (char)(c - _shift)).ToArray());
    }
}