using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_WinF_Dev.Models
{
    public class OrderWarehouseItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long WarehouseItemID { get; set; }
        public virtual WarehouseItem WarehouseItem { get; set; }
        public long WarehouseDocumentID { get; set; }
        public virtual WarehouseDocument WarehouseDocument { get; set; }
        [Range(1, int.MaxValue - 1, ErrorMessage = "Can't be less than 1!"), DefaultValue(0)]
        public int Units { get; set; }
        public DateTime OrderDate { get; set; }
    }
}