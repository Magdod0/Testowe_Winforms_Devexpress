using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testowe_WinF_Dev.ViewModels.Credentials;

namespace Testowe_WinF_Dev.Views
{
    public partial class AuthorizationView : DevExpress.XtraEditors.XtraUserControl
    {
        public AuthorizationView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBinding();
            textEdit2.Properties.PasswordChar = '*';
        }

        private void InitializeBinding()
        {
            var fluentAPI = mvvmContext1.OfType<CredentialsViewModel>();
            fluentAPI.SetObjectDataSourceBinding(credentialUserBindingSource,
                x => x.CurrentUser, x => x.Update());

            foreach (string item in fluentAPI.ViewModel.GetUsers)
                textEdit1.Properties.Items.Add(item);
            fluentAPI.ViewModel.Init();
        }
    }
}
