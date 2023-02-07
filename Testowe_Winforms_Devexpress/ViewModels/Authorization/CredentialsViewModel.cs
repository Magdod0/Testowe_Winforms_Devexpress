using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Authorization
{
    public class CredentialsViewModel
    {
        public IEnumerable<string> GetUsers => CredentialSource.GetUserNames();
        public virtual CredentialUser CurrentUser { get; set; }
        public bool IsUserValid { get; private set; }
        public void Init() => CurrentUser = new CredentialUser();
        public void Update() => IsUserValid = CredentialSource.Check(CurrentUser.Login, CurrentUser.Password);
        public static CredentialsViewModel Create() => ViewModelSource.Create<CredentialsViewModel>();
    }
}
