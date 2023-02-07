using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Testowe_Winforms_Devexpress.Models
{
    public class AccountWrapper:INotifyPropertyChanged
    {
        public Account item;
        public AccountWrapper(Account account)
        {
            item = account;
        }
        public string Login 
        { 
            get => item.Login; 
            set 
            {
                item.Login = value;
                OnPropertyChanged("Login"); 
            } 
        }
        public string Password
        {
            get => item.Password; 
            set {
                item.Password = value;
                OnPropertyChanged("Password"); 
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

        public DateTime Created 
        {
            get => item.Created; 
            set { 
                item.Created = value;
                OnPropertyChanged("Created");
            } 
        }
        public DateTime LastUpdated 
        {
            get => item.LastUpdated;
            set {
                item.LastUpdated = value; 
                OnPropertyChanged("LastUpdated"); }
        }
        public DateTime Logged 
        { 
            get => item.Logged;
            set { item.Logged = value;
                OnPropertyChanged("Logged");
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
