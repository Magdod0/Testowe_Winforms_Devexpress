using DevExpress.Utils.Behaviors.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Testowe_Winforms_Devexpress.Contexts;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Storages
{
    public class StorageViewModel : INotifyPropertyChanged
    {

        private Warehouse item;
        public StorageViewModel(Warehouse Storage)
        {
            item = Storage;
        }
        public Warehouse Item
        {
            get => item;
        }
        public string Address
        {
            get => item.Address;
            set
            {
                item.Address= value;
                OnPropertyChanged("Address");
            }
        }

        public string Name
        {
            get => item.Name;
            set
            {
                item.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
