using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_WinF_Dev.ViewModels.Credentials;
using Testowe_WinF_Dev.DataModels.GithubAPI;
using System.Configuration;

namespace Testowe_WinF_Dev.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {
        // Current State of app.

        public virtual AppState State { get; set; }
        // Ids of Views.
        static readonly object CredentialsView_ID = new object();
        static readonly object WarehouseView_ID = new object();
        static readonly object WarehouseItemView_ID = new object();
        static readonly object WarehouseDocumentView_ID = new object();
        // ViewModels used.
        private CredentialsViewModel _credentialsViewModel;
        //


        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }
        }
        protected IDocumentManagerService DocumentManagerService
        {
            get => this.GetService<IDocumentManagerService>();
        }
        protected IMessageBoxService MessageService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }
        public MainViewModel()
        {
            _credentialsViewModel = CredentialsViewModel.Create();
        }
        /// <summary>
        /// Create document if it's not exist.
        /// </summary>
        public IDocument CreateDocument(object id, string docType, string title, object parentViewModel)
        {
            var document = DocumentManagerService.FindDocumentById(id);
            if (document == null)
            {
                document = DocumentManagerService.CreateDocument(
                docType, parameter: null, parentViewModel: parentViewModel);
                document.Id = id;
                document.Title = title;
            }
            return document;
        }


        public void FindWarehouseView()
        {
            var document = CreateDocument(WarehouseView_ID, "WarehouseView", "Warehouse", this);
            document.Show();
        }
        public void FindWarehouseItemView()
        {
            var document = CreateDocument(WarehouseItemView_ID, "WarehouseItemView", "Warehouse Item", this);
            document.Show();
        }

        public void FindWarehouseDocumentView()
        {
            var document = CreateDocument(WarehouseDocumentView_ID, "WarehouseDocumentView", "Warehouse Document", this);
            document.Show();
        }
        public void GitHubAPI()
        {
            try
            {
                string token = ConfigurationManager.AppSettings["tokenRead"].ToString();
                var git = new GitHubAPI(token);
                git.GetGitHubRepositoryAsync("Magdod0", "Testowe_Winforms_Devexpress")
                    .ContinueWith(t=>
                    {
                        MessageService.ShowMessage(t.Result.ToString());
                    });
            }
            catch(AggregateException aex)
            {
                MessageService.ShowMessage("Can't reach the Repository!" + aex.Message);
            }
        }
        public void CreateAllDocuments()
        {
            CreateDocument(WarehouseView_ID, "WarehouseView", "Warehouse", this);
            CreateDocument(WarehouseItemView_ID, "WarehouseItemView", "Warehouse Item", this);
            CreateDocument(WarehouseDocumentView_ID, "WarehouseDocumentView", "Warehouse Document", this);

        }
        public void OnLogin()
        {
            CreateAllDocuments();
            Login();
        }
        public void Login()
        {
            Logging(DialogService.ShowDialog(MessageButton.OKCancel, "Please enter you credentials", "AuthorizationView", _credentialsViewModel));
        }
        void Logging(MessageResult result)
        {
            if (result == MessageResult.Cancel)
                State = AppState.ExitQueued;
            else
            {
                if (_credentialsViewModel.IsUserValid)
                    State = AppState.Authorized;
                else
                    Login();
            }
        }

    }
    public enum AppState
    {
        NotAuthorized,
        Authorized,
        ExitQueued
    }
}
