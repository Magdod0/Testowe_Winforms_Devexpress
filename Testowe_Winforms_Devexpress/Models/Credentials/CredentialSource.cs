using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowe_Winforms_Devexpress.Models
{
    public class CredentialSource
    {
        static Hashtable credentials;
        static CredentialSource()
        {
            credentials = new Hashtable();
            credentials.Add("Admin", GetHash("admin"));
            credentials.Add("User", GetHash("12345"));
        }
        internal static bool Check(string login, string pwd)
        {
            return object.Equals(credentials[login], GetHash(pwd));
        }
        static object GetHash(string password)
        {
            return password;
        }
        internal static System.Collections.Generic.IEnumerable<string> GetUserNames()
        {
            foreach (string item in credentials.Keys)
                yield return item;
        }
    }
}
