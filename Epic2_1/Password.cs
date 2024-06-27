using System.Security.Cryptography;
using System.Text;

namespace Epic2_1
{
    public class Password
    {
        public string HashPassword(string password)
        {
            if (password != null)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        builder.Append(hashValue[i].ToString());
                    }
                    return builder.ToString();
                }
            }
            return null;
        }
    }
}

