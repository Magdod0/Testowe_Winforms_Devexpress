using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_WinF_Dev.Models
{
    public class WarehouseDocument
    {
        public WarehouseDocument()
        {
            OrderWarehouseItems = new List<OrderWarehouseItem>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [DefaultValue(typeof(DateTime), "GETDATE()")]
        public DateTime CreatedDate { get; set; }
        public DateTime? DocunmentDate { get; set; }
        public long? WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<OrderWarehouseItem> OrderWarehouseItems { get; set; }
    }
}