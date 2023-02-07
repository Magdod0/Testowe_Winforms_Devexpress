using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Testowe_Winforms_Devexpress.Models
{
    public class StorageDocWrapper : INotifyPropertyChanged
    {
        public StorageDoc item;
        public StorageDocWrapper(StorageDoc StorageDoc)
        {
            item = StorageDoc;
        }
        public Storage Storage
        {
            get => item.Storage;
            set
            {
                item.Storage= value;
                OnPropertyChanged("Storage");
            }
        }
        public int? StorageId
        {
            get => item.StorageId;
            set
            {
                item.StorageId = value;
                OnPropertyChanged("StorageId");
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

        public ICollection<OrderProduct> OrderProducts
        {
            get => item.OrderProducts;
            set
            {
                item.OrderProducts= value;
                OnPropertyChanged("OrderProducts");
            }
        }
        public DateTime CreatedDate
        {
            get => item.CreatedDate;
            set
            {
                item.CreatedDate= value;
                OnPropertyChanged("CreatedDate");
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
