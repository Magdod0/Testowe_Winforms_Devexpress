using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Testowe_Winforms_Devexpress.Models
{
    public class ClientWrapper : INotifyPropertyChanged
    {
        public Client item;
        public ClientWrapper(Client Client)
        {
            item = Client;
        }
        public string ContactName
        {
            get => item.ContactName;
            set
            {
                item.ContactName= value; 
                OnPropertyChanged("ContactName");
            }
        }
        public string Name
        {
            get => item.Name;
            set
            {
                item.Name= value;
                OnPropertyChanged("Name");
            }
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

        public string Phone
        {
            get => item.Phone;
            set
            {
                item.Phone= value;
                OnPropertyChanged("Phone");
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
