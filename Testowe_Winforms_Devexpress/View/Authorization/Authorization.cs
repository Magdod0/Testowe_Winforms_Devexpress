using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
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
using Testowe_Winforms_Devexpress.ViewModels.Authorization;

namespace Testowe_Winforms_Devexpress.View.Authorization
{
    public partial class Authorization : DevExpress.XtraEditors.XtraUserControl
    {
        public Authorization()
        {
            InitializeComponent();
            textPassword.Properties.PasswordChar= '*';
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            var fluentAPI = mvvmContext1.OfType<CredentialsViewModel>();
            fluentAPI.SetObjectDataSourceBinding(credentialUserBindingSource,
                x => x.CurrentUser, x => x.Update());
        }
    }
}
