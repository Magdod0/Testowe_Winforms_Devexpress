using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Testowe_Winforms_Devexpress.Models;

namespace Testowe_Winforms_Devexpress.ViewModels.OrderProducts
{
    public class OrderProductViewModel : INotifyPropertyChanged
    {
        public OrderProduct item;
        public OrderProductViewModel(OrderProduct OrderProduct)
        {
            item = OrderProduct;
        }
        public Product Product
        {
            get => item.Product;
            set
            {
                item.Product = value;
                OnPropertyChanged("Product");
            }
        }
        public Guid ProductId
        {
            get => item.ProductId;
            set
            {
                item.ProductId = value;
                OnPropertyChanged("ProductId");
            }
        }

        public Guid StorageDocId
        {
            get => item.StorageDocId;
            set
            {
                item.StorageDocId= value;
                OnPropertyChanged("StorageDocId");
            }
        }

        public StorageDoc StorageDoc
        {
            get => item.StorageDoc;
            set
            {
                item.StorageDoc= value;
                OnPropertyChanged("StorageDoc");
            }
        }
        public int Units
        {
            get => item.Units;
            set
            {
                item.Units = value;
                OnPropertyChanged("Units");
            }
        }
        public DateTime OrderDate
        {
            get => item.OrderDate;
            set
            {
                item.OrderDate= value;
                OnPropertyChanged("OrderDate");
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
