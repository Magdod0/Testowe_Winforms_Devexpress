using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Xml.Linq;

namespace Testowe_Winforms_Devexpress.Models
{
    public class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Logged { get; set;  }
    }
}
