using System;
using System.ComponentModel.DataAnnotations;

namespace Testowe_Winforms_Devexpress.Models
{
    public class OrderProduct
    {
        public Guid OrderProductId { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid StorageDocId { get; set; }
        public virtual StorageDoc StorageDoc { get; set; }
        [Range(1, int.MaxValue-1, ErrorMessage ="Can't be less than 1!")]
        public int Units { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
