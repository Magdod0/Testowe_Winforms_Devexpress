using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Testowe_Winforms_Devexpress.Models
{
    public class ProductWrapper : INotifyPropertyChanged
    {
        public Product item;
        public ProductWrapper(Product Product)
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
                OnPropertyChanged("StorageId");
            }
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
