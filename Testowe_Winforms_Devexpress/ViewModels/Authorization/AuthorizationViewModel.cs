using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using Testowe_Winforms_Devexpress.Models;
using Testowe_Winforms_Devexpress.ViewModels.Authorization;

namespace Testowe_Winforms_Devexpress.ViewModels.Authorization
{
    [POCOViewModel]
    public class AuthorizationViewModel
    {
        public IEnumerable<string> GetUsers => CredentialSource.GetUserNames();
        public virtual CredentialUser CurrentUser { get; set; }
        public bool IsUserValid { get; private set; }
        public void Init() => CurrentUser = new CredentialUser();
        public void Update() => IsUserValid = CredentialSource.Check(CurrentUser.Login, CurrentUser.Password);
        public static CredentialsViewModel Create() => ViewModelSource.Create<CredentialsViewModel>();
    }
}