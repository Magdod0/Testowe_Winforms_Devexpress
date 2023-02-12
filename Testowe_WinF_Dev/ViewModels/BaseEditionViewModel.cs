using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.ObjectModel;

namespace Testowe_WinF_Dev.ViewModels
{
    [POCOViewModel]
    public abstract class BaseEditionViewModel<TEntity, TEntityItem>: DocumentManagerViewModel
        where TEntity : class
    {
        // Insert or Update operation of current TEntity.
        private Action<TEntity, object> _result;
        public virtual ObservableCollection<TEntityItem> ItemObjects { get; set; }
        public virtual TEntity Item { get; set; }
        protected bool IsAdding { get; private set; }
        protected BaseEditionViewModel()
        {
        }

        protected BaseEditionViewModel(TEntity item, Action<TEntity, object> result, ObservableCollection<TEntityItem> ItemObjects, bool isAdding):this()
        {
            this.Item = item;
            this._result = result;
            this.ItemObjects = ItemObjects;
            this.IsAdding = isAdding;
        }
        /// <summary>
        /// Saving progress.
        /// </summary>
        /// <param name="ID"></param>
        public void Save(object ID)
        {
            _result(Item, ID);
            CloseDocument();
        }
        /// <summary>
        /// Cancel progress.
        /// </summary>
        public void Cancel()
        {
            MessageResult warningResult = MessageService.ShowMessage("Do you want to Close and lose the progress here?", "Warning!", MessageButton.OKCancel);
            if (warningResult == MessageResult.OK)
            {
                _result(null, null);
                CloseDocument();
            }
        }

    }
}