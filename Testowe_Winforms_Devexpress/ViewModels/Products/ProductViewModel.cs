using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.Products
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public Product item;
        public ProductViewModel(Product Product)
        {
            item = Product;
        }
        public int SupplierId
        {
            get => item.SupplierId;
            set
            {
                item.SupplierId= value;
                OnPropertyChanged("SupplierId");
            }
        }
        public int? StorageId
        {
            get => item.StorageId;
            set
            {
                item.StorageId= value;
                OnPropertyChanged("WarehouseId");
            }
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

        public string Name
        {
            get => item.Name;
            set
            {
                item.Name= value;
                OnPropertyChanged("Name");
            }
        }

        public decimal Netto
        {
            get => item.Netto;
            set
            {
                item.Netto= value;
                OnPropertyChanged("Netto");
            }
        }  
        public decimal Brutto
        { 
            get => item.Brutto;
            set
            {
                item.Brutto= value;
                OnPropertyChanged("Brutto");
            }
        }
        public int UnitsAtBeginning
        {
            get => item.UnitsAtBeginning;
            set
            {
                item.UnitsAtBeginning= value;
                OnPropertyChanged("UnitsAtBeginning");
            }
        } 
        public int UnitsLeft
        {
            get => item.UnitsLeft;
            set
            {
                item.UnitsLeft= value;
                OnPropertyChanged("UnitsLeft");
            }
        }
        public DateTime ArrivalDate
        {
            get => item.ArrivalDate;
            set
            {
                item.ArrivalDate= value;
                OnPropertyChanged("ArrivalDate");
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
