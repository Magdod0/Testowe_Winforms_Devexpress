using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace Testowe_WinF_Dev.ViewModels
{
    [POCOViewModel]
    public abstract class DocumentManagerViewModel:IDocumentContent
    {
        protected IDocument OwnedDocument;

        public object Title { get =>  null; }

        protected IDocumentManagerService DocumentManagerService
        {
            get => this.GetService<IDocumentManagerService>();
        }
        protected IDocumentOwner documentOwner;
        protected IMessageBoxService MessageService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }

        IDocumentOwner IDocumentContent.DocumentOwner { get => documentOwner; set => documentOwner = value; }
        /// <summary>
        /// Create new Document.
        /// </summary>
        /// <param name="viewName"></param>
        /// <param name="title"></param>
        /// <param name="viewModel"></param>
        public void CreateDocument(string viewName, string title, object viewModel)
        { 
            OwnedDocument = DocumentManagerService.CreateDocument(viewName, viewModel);
            OwnedDocument.Title = title;
            OwnedDocument.DestroyOnClose = true;
            OwnedDocument.Show();
        }
        /// <summary>
        /// Document close itself.
        /// </summary>
        public void CloseDocument()
        {
            if (documentOwner != null)
            {
                documentOwner.Close(this);
            }
        }
        public virtual void OnClose(CancelEventArgs e)
        {

        }

        public virtual void OnDestroy()
        {
            
        }
    }
}