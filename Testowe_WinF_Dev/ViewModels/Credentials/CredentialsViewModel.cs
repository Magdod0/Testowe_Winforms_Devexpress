using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_WinF_Dev.Models;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Testowe_WinF_Dev.ViewModels.Credentials
{
    public class CredentialsViewModel
    {
        public IEnumerable<string> GetUsers => CredentialSource.GetUserNames();
        public virtual CredentialUser CurrentUser { get; set; }
        public bool IsUserValid { get; private set; }
        [DevExpress.Mvvm.DataAnnotations.Command(false)]
        public void Init() => CurrentUser = new CredentialUser();
        public void Update() => IsUserValid = CredentialSource.Check(CurrentUser.Login, CurrentUser.Password);
        public static CredentialsViewModel Create() => ViewModelSource.Create<CredentialsViewModel>();


    }
}
