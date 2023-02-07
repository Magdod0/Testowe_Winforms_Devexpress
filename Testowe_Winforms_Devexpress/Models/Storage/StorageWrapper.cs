using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Testowe_Winforms_Devexpress.Models
{
    public class StorageWrapper : INotifyPropertyChanged
    {
        public Storage item;
        public StorageWrapper(Storage Storage)
        {
            item = Storage;
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
