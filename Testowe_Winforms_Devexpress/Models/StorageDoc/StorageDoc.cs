using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_Winforms_Devexpress.Models
{
    public class StorageDoc
    {
        public StorageDoc()
        {
            OrderProducts = new List<OrderProduct>();
        }
        public Guid StorageDocId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? StorageId { get; set; }
        public Storage Storage { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }


    }

}
