using System.Text;

namespace tress_backend;

public class SessionManager
{
    public byte[] salt
    {
        get
        {
            return Encoding.ASCII.GetBytes("!bnP_{n<|Ii_/!VCW4nT8,xl8@]s|THoVDGYb7zoeUN8 = IZj / Ixk ? W * Kjf, Yfa");
        }
    }

    public string Audience
    {
        get
        {
            return "tress";
        }
    }

    public string Issuer
    {
        get
        {
            return "com.tress";
        }
    }
}
