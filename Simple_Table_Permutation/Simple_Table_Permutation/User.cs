using System.Security.Cryptography;
using System.Text;

namespace Simple_Table_Permutation
{
    public class User
    {
        public string id { get; }
        public string username { get; }
        public string login { get; }
        public string password { get; }
        public string role { get; }

        public User() { }
        public User(string id, string username, string login, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.login = login;
            this.password = password;
            this.role = role;

        }
        public bool CheckUser()
        {
            if (new Database("Data Source=MyDB.db; Version=3").ValidUser(login, password))
                return true;
            else
                return false;
        }
        public static string GetHash(string input)
        {
            using (SHA1Managed sHA1Managed = new SHA1Managed())
            {
                var hash = sHA1Managed.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
