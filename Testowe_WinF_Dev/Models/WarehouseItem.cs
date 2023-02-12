using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Testowe_WinF_Dev.Models
{
    public class WarehouseItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long? WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [StringLength(30, MinimumLength =3)]
        public string Name { get; set; }
        [Range(0, int.MaxValue - 1, ErrorMessage = "Can't be less than 0!"), DefaultValue(0)]
        public int UnitsAtBeginning { get; set; }
        [Range(0, int.MaxValue - 1, ErrorMessage = "Can't be less than 0!"), DefaultValue(0), ConcurrencyCheck]
        public int UnitsLeft { get; set; }
        [DefaultValue(0)]
        public decimal Netto { get; set; }
        [DefaultValue(0)]
        public decimal Brutto { get; set; }
        [DefaultValue(typeof(DateTime), "GETDATE()")]
        public DateTime ArrivalDate { get; set; }
    }
}
