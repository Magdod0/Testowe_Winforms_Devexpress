using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_WinF_Dev.Models
{
    public class Warehouse
    {
        public Warehouse()
        {
            Products = new List<WarehouseItem>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display()]
        public long ID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Address { get; set; }
        public virtual ICollection<WarehouseItem> Products { get; set; }

    }
}