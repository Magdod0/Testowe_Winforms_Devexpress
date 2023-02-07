using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_Winforms_Devexpress.Models
{
    public class Storage
    {
        public Storage()
        {
            Products = new List<Product>();
        }
        public int StorageId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
