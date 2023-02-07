using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.StorageDocs
{
    public class StorageDocViewModel : INotifyPropertyChanged
    {
        private StorageDoc item;
        public StorageDocViewModel(StorageDoc Storage)
        {   
            item = Storage;
        }
        public StorageDoc Item
        {
            get => item;
        }
        public Warehouse Storage
        {
            get => item.Storage;
            set
            {
                item.Storage= value;
                OnPropertyChanged("Warehouse");
            }
        }
        public int? StorageId
        {
            get => item.StorageId;
            set
            {
                item.StorageId = value;
                OnPropertyChanged("WarehouseId");
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
