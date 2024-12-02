using System.Security.Cryptography;
using System.Text;

namespace CalculXBase.Handlers;

public class EncryptionHandler
{
    private const string key = "bQeThWmZ";
    private const string rgbIV = "cQfTjWmZ";

    private readonly string[] dirtyCharacters = { ";", "/", "?", ":", "@", "&", "=", "+", "$", "," };
    private readonly string[] cleanCharacters = { "p2n3t4G5l6m", "s1l2a3s4h", "q1e2st3i4o5n", "T22p14nt2s", "a9t", "a2n3nd", "e1q2ua88l", "p22l33u1ws", "d0l1ar5", "c0m8a1a" };

    public string UrlEncode(string text)
    {
        foreach (string dirtyCharacter in dirtyCharacters)
        {
            text = text.Replace(dirtyCharacter, cleanCharacters[Array.IndexOf(dirtyCharacters, dirtyCharacter)]);
        }

        return text;
    }

    public string UrlDecode(string encrypted)
    {
        foreach (string symbol in cleanCharacters)
        {
            encrypted = encrypted.Replace(symbol, dirtyCharacters[Array.IndexOf(cleanCharacters, symbol)]);
        }

        return encrypted;
    }

    public string Encrypt(string text)
    {
        SymmetricAlgorithm algorithm = DES.Create();
        ICryptoTransform transform = algorithm.CreateEncryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(rgbIV));
        byte[] inputBuffer = Encoding.Unicode.GetBytes(text);
        byte[] outputBuffer = transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

        return Convert.ToBase64String(outputBuffer);
    }

    public string Decrypt(string encrypted)
    {
        SymmetricAlgorithm algorithm = DES.Create();
        ICryptoTransform transform = algorithm.CreateDecryptor(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(rgbIV));
        byte[] inputBuffer = Convert.FromBase64String(encrypted);
        byte[] outputBuffer = transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

        return Encoding.Unicode.GetString(outputBuffer);
    }
}
